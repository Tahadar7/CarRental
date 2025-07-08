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
    class Truck : Vehicle
    {
        private int loadCapacity;

        public Truck(string numberPlate, string brand, string model, double price, int loadCapacity)
        {
            this.numberPlate = numberPlate;
            this.brand = brand;
            this.model = model;
            this.price = price;
            this.loadCapacity = loadCapacity;
        }

        public Truck()
        {

        }

        private int LoadCapacity { get { return loadCapacity; } set { loadCapacity = value; } }

        public override void Insert()
        {
            try
            {
                SqlCommand cmd = DBConnection.SqlCmd("EXEC Insert_Trucks '" + brand + "', '" + model + "', " + price + ", '" + numberPlate + "', " + loadCapacity + ";");
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
                SqlCommand cmd = DBConnection.SqlCmd("EXEC Update_Truck '" + brand + "', '" + model + "', " + price + ", '" + numberPlate + "', " + loadCapacity + ";");
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
                string query = "EXEC Get_Trucks;";
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

        public static DataTable AvailTrucks()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM availableTruckView;";
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
        public bool Check_TruckPlate(string plate)
        {
            try
            {
                DBConnection.Connect();

                SqlDataReader reader = DBConnection.SqlReader("EXEC Check_TruckPlate '" + plate + "';");
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
