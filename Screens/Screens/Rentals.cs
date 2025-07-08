using Screens.Components.SuperInterfaces;
using System;
using Screens.Components;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace Screens
{
    public partial class Rentals : Form, IResetFormsState
    {
        private string selectedVeh;
        private bool isOnRentTab = true;

        public Rentals()
        {
            InitializeComponent();
        }

        public void Reset_All_Fields()
        {
            customerIdTxt.Text = "";
            customerNameTxt.Text = "";
            paymentIdTxt.Text = "";
            cardNumberTxt.Text = "";
            paymentAmountTxt.Text = "";

            customerNameValText.Text = "";
            paywarn.Text = "";
            warnCustomerID.Text = "";
            cardWarnText.Text = "";

            updateBtn.Enabled = false;
            AddBtn.Enabled = true;

            Load_IDs();
        }
        private void Load_IDs()
        {
            rentalidTxt.Text = Rental.NewRentalId();
            paymentIdTxt.Text = Payment.NewPaymentId();
            rentalidTxt.Enabled = false;
            paymentIdTxt.Enabled = false;
        }

        private void Load_Rent()
        {
            Rental rental = new Rental();
            displayRentalGridView.DataSource = rental.Display();

            customerNameValText.Text = "";
            cardWarnText.Text = "";
            paywarn.Text = "";
            warnCustomerID.Text = "";
        }
        private void loadIntoComboBox(string query)
        {
            SqlDataReader reader = DBConnection.SqlReader(query);
            selectVehicleComboBox.Items.Clear();

            while (reader.Read())
            {
                string numbPlate = reader["numberPlate"].ToString();
                string brand = reader["vehicleBrand"].ToString();
                string model = reader["vehicleModel"].ToString();

                string vehicles = numbPlate + ",   " + brand + ",   " + model;

                selectVehicleComboBox.Items.Add(vehicles);
            }
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
            {
                Application.Exit();
            }
        }

        private void minimizeIconBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rentalidTxt.Text) || string.IsNullOrEmpty(customerIdTxt.Text)
                || string.IsNullOrEmpty(customerNameTxt.Text) || string.IsNullOrEmpty(paymentIdTxt.Text)
                || string.IsNullOrEmpty(paymentAmountTxt.Text) || string.IsNullOrEmpty(cardNumberTxt.Text)
                   || selectVehicleComboBox.SelectedItem == null
                    )
            {
                MessageBox.Show("Fill all the fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (warnCustomerID.Visible || customerNameValText.Visible || paywarn.Visible || cardWarnText.Visible)
            {
                MessageBox.Show("Invalid input! Fill all the fields correctly", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                Vehicle vehicle;

                Customer customer = new Customer();
                customer.Name = customerNameTxt.Text;
                customer.Id = int.Parse(customerIdTxt.Text);

                customer.CustomerPay = new Payment(
                        int.Parse(paymentIdTxt.Text),
                        cardNumberTxt.Text,
                        double.Parse(paymentAmountTxt.Text)
                    );

                Rental rental = new Rental(
                        int.Parse(rentalidTxt.Text),
                        Utilz.makeDate(rentalDatePick.Text),
                        Utilz.makeDate(returnDatePick.Text)
                    );

                if (trueIfCar.Checked)
                {
                    vehicle = new Car();
                    vehicle.NumberPlate = selectedVeh;
                    rental.Vehicle_ = vehicle;
                }
                else
                {
                    vehicle = new Truck();
                    vehicle.NumberPlate = selectedVeh;
                    rental.Vehicle_ = vehicle;
                }

                rental.Customer_ = customer;
                rental.Vehicle_ = vehicle;

                    rental.Insert();
                    Load_Rent();
                    MessageBox.Show("Data inserted", "Rentals");
                    Reset_All_Fields();

                    if (trueIfCar.Checked) { loadIntoComboBox("EXEC Get_BrandModelCar;"); }
                    else { loadIntoComboBox("EXEC Get_BrandModelTruck;"); }

                //    PaymentForm paymentForm = new PaymentForm();
                //paymentForm.Show();
                //this.Hide();
                
            }
            }
        private void trueIfCar_Click(object sender, EventArgs e)
        {
            if (!isOnRentTab)
            {
                if (trueIfCar.Checked)
                {
                    availableBtnTab.Text = "Available Car";
                    loadIntoComboBox("EXEC Get_BrandModelCar;");
                    displayRentalGridView.DataSource = Car.AvailCars();
                }
                else
                {
                    availableBtnTab.Text = "Available Truck";
                    loadIntoComboBox("EXEC Get_BrandModelTruck;");
                    displayRentalGridView.DataSource = Truck.AvailTrucks();
                }
            }

        }
        private void selectVehComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVeh = selectVehicleComboBox.SelectedItem.ToString().Split(',')[0].Trim();
        }

        private void adminProfileBtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void displayRentalGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (isOnRentTab)
            {
                AddBtn.Enabled = false;
                updateBtn.Enabled = true;

                customerIdTxt.Text = displayRentalGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                rentalidTxt.Text = displayRentalGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                paymentIdTxt.Text = displayRentalGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                customerNameTxt.Text = displayRentalGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                rentalDatePick.Text = displayRentalGridView.Rows[e.RowIndex].Cells[4].Value.ToString().Split(' ')[0];
                returnDatePick.Text = displayRentalGridView.Rows[e.RowIndex].Cells[5].Value.ToString().Split(' ')[0];
                paymentAmountTxt.Text  = displayRentalGridView.Rows[e.RowIndex].Cells[6].Value.ToString();

                customerIdTxt.Enabled = false;
                customerNameTxt.Enabled = false;
            }
            else
            {
                selectVehicleComboBox.Items.Clear();
                selectVehicleComboBox.Items.Add(
                        displayRentalGridView.Rows[e.RowIndex].Cells[0].Value.ToString()
                        + ",   " + displayRentalGridView.Rows[e.RowIndex].Cells[1].Value.ToString()
                        + ",   " + displayRentalGridView.Rows[e.RowIndex].Cells[2].Value.ToString()
                    );
                selectVehicleComboBox.SelectedIndex = 0;
            }
        }
        private void cardNumberTxt_TextChanged(object sender, EventArgs e)
        {
       
            if (string.IsNullOrEmpty(cardNumberTxt.Text))
            {
                cardWarnText.Visible = false;
            }

            else if (cardNumberTxt.Text.Length != 20)
            {
                cardWarnText.Visible = true;
                cardWarnText.ForeColor = Color.Red;
                cardWarnText.Text = "Card Number Must be 20 Digits";
            }
            else
            {
                cardWarnText.Visible = false;
            }
        }
        private void reloadText_Click(object sender, EventArgs e)
        {
            AddBtn.Enabled = true;
            updateBtn.Enabled = false;
            Reset_All_Fields();

            customerIdTxt.Enabled = true;
            customerNameTxt.Enabled = true;

            selectVehicleComboBox.SelectedIndex = -1;
            selectVehicleComboBox.Text = string.Empty;

            if (isOnRentTab)
            {
                Load_Rent();
            }
            else
            {
                if (trueIfCar.Checked)
                {
                    loadIntoComboBox("EXEC Get_BrandModelCar;");
                    displayRentalGridView.DataSource = Car.AvailCars();
                }
                else
                {
                    loadIntoComboBox("EXEC Get_BrandModelTruck;");
                    displayRentalGridView.DataSource = Truck.AvailTrucks();
                }
            }

        }
        private void availableBtnTab_Click(object sender, EventArgs e)
        {
            LabelcustomerID.Text = "Number Plate";
            LabelRentalID.Text = "";
            LabelPayID.Text = "";
            LabelNameTxt.Text = "Brand";
            LabelRentalDate.Text = "";
            LabelReturnDate.Text = "";
            LabelPayAmount.Text = "Model";
            LabelPayStatus.Text = "";


            rentTab.BackColor = Color.White;
            availVehicleTab.BackColor = Color.DarkGray;
            displayRentalGridView.DataSource = Truck.AvailTrucks();

            isOnRentTab = false;
        }

        private void onRentBtnTab_Click(object sender, EventArgs e)
        {
            rentTab.BackColor = Color.DarkGray;
            availVehicleTab.BackColor = Color.White;

            LabelcustomerID.Text = "Customer ID";
            LabelRentalID.Text = "Rental ID";
            LabelPayID.Text = "Payment ID";
            LabelNameTxt.Text = "Name";
            LabelRentalDate.Text = "Rent Date";
            LabelReturnDate.Text = "Return Date";
            LabelPayAmount.Text = "Pay Amount";
            LabelPayStatus.Text = "Pay Status";

            isOnRentTab = true;
            Load_Rent();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rentalidTxt.Text) || string.IsNullOrEmpty(customerIdTxt.Text)
          || string.IsNullOrEmpty(customerNameTxt.Text) || string.IsNullOrEmpty(paymentIdTxt.Text)
          || string.IsNullOrEmpty(paymentAmountTxt.Text) || string.IsNullOrEmpty(cardNumberTxt.Text)
          || selectVehicleComboBox.SelectedItem == null )
            {
                MessageBox.Show("Fill all the fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (warnCustomerID.Visible || customerNameValText.Visible || paywarn.Visible || cardWarnText.Visible)
            {
                MessageBox.Show("Invalid input! Fill all the fields correctly", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                    Vehicle vehicle;

                    Customer customer = new Customer();
                    customer.Name = customerNameTxt.Text;
                    customer.Id = int.Parse(customerIdTxt.Text);

                    customer.CustomerPay = new Payment(
                            int.Parse(paymentIdTxt.Text),
                            cardNumberTxt.Text,
                            double.Parse(paymentAmountTxt.Text)
                        );

                    Rental rental = new Rental(
                            int.Parse(rentalidTxt.Text),
                            Utilz.makeDate(rentalDatePick.Text),
                            Utilz.makeDate(returnDatePick.Text)
                        );

                    if (trueIfCar.Checked)
                    {
                        vehicle = new Car();
                        vehicle.NumberPlate = selectedVeh;
                        rental.Vehicle_ = vehicle;
                    }
                    else
                    {
                        vehicle = new Truck();
                        vehicle.NumberPlate = selectedVeh;
                        rental.Vehicle_ = vehicle;
                    }
                    rental.Customer_ = customer;
                    rental.Vehicle_ = vehicle;

                    /*payment.Update();*/
                    rental.Update();

                    Load_Rent();

                    MessageBox.Show("Data Updated", "Rentals");

                    Reset_All_Fields();

                if (trueIfCar.Checked) { loadIntoComboBox("EXEC Get_BrandModelCar;"); }
                else { loadIntoComboBox("EXEC Get_BrandModelTruck;"); }

                customerIdTxt.Enabled = true;
                customerNameTxt.Enabled = true;
                }
        }

        private void customerNameTxt_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(customerNameTxt.Text))
            {
                customerNameValText.Visible = false;
            }
            else if (customerNameTxt.Text.Length > 25)
            {
                customerNameValText.Visible = true;
                customerNameValText.ForeColor = Color.Red;
                customerNameValText.Text = "Maximum characters are 25";
            }
            else
            {
                customerNameValText.Visible = false;
            }
        }

        private void customerIdTxt_Leave(object sender, EventArgs e)
        {
            string[] array = Customer.CheckCustomer(customerIdTxt.Text);

            if (array[0] == "1")
            {
                warnCustomerID.Visible = false;
            }
            else
            {
                warnCustomerID.Visible = true;
                warnCustomerID.ForeColor = Color.Red;
                warnCustomerID.Text = "Customer Not Found";
            }
            customerNameTxt.Enabled = false;
            customerNameTxt.Text = array[1];
        }

        private void maximizeIconBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void reloadIconBtn_Click(object sender, EventArgs e)
        {
            AddBtn.Enabled = true;
            updateBtn.Enabled = false;
            Reset_All_Fields();

            customerIdTxt.Enabled = true;
            customerNameTxt.Enabled = true;

            selectVehicleComboBox.SelectedIndex = -1;
            selectVehicleComboBox.Text = string.Empty;

            if (isOnRentTab)
            {
                Load_Rent();
            }
            else
            {
                if (trueIfCar.Checked)
                {
                    loadIntoComboBox("EXEC Get_BrandModelCar;");
                    displayRentalGridView.DataSource = Car.AvailCars();
                }
                else
                {
                    loadIntoComboBox("EXEC Get_BrandModelTruck;");
                    displayRentalGridView.DataSource = Truck.AvailTrucks();
                }
            }
        }
          
        private void warnCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void trueIfCar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cardNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && c != 8 && c != 46 && c != ' ')
            {
                e.Handled = true;
                cardWarnText.Visible = true;
                cardWarnText.ForeColor = Color.Red;
                cardWarnText.Text = "Only Digits are allowed";
            }
            else
            {
                cardWarnText.Visible = false;
            }
        }

        private void paymentAmountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && c != 8 && c != 46 && c != 13 && c != 9 && !char.IsControl(c))
            {
                e.Handled = true;
                paywarn.Visible = true;
                paywarn.ForeColor = Color.Red;
                paywarn.Text = "Only Digits are allowed";
            }
            else
            {
                paywarn.Visible = false;
            }
        }

        private void rentalidTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerIdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymentIdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymentAmountTxt_TextChanged(object sender, EventArgs e)
        {
            double payment;

            if (paymentAmountTxt.Text.Length > 10)
            {
                paywarn.Visible = true;
                paywarn.ForeColor = Color.Red;
                paywarn.Text = "Maximum digits allowed are 10";
            }
            else if (string.IsNullOrEmpty(paymentAmountTxt.Text))
            {
                paywarn.Visible = false;
            }
            else if (double.TryParse(paymentAmountTxt.Text, out payment))
            {
                if (payment > 0)
                {
                    paywarn.Visible = false;
                }
                else
                {
                    paywarn.Visible = true;
                    paywarn.ForeColor = Color.Red;
                    paywarn.Text = "Must be greater than 0";
                }
            }
            else { paywarn.Visible = false; }
    }

        private void rentalDatePick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void returnDatePick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void displayRentalGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerIdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && c != 8 && c != 46 && c != 13 && c != 9 && !char.IsControl(c))
            {
                e.Handled = true;
                warnCustomerID.Visible = true;
                warnCustomerID.ForeColor = Color.Red;
                warnCustomerID.Text = "Only Digits are allowed";
            }
            else
            {
                warnCustomerID.Visible = false;
            }
        }

        private void selectVehicleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = selectVehicleComboBox.SelectedItem?.ToString();
                if (selectedItem != null)
                {
                    selectedVeh = selectedItem.Split(',')[0].Trim();
                }
                else
                {
                    selectedVeh = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting the vehicle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Rentals_Load(object sender, EventArgs e)
        {
            Load_Rent();
            Load_IDs();
            warnCustomerID.Text = "";
            updateBtn.Enabled = false;

            /*loading data into combo box*/
            loadIntoComboBox("EXEC Get_BrandModelTruck;");
        }
    }
}

