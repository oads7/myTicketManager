using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace myTicketManager.Models
{
    class DBO
    {
        SqlConnection connection;
        private string connectionString;
        private bool connectionState;

        public bool IsConnected
        {
            get {
                    return connectionState;
                }
        }

        public DBO(string ConnectionString)
        {
            this.connectionString = ConnectionString;

            try
            {
                connection = new SqlConnection(connectionString);
                connectionState = true;
            }
            catch (Exception ex)
            {
                Log.WriteException(ex);

                connection = new SqlConnection();
                connectionState = false;
            }
        }

        public string ConnectionString
        {
            get {
                    return connectionString;
                }
            set {
                    connectionString = value;
                }
        }

        public void Open()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Log.WriteException(ex);
            }
        }

        public void Close()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                Log.WriteException(ex);
            }
        }

        public Task<SqlDataReader> Query(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                return cmd.ExecuteReaderAsync();
            }
            catch (Exception ex)
            {
                Log.WriteException(ex);
                return null;
            }
        }


}
}
