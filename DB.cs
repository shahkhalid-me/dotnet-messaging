using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Messaging
{
    class DB
    {
        private static OleDbConnection connection;
        public static OleDbConnection OpenConnection(string ConnectionString)
        {
            if (connection == null)
            {
                connection = new OleDbConnection();
            }
            connection.ConnectionString = ConnectionString;

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;

        }
        public static OleDbConnection OpenConnection()
        {
            if (connection == null)
            {
                connection = new OleDbConnection();
                string Path = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                connection.ConnectionString = " Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + "\\sms.accdb;";
                //connection.ConnectionString = " Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|sms.accdb;";
            }

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;

        }


        public static DataTable Select(string query)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, OpenConnection());
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }

        public static OleDbDataReader SelectFirst(string query)
        {
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandText = query;
            cmd.Connection = OpenConnection();
            OleDbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);
            //connection.Close();
            return reader;
        }

        public static bool Query(string query)
        {

            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandText = query;
            cmd.Connection = OpenConnection();
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }
    }
}
