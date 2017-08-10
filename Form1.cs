using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NerdsInn.Messaging;
namespace DotNet_Messaging
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        SMSController smsController;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            smsController = new SMSController();

            /*
             * smsController = new SMSController(); // Default Port = 3000 , Default IP = Your default local Ip
             * 
             * smsController = new SMSController(3333); // Start On different Port
             * 
             * smsController = new SMSController("192.168.10.10",3333); // Start On different Port and different IP(In case of multiple NetworkInterfaces)
             *                          OR
             *  
             *  IPAddress address = IPAddress.Parse("192.168.10.19");           
             *  IPEndPoint EndPoint =  new IPEndPoint(address,3333)            
             * smsController = new SMSController(EndPoint); // Pass an IPEndPoint 
             * 
             */

            FillGridView();
            
            if (smsController.StartWatching())
            {
                WriteToConsole("Started watching for SMS on port:  " + smsController.GetAddress());
                smsController.OnDeviceBlocked += SmsController_OnDeviceBlocked;
                smsController.OnDeviceConnected += SmsController_OnDeviceConnected;
                smsController.OnDeviceDisconnected += SmsController_OnDeviceDisconnected;
                smsController.OnDeviceUnblocked += SmsController_OnDeviceUnblocked;
                smsController.OnMessageReceived += SmsController_OnMessageReceived;
                smsController.OnPassCodeVerified += SmsController_OnPassCodeVerified;
                smsController.OnMessageSent += SmsController_OnMessageSent;
            }
        }
        private void SmsController_OnMessageSent(object sender, SMSController.SMS sms)
        {
            int count = int.Parse(lblSent.Text);
            count++;

            lblSent.Invoke(new Action(() => {
                lblSent.Text = count.ToString();
            }));

            WriteToConsole("SMS sent successfully to:  " + sms.address);
        }

        private void SmsController_OnPassCodeVerified(object sender, SMSController.Device device)
        {
            if (device != null)
            {
                device.Verify(smsController);
                WriteToConsole("Passcode verifed successfully on " + device.manufacturer + "(" + device.model + ")");
            }
        }

        private void SmsController_OnMessageReceived(object sender, SMSController.SMS sms)
        {
            int count = int.Parse(lblReceived.Text);
            count++;
            lblReceived.Invoke(new Action(() => {
                lblReceived.Text = count.ToString();
            }));
            try
            {
                WriteToConsole("New SMS recevied From : " + sms.address + "\n" + sms.body);
            }
            catch (Exception ex)
            {

            }
        }

        private void SmsController_OnDeviceUnblocked(object sender, SMSController.Device device)
        {
            if (device != null)
                WriteToConsole(device.manufacturer + "(" + device.model + ") unblocked successfully");
        }

        private void SmsController_OnDeviceDisconnected(object sender, SMSController.Device device)
        {
            if (device != null)
                WriteToConsole(device.connectionId + "disconnected");

            FillGridView();
        }

        private void SmsController_OnDeviceConnected(object sender, SMSController.Device device)
        {
            if (device != null)
            {
                device.RequestPassCode(GeneratePassCode(4));
                WriteToConsole(device.manufacturer + "(" + device.model + ") connected");
            }

            FillGridView();
        }

        private void SmsController_OnDeviceBlocked(object sender, SMSController.Device device)
        {

            WriteToConsole(device.manufacturer + "(" + device.model + ") blocked successfully");
        }
        private void btnSendSMS_Click(object sender, EventArgs e)
        {
            SMSController.SMS sms = new SMSController.SMS();
            sms.body = txtMessage.Text;
            sms.address = txtTo.Text;

            var device = GetSelectedDevice();
            if (device != null)
            {
                //Send SMS
                //device.SendSMS(sms);
                //sms.Send(device);

                sms.Send(device);


                //Clear Inputs
                txtMessage.Text = "";
                txtTo.Text = "";
            }
        }
        private void btnPasscode_Click(object sender, EventArgs e)
        {
            var device = GetSelectedDevice();
            if (device != null)
                device.RequestPassCode(GeneratePassCode(4));
            FillGridView();
        }
        private void btnVerify_Click(object sender, EventArgs e)
        {
            var device = GetSelectedDevice();
            if (device != null)
                device.Verify(smsController);
        }

        private void btnUnblock_Click(object sender, EventArgs e)
        {
            var device = GetSelectedDevice();
            if (device != null)
                device.Unblock(smsController);
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            var device = GetSelectedDevice();
            if (device != null)
                device.Block(smsController);
        }

        private void btnDBSms_Click(object sender, EventArgs e)
        {
            if (btnDBSms.Text == "Send DB SMS")
            {
                btnDBSms.Text = "Stop Sending";
                timer1.Enabled = true;
            }
            else
            {
                btnDBSms.Text = "Send DB SMS";
                timer1.Enabled = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (smsController.AllVerifiedDevices().Count > 0)
            {
                var dt = DB.Select("SELECT TOP " + smsController.AllVerifiedDevices().Count + " *  FROM messages where status = 0  ORDER BY ID DESC");
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Database Table is empty.");
                    timer1.Enabled = false;
                    btnDBSms.Text = "Send DB SMS";
                }
                else
                {
                    foreach (DataRow row in dt.Rows)
                    {

                        var device = smsController.AllVerifiedDevices()[(dt.Rows.IndexOf(row))];
                        SMSController.SMS sms = new SMSController.SMS();
                        sms.id = row["id"].ToString();
                        sms.address = row["mobile"].ToString();
                        sms.body = row["message"].ToString();

                        //Message can be send by two methods

                        //Method 1
                        //sms.Send(device);

                        //Method 2
                        if (device != null)
                        {
                            DB.Query("UPDATE messages SET status = 1  WHERE ID =" + sms.id);
                            device.SendSMS(sms);
                        }

                    }

                }

            }
        }



        /*
         * 
         * ********************************************************************************************************
         *                                      Helper Functions 
         * *******************************************************************************************************
         * 
         */


        // Write Data to Console
        internal void WriteToConsole(String message)
        {
            if (RichTextBoxConsole.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                    WriteToConsole(message)
                ));
                return;
            }
            RichTextBoxConsole.Text = message + Environment.NewLine + RichTextBoxConsole.Text;
        }



        // Update Grid View of connected devices
        public void FillGridView()
        {
            DataTable table = new DataTable();
            table.Columns.Add("#");
            table.Columns.Add("IMEI");
            table.Columns.Add("IP");
            table.Columns.Add("Name");
            table.Columns.Add("OS");
            table.Columns.Add("Pass Code");

            foreach (var _device in smsController.AllConnectedDevices())
            {

                DataRow dr = table.NewRow();
                dr["#"] = smsController.AllConnectedDevices().IndexOf(_device) + 1;
                dr["IMEI"] = _device.imei;
                dr["IP"] = _device.ip;
                dr["Name"] = _device.manufacturer + " - " + _device.model;
                dr["OS"] = _device.platform + "(" + _device.version + ")";
                dr["Pass Code"] = _device.passCode.onServer;
                table.Rows.Add(dr);
            }

            dataGridView1.Invoke(new Action(() =>
            {
                dataGridView1.DataSource = table;
                for (var i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dataGridView1.Columns["#"].Width = 50;
                dataGridView1.Columns["#"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns["Pass Code"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }));
        }

        // this will return selected device in the datagridview
        private SMSController.Device GetSelectedDevice()
        {
            Int64 imei = 0;
            if (dataGridView1.RowCount > 0)
            {
                imei = Int64.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["IMEI"].Value.ToString());
            }
            var device = smsController.GetDeviceByIMEI(imei);
            return device;
        }


        public string GeneratePassCode(int size = 6)
        {
            Random random = new Random();
            const string chars = "abcdefghijkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, size)
                            .Select(s => s[random.Next(s.Length)]).ToArray());

        }

       
    }
}
