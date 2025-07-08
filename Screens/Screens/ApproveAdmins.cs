using Screens.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screens
{
    public partial class ApproveAdmins : Form
    {
        private SqlDataReader reader;
        private string username;

        public ApproveAdmins()
        {
            InitializeComponent();
        }

        private void Load_data()
        {
            try
            {
                string query = "EXEC  Get_UnAppAdmin;";
                reader = DBConnection.SqlReader(query);
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                displayUnApprovedAdmins.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred" + ex.Message, "Error");
            }
        }

        private void ApproveAdmins_Load(object sender, EventArgs e)
        {
            Load_data();
            approveBtn.Enabled = false;
        }

        private void displayUnApprovedAdmins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < displayUnApprovedAdmins.Rows.Count)
                {
                    // Check if the cell is not null to avoid null reference exception
                    var cellValue = displayUnApprovedAdmins.Rows[e.RowIndex].Cells[0].Value;
                    if (cellValue != null)
                    {
                        username = cellValue.ToString();
                        approveBtn.Enabled = true;
                    }
                    else
                    {
                        approveBtn.Enabled = false;
                    }
                }
                else
                {
                    approveBtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred" + ex.Message, "Error");
            }
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Length != 0)
                {
                    SqlCommand cmd = DBConnection.SqlCmd("EXEC Approve_Admin " + username + ";");
                    cmd.ExecuteNonQuery();
                    Load_data();
                }
                else
                {
                    approveBtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred" + ex.Message, "Error");
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void adminProfileBtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
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

        private void minimizeIconBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitIconBtn_Click(object sender, EventArgs e)
        {
            if (Utilz.questionBox())
            {
                Application.Exit();
            }
        }

        private void maximizeIconBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void displayUnApprovedAdmins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}