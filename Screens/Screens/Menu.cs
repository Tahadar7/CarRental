using Screens.Components;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void MinimizeLabelTopRight_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            adminNameWelcome.Text = "Hi, " + Admin.Name;
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

        private void manageCustomerBtn_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.Show();
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
        private void manageRentsBtn_Click(object sender, EventArgs e)
        {
            Rentals rental = new Rentals();
            rental.Show();
            this.Hide();
        }

        private void adminProfileBtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void approveAdminBtn_Click(object sender, EventArgs e)
        {
            ApproveAdmins approveAdmins = new ApproveAdmins();
            approveAdmins.Show();
            this.Hide();
        }

        private void maximizeIconBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void manageVehiclesBtn_Click(object sender, EventArgs e)
        {
            Vehicles vehicle = new Vehicles();
            vehicle.Show();
            this.Hide();
        }
    }
}