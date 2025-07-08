using System;
using System.Data;
using System.Data.SqlClient;
using Screens.Components.SuperInterfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screens.Components
{
    class Rental : DBInputOutput
    {
        /*fields */
        private int id;
        private string rentalDate;
        private string returnDate;
        private Customer customer;
        private Vehicle vehicle;

        public Rental() { }

        public Rental(int id, string rentalDate, string returnDate)
        {
            this.id = id;
            this.rentalDate = rentalDate;
            this.returnDate = returnDate;
        }

        /*Properties*/
        public Customer Customer_ { get { return customer; } set { customer = value; } }
        public Vehicle Vehicle_ { get { return vehicle; } set { vehicle = value; } }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string RentalDate
        {
            get { return rentalDate; }
            set { rentalDate = value; }
        }

        public string ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        /*coding inherited fuctions*/
        public void Insert()
        {
            try
            {
                SqlCommand cmd = DBConnection.SqlCmd(
                    "EXEC Insert_FullRentalsData "
                    + id + ", '"
                    + rentalDate + "', '"
                    + returnDate + "', "
                    + customer.Id + ", '"
                    + customer.Name + "', '"
                    + vehicle.NumberPlate + "', "
                    + customer.CustomerPay.ID + ", 1, '"
                    + customer.CustomerPay.CardNumber + "', "
                    + customer.CustomerPay.Amount + ", 0;  "
                    );
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred" + ex.Message, "Error");
            }
        }
        public void Update()
        {
            try
            {
                SqlCommand cmd = DBConnection.SqlCmd(
                   "EXEC Update_FullRentalsData "
                   + id + ", '"
                   + rentalDate + "', '"
                   + returnDate + "', "
                   + customer.Id + ", '"
                   + customer.Name + "', '"
                   + vehicle.NumberPlate + "', "
                   + customer.CustomerPay.ID + ", 1, '"
                   + customer.CustomerPay.CardNumber + "', "
                   + customer.CustomerPay.Amount + ", 0;  "
                   );
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred" + ex.Message, "Error");
            }
        }

        public DataTable Display()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "EXEC Get_FullRentalData;";
                SqlDataReader reader = DBConnection.SqlReader(query);
                dt.Load(reader);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred" + ex.Message, "Error");
            }
            return dt;
        }

        public static string NewRentalId()
        {
            try
            {
                string query = "EXEC GetNewRentalID;";
                SqlDataReader reader = DBConnection.SqlReader(query);

                reader.Read();
                return reader["ID"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred" + ex.Message, "Error");
                return null;
            }
        }
    }
}
