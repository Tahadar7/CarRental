using System;
using Screens.Components.SuperInterfaces;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace Screens.Components
{
    class Customer : DBInputOutput
    {
        /*fields */
        private int id;
        private string name;
        private int age;
        private string address;
        private string cell;
        private int isVIP;
        private Payment payment;

        /*Constructor*/
        public Customer() { }

        public Customer(string id, string name, int age, string address, string cell, bool vip)
        {
            this.id = int.Parse(id);
            this.name = name;
            this.age = age;
            this.address = address;
            this.cell = cell;
            IsVIP = vip;
        }

        /*Properties*/
        public Payment CustomerPay { get { return payment; } set { payment = value; } }

        public int Id { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }

        public string Address { get { return address; } set { address = value; } }

        public bool IsVIP
        {
            get
            {
                if (isVIP == 1) { return true; }
                else { return false; }
            }
            set
            {
                if (value) { isVIP = 1; }
                else { isVIP = 0; }
            }
        }


        public string Cell { get { return cell; } set { cell = value; } }

        public int Age { get { return age; } set { age = value; } }

        /*coding inherited fuctions*/
        public void Insert()
        {
            try
            {
                SqlCommand cmd = DBConnection.SqlCmd("EXEC Insert_Customer " + id + ", " + age + ", " + isVIP + ", '" + cell + "', '" + name + "', '" + address + "';");
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured" + ex.Message, "Error");
            }
        }

        public void Update()
        {
            try
            {
                SqlCommand cmd = DBConnection.SqlCmd("EXEC Update_Customer " + id + ", " + age + ", " + isVIP + ", '" + cell + "', '" + name + "', '" + address + "';");
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured" + ex.Message, "Error");
            }
        }

        public DataTable Display()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "EXEC Get_Customers;";
                SqlDataReader reader = DBConnection.SqlReader(query);
               
                dt.Load(reader);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured" + ex.Message, "Error");
            }
            return dt;
        }

        public static string NewCustId()
        {
            try
            {
                string query = "EXEC GetNewCusId;";
                SqlDataReader reader = DBConnection.SqlReader(query);

                reader.Read();
                return reader["ID"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured" + ex.Message, "Error");
                return null;
            }
        }

        public static string[] CheckCustomer(string id)
        {
            string[] r = new string[2] { "", "" };

            try
            {
                string query = "EXEC Check_Customer_ID " + id + ";";
                SqlDataReader reader = DBConnection.SqlReader(query);

                if (reader.Read())
                {
                    r[0] = reader["count_"].ToString();
                }

                query = "EXEC Check_CustomerName " + id + ";";
                SqlDataReader reader1 = DBConnection.SqlReader(query);

                if (reader1.Read())
                {
                    r[1] = reader1["customerName"].ToString();
                }

                return r;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Data Found in Database" + ex.Message, "Error");
            }

            return r;
        }


    }
}