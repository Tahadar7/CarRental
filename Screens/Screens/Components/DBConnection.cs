using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screens.Components
{
    static class DBConnection
    {
         private static SqlConnection connection;
         private static string connectionString; /*saving the connection string into class fields*/
        static DBConnection()
        {
          connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
Initial Catalog=ProjectOOP;
Integrated Security=True;
Encrypt=False;
TrustServerCertificate=True";

        }

        public static SqlConnection Connect()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured" + ex.Message, "Error");
                return null;
            }

        }
        public static SqlCommand SqlCmd(string query)
        {
            try
            {
                Connect();

              SqlCommand  cmd = new SqlCommand(query, connection);
                return cmd;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured" + ex.Message, "Error");
                return null;
            }
        }

        public static SqlDataReader SqlReader(string query)
        {
            try
            {
                Connect();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                return reader;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Occured" + ex.Message, "Error");
                return null;
            }
        }
    }
}
