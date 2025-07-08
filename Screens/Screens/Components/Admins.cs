using System;
using System.Text;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.CodeDom.Compiler;

namespace Screens.Components
{
    class Admin
    {
        private static string username;
        private static string name;
        private static string address;
        private static string email;
        private static string cell;

        public static string Username { get { return username; } set { username = value; } }
        public static string Name { get { return name; } set { name = value; } }
        public static string Address { get { return address; } set { address = value; } }
        public static string Email { get { return email; } set { email = value; } }
        public static string Cell { get { return cell; } set { cell = value; } }

        public static void Update(string _username, string passwd)
        {
            try
            {
                DBConnection.Connect();

                SqlDataReader reader = DBConnection.SqlReader("EXEC Update_AdminData '" + _username + "', '" + HashPassword(passwd)
                    + "', '" + name + "', '" + email + "', '" + address + "', '" + cell + "';");

                reader.Read();
                username = _username;
                name = reader["name_"].ToString();
                cell = reader["cell"].ToString();
                address = reader["address_"].ToString();
                email = reader["email"].ToString();
            }
            catch
            {
                
            }

        }

        public static bool login(string _username, string passwd)
        {
            try
            {
                DBConnection.Connect();

                SqlDataReader reader = DBConnection.SqlReader(
                   "EXEC HandleLogin '"
                    + _username + "', '" +
                    HashPassword(passwd) + "';"
                );
                if (reader.Read())
                {
                    username = _username;
                    name = reader["name_"].ToString();
                    cell = reader["cell"].ToString();
                    address = reader["address_"].ToString();
                    email = reader["email"].ToString();

                    return true;
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("No Data Found" + ex.Message, "Error");
               
            }
            return false;

        }

        public static void SignUP(string passwd)
        {
            try
            {
                DBConnection.Connect();

                SqlDataReader reader = DBConnection.SqlReader(
                   "EXEC HandleSignUp '" + username
                   + "', '" + HashPassword(passwd) + "', '"
                   + name + "', '" + email
                   + "', '" + address + "', '"
                   + cell + "';"
                );

                MessageBox.Show("Your case is sent to Admin", "Sign Up");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured" + ex.Message, "Error");
            }
        }

        public static bool Check_Avail_Username(string _username)
        {
            try
            {
                DBConnection.Connect();

                SqlDataReader reader = DBConnection.SqlReader("EXEC Check_Username '" + _username + "';");
                reader.Read();
                if (reader["US"].ToString() == "0")
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured" + ex.Message, "Error");
            }
            return false;
        }

        private static string HashPassword(string password)
        {
            SHA1CryptoServiceProvider pass = new SHA1CryptoServiceProvider();

            byte[] pass_byte = Encoding.ASCII.GetBytes(password);
            byte[] enc_pass = pass.ComputeHash(pass_byte);

            return Convert.ToBase64String(enc_pass);
        }

    }
}
