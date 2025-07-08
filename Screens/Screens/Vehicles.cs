using System;
using Screens.Components;
using Screens.Components.SuperInterfaces;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screens
{
    public partial class Vehicles : Form, IResetFormsState
    {
        private string vehType = "truck";

        private void Load_Veh(int typ)
        {
            if (typ == 0)
            {
                Truck truck = new Truck();
                displayVehGridView.DataSource = truck.Display();
            }
            else
            {
                Car car = new Car();
                displayVehGridView.DataSource = car.Display();
            }

        }

        public void Reset_All_Fields()
        {
            numbPlateTxt.Text = "";
            brandTxt.Text = "";
            modelTxt.Text = "";
            priceTxt.Text = "";
            priceValTxt.Text = "";
            specialtext.Text = "";
            brandValTxt.Text = "";
            numplateValText.Text = "";
            modelValText.Text = "";
            specialInputText.Text = "";

            AddBtn.Enabled = true;
            updateBtn.Enabled = false;
            numbPlateTxt.Enabled = true;
        }

        public Vehicles()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (Utilz.questionBox("Are you sure?", "Logout"))
            {
                SignIn signIn = new SignIn();
                signIn.Show();
                this.Hide();
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void exitIconBtn_Click(object sender, EventArgs e)
        {
            if (Utilz.questionBox())
                Application.Exit();
        }

        private void minimizeIconBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (
         string.IsNullOrEmpty(numbPlateTxt.Text) || string.IsNullOrEmpty(brandTxt.Text)
         || string.IsNullOrEmpty(modelTxt.Text) || string.IsNullOrEmpty(priceTxt.Text)
         || string.IsNullOrEmpty(specialInputText.Text)
           )

            {
                MessageBox.Show("Fill all the fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if
               (numplateValText.Visible || brandValTxt.Visible || modelValText.Visible || priceValTxt.Visible || specialtext.Visible)
            {
                MessageBox.Show("Invalid input! Fill all the fields correctly", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else {
                try
                {
                    if (trueIfCar.Checked)
                    {
                        Car newCar = new Car(
                            numbPlateTxt.Text,
                            brandTxt.Text,
                            modelTxt.Text,
                            double.Parse(priceTxt.Text),
                            int.Parse(specialInputText.Text)
                        );

                        if (!newCar.Check_CarPlate(numbPlateTxt.Text))
                        {
                            MessageBox.Show("Number Plate is not Available", "Duplication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        newCar.Insert();
                        Load_Veh(1);
                        MessageBox.Show("Record Added", "Car");
                        Reset_All_Fields();

                    }
                    else
                    {
                        Truck newTruck = new Truck(
                                numbPlateTxt.Text,
                                brandTxt.Text,
                                modelTxt.Text,
                                double.Parse(priceTxt.Text),
                                int.Parse(specialInputText.Text)
                            );

                        if (!newTruck.Check_TruckPlate(numbPlateTxt.Text))
                        {
                            MessageBox.Show("Number Plate is not Available", "Duplication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        newTruck.Insert();
                        Load_Veh(0);

                        MessageBox.Show("Record Added", "Truck");
                        Reset_All_Fields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred " + ex.Message, "Error");
                }
            }
        }
        private void Vehicles_Load(object sender, EventArgs e)
        {
            Reset_All_Fields();

            truckTabUnderline.BackColor = Color.White;
            carTabUnderline.BackColor = Color.DarkGray;
            vehType = "car";

            updateBtn.Enabled = false;
            AddBtn.Enabled = true;

            /*Loading car data*/
            Load_Veh(1);

        }

        private void carTabBtn_Click(object sender, EventArgs e)
        {
            truckTabUnderline.BackColor = Color.White;
            carTabUnderline.BackColor = Color.DarkGray;

            specialVehTxt.Text = "No Of Passsengers";
            vehType = "car";

            /*Loading car data*/
            Load_Veh(1);
        }

        private void truckTabBtn_Click(object sender, EventArgs e)
        {
            truckTabUnderline.BackColor = Color.DarkGray;
            carTabUnderline.BackColor = Color.White;

            specialVehTxt.Text = "Load Capacity";
            vehType = "truck";

            /*Loading Truck data*/
            Load_Veh(0);
        }

        private void adminProfileBtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void displayVehGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                updateBtn.Enabled = true;
                AddBtn.Enabled = false;

                numbPlateTxt.Text = displayVehGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                brandTxt.Text = displayVehGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                modelTxt.Text = displayVehGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                priceTxt.Text = displayVehGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                specialInputText.Text = displayVehGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                numbPlateTxt.Enabled = false;  // Disabling the NumberPlate TextBox

                if (vehType == "car")
                {
                    trueIfCar.Checked = true;
                }
                else
                {
                    trueIfCar.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred " + ex.Message, "Error");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (
                   string.IsNullOrEmpty(numbPlateTxt.Text) || string.IsNullOrEmpty(brandTxt.Text)
                  || string.IsNullOrEmpty(modelTxt.Text) || string.IsNullOrEmpty(priceTxt.Text)
                    || string.IsNullOrEmpty(specialInputText.Text)
                  )

            {
                MessageBox.Show("Fill all the fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if
               (numplateValText.Visible || brandValTxt.Visible || modelValText.Visible || priceValTxt.Visible || specialtext.Visible)
            {
                MessageBox.Show("Invalid input! Fill all the fields correctly", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    if (trueIfCar.Checked)
                    {
                        Car newCar = new Car(
                              numberPlate: numbPlateTxt.Text,
                              brand: brandTxt.Text,
                               model: modelTxt.Text,
                               price: double.Parse(priceTxt.Text),
                             noOfPassengers: int.Parse(specialInputText.Text)
                            );
                        newCar.Update();
                        Load_Veh(1);
                        MessageBox.Show("Record Updated", "Car");
                        Reset_All_Fields();
                    }
                    else
                    {

                        Truck newTruck = new Truck(
                                 numberPlate: numbPlateTxt.Text,
                              brand: brandTxt.Text,
                               model: modelTxt.Text,
                               price: double.Parse(priceTxt.Text),
                             loadCapacity: int.Parse(specialInputText.Text)
                                );
                        newTruck.Update();
                        Load_Veh(0);
                        MessageBox.Show("Record Updated", "Truck");
                        Reset_All_Fields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred " + ex.Message, "Error");
                }
            }
        }

        private void reloadIconBtn_Click(object sender, EventArgs e)
        {
            updateBtn.Enabled = false;
            AddBtn.Enabled = true;

            numbPlateTxt.Enabled = true;
            Reset_All_Fields();
        }

        private void reloadText_Click(object sender, EventArgs e)
        {
            updateBtn.Enabled = false;
            AddBtn.Enabled = true;

            numbPlateTxt.Enabled = true;
            Reset_All_Fields();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trueIfCar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trueIfCar_Click(object sender, EventArgs e)
        {
            if (trueIfCar.Checked)
            {
                specialInputText.PlaceholderText = "No of Passengers";
            }
            else
            {
                specialInputText.PlaceholderText = "Load Capacity";
            }
        }
        private void specialInputText_TextChanged(object sender, EventArgs e)
        {
            int number;

            specialtext.Visible = false; 

            // Check if the input text is null or empty, if so hide the message and exit
            if (string.IsNullOrEmpty(specialInputText.Text))
            {
                return;
            }

            if (trueIfCar.Checked)
            {
                
                if (int.TryParse(specialInputText.Text, out number))
                {
                    
                    if (number < 1 || number > 9)
                    {
                        specialtext.Visible = true;
                        specialtext.ForeColor = Color.Red;
                        specialtext.Text = "Must be between 1 and 9";
                    }
                    else
                    {
                        specialtext.Visible = false; 
                    }
                }
            }
            else 
            {
                if (specialInputText.Text.Length > 5)
                {
                    specialtext.ForeColor = Color.Red;
                    specialtext.Visible = true;
                    specialtext.Text = "Maximum digits are 5";
                }
                else if (int.TryParse(specialInputText.Text, out number))
                {
                    if (number <= 0)
                    {
                        specialtext.Visible = true;
                        specialtext.ForeColor = Color.Red;
                        specialtext.Text = "Must be greater than zero";
                    }
                    else
                    {
                        specialtext.Visible = false; 
                    }
                }
            }
        }


        private void modelTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(modelTxt.Text))
            {
                modelValText.Visible = false;
            }
            else if(modelTxt.Text.Length > 20)
            {
                modelValText.ForeColor = Color.Red;
                modelValText.Visible = true;
                modelValText.Text = "Maximum Characters are 20";
            }
            else
            {
                modelValText.Visible = false;
            }
        }

        private void brandTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(brandTxt.Text))
            {
                brandValTxt.Visible = false;
            }
            else if(brandTxt.Text.Length > 20)
            {
                brandValTxt.ForeColor = Color.Red;
                brandValTxt.Visible = true;
                brandValTxt.Text = "Maximum Characters are 20";
            }
            else
            {
                brandValTxt.Visible = false;
            }
        }

        private void numbPlateTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numbPlateTxt.Text))
            {
                numplateValText.Visible = false;
            }
            else if(numbPlateTxt.Text.Length > 10)
            {
                numplateValText.Visible = true;
                numplateValText.ForeColor = Color.Red;
                numplateValText.Text = "Maximum Characters are 10";
            }
            else
            {
                numplateValText.Visible = false;
            }
        }

        

        private void priceTxt_TextChanged(object sender, EventArgs e)
        {
            double price;
           
            if (priceTxt.Text.Length > 10)
            {
                priceValTxt.ForeColor = Color.Red;
                priceValTxt.Visible = true;
                priceValTxt.Text = "Maximum Charaters are 10";
            }
           else if (string.IsNullOrEmpty(priceTxt.Text))
            {
                priceValTxt.Visible = false;
            }
            else if (double.TryParse(priceTxt.Text, out price))
            {
                if (price <= 0)
                {
                    priceValTxt.Visible = true;
                    priceValTxt.ForeColor = Color.Red;
                    priceValTxt.Text = "Price must gretaer than 0";
                }
                else
                {
                    priceValTxt.Visible = false;
                }
            }
        }

        private void displayVehGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void specialInputText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && c != 8 && c != 46 && c != 13 && c != 9 && !char.IsControl(c))
            {
                e.Handled = true;
                specialtext.Visible = true;
                specialtext.ForeColor = Color.Red;
                specialtext.Text = "Only digits are allowed";
            }

            else
            {
                specialtext.Visible = false;
            }
        }

        private void specialtext_Click(object sender, EventArgs e)
        {

        }

        private void priceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && c != 8 && c != 46 && c != 13 && c != 9 && !char.IsControl(c))
            {
                e.Handled = true;
                priceValTxt.Visible = true;
                priceValTxt.ForeColor = Color.Red;
                priceValTxt.Text = "Only digits are allowed";
            }
            else
            {
                priceValTxt.Visible = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void brandTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetter(c) && c!= 32 && !char.IsControl(c))
            {
                e.Handled = true;
                brandValTxt.Visible = true;
                brandValTxt.ForeColor = Color.Red;
                brandValTxt.Text = "Only Letters,spaces allowed";
            }
            else
            {
                brandValTxt.Visible = false;
            }
        }

        private void numbPlateTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetterOrDigit(c) && c != '-' && !char.IsControl(c))
            {
                e.Handled = true;
                numplateValText.ForeColor = Color.Red;
                numplateValText.Visible = true;
                numplateValText.Text = "Only letters,digits,hyphen are allowed";
            }
            else
            {
                numplateValText.Visible = false;
            }
        }

        private void modelTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
             
            if(!char.IsLetterOrDigit(c) && c != 32 && c!= '-' && c !='/' && c != '\\' && !char.IsControl(c)) {
                
                e.Handled = true;
                modelValText.Visible = true;
                modelValText.ForeColor = Color.Red;
                modelValText.Text = "Letters,Digits,hyphens allowed";
            }
            else { modelValText.Visible = false; }
        }
    }
}
