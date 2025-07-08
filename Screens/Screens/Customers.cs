using Screens.Components;
using Screens.Components.SuperInterfaces;
using System;
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
    public partial class Customers : Form, IResetFormsState
    {
        public Customers()
        {
            InitializeComponent();
        }

        public void Reset_All_Fields()
        {
            nameTxt.Text = "";
            ageWarnText.Text = "";
            cellValText.Text = "";
            nameValText.Text = "";
            ageTxt.Text = "";
            addressTxt.Text = "";
            addressValTxt.Text = "";
            cellTxt.Text = "";
            VIPCheckBox.Checked = false;

            idTxt.Text = Customer.NewCustId();

            AddBtn.Enabled = true;
            updateBtn.Enabled = false;
        }

        private void Load_Cus()
        {
            Customer customer = new Customer();
            displayCustomerGridView.DataSource = customer.Display();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (
             string.IsNullOrEmpty(idTxt.Text) || string.IsNullOrEmpty(nameTxt.Text)
             || string.IsNullOrEmpty(addressTxt.Text) || string.IsNullOrEmpty(cellTxt.Text)
             || string.IsNullOrEmpty(ageTxt.Text) 
               )
            {
                MessageBox.Show("Fill all the fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if 
                ( nameValText.Visible || addressValTxt.Visible || cellValText.Visible || ageWarnText.Visible )
            {
                MessageBox.Show("Invalid input! Fill all the fields correctly", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    Customer customer = new Customer(
                        idTxt.Text,
                        nameTxt.Text,
                        int.Parse(ageTxt.Text),
                        addressTxt.Text,
                        cellTxt.Text,
                        VIPCheckBox.Checked
                    );

                    customer.Insert();
                   
                    MessageBox.Show("Customer Added", "Customer");
                    Load_Cus();
                    Reset_All_Fields();
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred" + ex.Message, "Error");
                }
            }
        }
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
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

        private void Customers_Load(object sender, EventArgs e)
        {
             Load_Cus();
            Reset_All_Fields();
            updateBtn.Enabled = false;
            idTxt.Enabled = false;
        }

        private void adminProfileBtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void displayCustomerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AddBtn.Enabled = false;
                updateBtn.Enabled = true;

                idTxt.Text = displayCustomerGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                nameTxt.Text = displayCustomerGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                ageTxt.Text = displayCustomerGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                addressTxt.Text = displayCustomerGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                cellTxt.Text = displayCustomerGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                if (displayCustomerGridView.Rows[e.RowIndex].Cells[5].Value.ToString().Trim() == "1")
               
               { VIPCheckBox.Checked = true; }
                
                else
                { VIPCheckBox.Checked = false; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred" + ex.Message, "Error");
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (
          string.IsNullOrEmpty(idTxt.Text) || string.IsNullOrEmpty(nameTxt.Text)
          || string.IsNullOrEmpty(addressTxt.Text) || string.IsNullOrEmpty(cellTxt.Text)
          || string.IsNullOrEmpty(ageTxt.Text)
            )
            {
                MessageBox.Show("Fill all the fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if
                (nameValText.Visible || addressValTxt.Visible || cellValText.Visible || ageWarnText.Visible)
            {
                MessageBox.Show("Invalid input! Fill all the fields correctly", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    Customer customer = new Customer(
                        id: idTxt.Text,
                        name: nameTxt.Text,
                        age: int.Parse(ageTxt.Text),
                        address: addressTxt.Text,
                        cell: cellTxt.Text,
                        vip: VIPCheckBox.Checked
                    );

                    customer.Update();
                    MessageBox.Show("Customer Updated", "Customer");
                    Load_Cus();
                    Reset_All_Fields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred" + ex.Message, "Error");
                }
            }
            
        }

        private void cellTxt_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cellTxt.Text))
            {
                cellValText.Visible = false;
            }

            else if (cellTxt.Text.Length != 11)
            {
                cellValText.Visible = true;
                cellValText.ForeColor = Color.Red;
                cellValText.Text = "Cell Number must be 11 digits";
            }
            else
            {
                cellValText.Visible = false;
            }
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxt.Text))
            {
                nameValText.Visible = false;
            }
            else if (nameTxt.Text.Length > 25)
            {
                nameValText.Visible = true;
                nameValText.ForeColor = Color.Red;
                nameValText.Text = "Maximum characters are 25";
            }
            else
            {
                nameValText.Visible = false;
            }
        }

        private void ageTxt_TextChanged(object sender, EventArgs e)
        {
            int age;

             if (ageTxt.Text.Length > 2)
            {
                ageWarnText.Visible = true;
                ageWarnText.ForeColor = Color.Red;
                ageWarnText.Text = "Maximum 2 digits allowed";
            }

            else if (string.IsNullOrEmpty(ageTxt.Text))
            {
                ageWarnText.Visible = false;
            }
            else if (int.TryParse(ageTxt.Text, out age))
            {
                if (age >= 18)
                {
                    ageWarnText.Visible = false;
                }
                else
                {
                    ageWarnText.ForeColor = Color.Red;
                    ageWarnText.Visible = true;
                    ageWarnText.Text = "Age must be 18 or more";
                }
            }
            else
            {
                ageWarnText.Visible = false;
            }
        }

        private void reloadText_Click(object sender, EventArgs e)
        {
            Reset_All_Fields();

            AddBtn.Enabled = true;
            updateBtn.Enabled = false;
        }

        private void reloadIconBtn_Click(object sender, EventArgs e)
        {
            Reset_All_Fields();

            AddBtn.Enabled = true;
            updateBtn.Enabled = false;
        }

        private void maximizeIconBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void idTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayCustomerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetter(c) && c != 8 && c != 46 && c != 32 && c != 13 && c != 9)
            {
                e.Handled = true;
                nameValText.Visible = true;
                nameValText.ForeColor = Color.Red;
                nameValText.Text = "Only Letters,spaces are allowed";
            }
            else
            {
                nameValText.Visible = false;
            }
        }

        private void ageTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && !char.IsControl(c))
            {
                e.Handled = true;
                ageWarnText.Visible = true;
                ageWarnText.ForeColor = Color.Red;
                ageWarnText.Text = "Only Digits are allowed";
            }
              else
            {
                    ageWarnText.Visible = false;
             }
        }

        private void cellTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && c != 8 && c != 46 && c != 13 && c != 9 && !char.IsControl(c))
            {
                e.Handled = true;
                cellValText.Visible = true;
                cellValText.ForeColor = Color.Red;
                cellValText.Text = "Only Digits are allowed";
            }
            else
            {
                cellValText.Visible = false;
            }
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addressTxt.Text))
            {
                addressValTxt.Visible = false;
            }
            else if (addressTxt.Text.Length > 50)
            {
                addressValTxt.Visible = true;
                addressValTxt.ForeColor = Color.Red;
                addressValTxt.Text = "Maximum characters are 50";
            }
            else
            {
                addressValTxt.Visible = false;
            }
        }

        private void addressTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsLetterOrDigit(c) && c != 8 && c != 32 && c != 44 && c != 13 && c != 9)
            {
                e.Handled = true;
                addressValTxt.Visible = true;
                addressValTxt.ForeColor = Color.Red;
                addressValTxt.Text = "Only letters, digits,spaces are allowed";
            }
            else
            {
                addressValTxt.Visible = false;
            }
        }
    }
}

