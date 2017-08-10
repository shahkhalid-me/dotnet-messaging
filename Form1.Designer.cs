namespace DotNet_Messaging
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnVerify = new MetroFramework.Controls.MetroButton();
            this.btnDBSms = new MetroFramework.Controls.MetroButton();
            this.btnPasscode = new MetroFramework.Controls.MetroButton();
            this.btnUnblock = new MetroFramework.Controls.MetroButton();
            this.btnBlock = new MetroFramework.Controls.MetroButton();
            this.lblReceived = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSendSMS = new MetroFramework.Controls.MetroButton();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RichTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 7000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(455, 336);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(86, 32);
            this.btnVerify.TabIndex = 33;
            this.btnVerify.Text = "Verify";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnDBSms
            // 
            this.btnDBSms.Location = new System.Drawing.Point(633, 336);
            this.btnDBSms.Name = "btnDBSms";
            this.btnDBSms.Size = new System.Drawing.Size(102, 32);
            this.btnDBSms.TabIndex = 34;
            this.btnDBSms.Text = "Send DB SMS";
            this.btnDBSms.Click += new System.EventHandler(this.btnDBSms_Click);
            // 
            // btnPasscode
            // 
            this.btnPasscode.Location = new System.Drawing.Point(332, 336);
            this.btnPasscode.Name = "btnPasscode";
            this.btnPasscode.Size = new System.Drawing.Size(117, 32);
            this.btnPasscode.TabIndex = 35;
            this.btnPasscode.Text = "Request Passcode";
            this.btnPasscode.Click += new System.EventHandler(this.btnPasscode_Click);
            // 
            // btnUnblock
            // 
            this.btnUnblock.Location = new System.Drawing.Point(240, 336);
            this.btnUnblock.Name = "btnUnblock";
            this.btnUnblock.Size = new System.Drawing.Size(86, 32);
            this.btnUnblock.TabIndex = 36;
            this.btnUnblock.Text = "Unblock";
            this.btnUnblock.Click += new System.EventHandler(this.btnUnblock_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(148, 336);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(86, 32);
            this.btnBlock.TabIndex = 37;
            this.btnBlock.Text = "Block";
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceived.ForeColor = System.Drawing.Color.Silver;
            this.lblReceived.Location = new System.Drawing.Point(660, 190);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(32, 39);
            this.lblReceived.TabIndex = 31;
            this.lblReceived.Text = "0";
            this.lblReceived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(514, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 39);
            this.label7.TabIndex = 32;
            this.label7.Text = "Received :";
            // 
            // btnSendSMS
            // 
            this.btnSendSMS.Location = new System.Drawing.Point(378, 34);
            this.btnSendSMS.Name = "btnSendSMS";
            this.btnSendSMS.Size = new System.Drawing.Size(86, 44);
            this.btnSendSMS.TabIndex = 21;
            this.btnSendSMS.Text = "Send SMS";
            this.btnSendSMS.Click += new System.EventHandler(this.btnSendSMS_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(68, 58);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(304, 20);
            this.txtTo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Message :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "To :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "From : ";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(68, 82);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(396, 66);
            this.txtMessage.TabIndex = 17;
            // 
            // txtFrom
            // 
            this.txtFrom.Enabled = false;
            this.txtFrom.Location = new System.Drawing.Point(68, 34);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(304, 20);
            this.txtFrom.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSendSMS);
            this.groupBox1.Controls.Add(this.txtTo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.txtFrom);
            this.groupBox1.Location = new System.Drawing.Point(17, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 176);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send New Message";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Connected Devices";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Console";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 374);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(721, 129);
            this.dataGridView1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 79);
            this.label2.TabIndex = 24;
            this.label2.Text = "DotNet Messaging";
            // 
            // lblSent
            // 
            this.lblSent.AutoSize = true;
            this.lblSent.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSent.ForeColor = System.Drawing.Color.Silver;
            this.lblSent.Location = new System.Drawing.Point(660, 124);
            this.lblSent.Name = "lblSent";
            this.lblSent.Size = new System.Drawing.Size(32, 39);
            this.lblSent.TabIndex = 25;
            this.lblSent.Text = "0";
            this.lblSent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(566, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 39);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sent :";
            // 
            // RichTextBoxConsole
            // 
            this.RichTextBoxConsole.BackColor = System.Drawing.Color.Black;
            this.RichTextBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxConsole.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxConsole.ForeColor = System.Drawing.Color.Lime;
            this.RichTextBoxConsole.Location = new System.Drawing.Point(14, 530);
            this.RichTextBoxConsole.Name = "RichTextBoxConsole";
            this.RichTextBoxConsole.ReadOnly = true;
            this.RichTextBoxConsole.Size = new System.Drawing.Size(721, 100);
            this.RichTextBoxConsole.TabIndex = 23;
            this.RichTextBoxConsole.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 640);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnDBSms);
            this.Controls.Add(this.btnPasscode);
            this.Controls.Add(this.btnUnblock);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.lblReceived);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RichTextBoxConsole);
            this.Name = "frmMain";
            this.Text = "DotNet Messaging";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton btnVerify;
        private MetroFramework.Controls.MetroButton btnDBSms;
        private MetroFramework.Controls.MetroButton btnPasscode;
        private MetroFramework.Controls.MetroButton btnUnblock;
        private MetroFramework.Controls.MetroButton btnBlock;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroButton btnSendSMS;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RichTextBoxConsole;
    }
}

