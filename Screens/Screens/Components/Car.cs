using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Screens.Components
{
    class Car : Vehicle
    {
        private int noOfPassengers;

        public Car() { }

        public Car(string numberPlate, string brand, string model, double price, int noOfPassengers)
        {
            this.numberPlate = numberPlate;
            this.brand = brand;
            this.model = model;
            this.price = price;
            this.noOfPassengers = noOfPassengers;
        }

        private int NoOfPassengers
        {
            get { return noOfPassengers; }
            set { noOfPassengers = value; }
        }
        public override void Insert()
        {
            try
            {
                SqlCommand cmd = DBConnection.SqlCmd("EXEC Insert_Cars '" + brand + "', '" + model + "', " + price + ", '" + numberPlate + "', " + noOfPassengers + ";");
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured" + ex.Message, "Error");
            }
        }

        public override void Update()
        {
            try
            {
                SqlCommand cmd = DBConnection.SqlCmd("EXEC Update_Car '" + brand + "', '" + model + "', " + price + ", '" + numberPlate + "', " + noOfPassengers + ";");

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured" + ex.Message, "Error");
            }
        }

        public override DataTable Display()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "EXEC Get_Cars;";
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

        public static DataTable AvailCars()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM availableCarsView;";
                var reader = DBConnection.SqlReader(query);
                dt.Load(reader);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured" + ex.Message, "Error");
            }
            return dt;
        }
        public bool Check_CarPlate(string plate)
        {
            try
            {
                DBConnection.Connect();

                SqlDataReader reader = DBConnection.SqlReader("EXEC Check_CarPlate '" + plate + "';");
                reader.Read();
                if (reader["count_"].ToString() == "0")
                {
                    return true;
                }
            }
            catch
            {
                
            }
            return false;
        }
    }
}

