using Screens.Components;
using Screens.Components.SuperInterfaces;
using SendGrid.Helpers.Mail;
using SendGrid;
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
    public partial class Profile : Form, IResetFormsState
    {
        public Profile()
        {
            InitializeComponent();
        }

        public void Reset_All_Fields()
        {
            emailValText.Text = "";
            cellValText.Text = "";
            emailTxt.Text = "";
            passwordValText.Text = "";
            passwordVal2Txt.Text = "";
            usernameTxt.Text = "";
            passwordTxt.Text = "";
            confPassTxt.Text = "";
            addressTxt.Text = "";
            addressValText.Text = "";
            nameTxt.Text = "";
            cellTxt.Text = "";
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (Utilz.questionBox("Are you sure?", "Logout"))
            {
                SignIn signIn = new SignIn();
                signIn.Show();
                this.Hide();
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            emailTxt.Text = Admin.Email;
            cellTxt.Text = Admin.Cell;
            nameTxt.Text = Admin.Name;
            addressTxt.Text = Admin.Address;
            usernameTxt.Text = Admin.Username;
            usernameTxt.Enabled = false;

            emailValText.Text = "";
            nameValText.Text = "";
            cellValText.Text = "";
            addressValText.Text = "";
            passwordValText.Text = "";
            passwordVal2Txt.Text = "";

        }

        private async void changeBtn_Click(object sender, EventArgs e)
        {
            if (
              string.IsNullOrEmpty(usernameTxt.Text) || string.IsNullOrEmpty(nameTxt.Text)
              || string.IsNullOrEmpty(addressTxt.Text) || string.IsNullOrEmpty(cellTxt.Text)
              || string.IsNullOrEmpty(emailTxt.Text) || string.IsNullOrEmpty(passwordTxt.Text)
                || string.IsNullOrEmpty(confPassTxt.Text)
                )
            {
                MessageBox.Show("Fill all the fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (
             nameValText.Visible || addressValText.Visible || cellValText.Visible
              || emailValText.Visible || passwordValText.Visible || passwordVal2Txt.Visible
              )
            {
                MessageBox.Show("Invalid input! Fill all the fields correctly", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    if (
                        emailTxt.Text != Admin.Email ||
                        cellTxt.Text != Admin.Cell ||
                        nameTxt.Text != Admin.Name ||
                        addressTxt.Text != Admin.Address
                    )
                    {
                        if(Admin.Email != emailTxt.Text)
                        {
                        await ChangeEmail(emailTxt.Text);
                        }
                        Admin.Name = nameTxt.Text;
                        Admin.Address = addressTxt.Text;
                        Admin.Email = emailTxt.Text;
                        Admin.Cell = cellTxt.Text;
                        Admin.Update(usernameTxt.Text, passwordTxt.Text);

                        MessageBox.Show("Data Updated!", "Profile");

                        Reset_All_Fields();

                        SignIn signIn = new SignIn();
                        signIn.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Name/Address/Cell/Email \'Something must be different\'!", "Profile");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred" + ex.Message, "Error");
                }
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

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(emailTxt.Text))
                {
                    emailValText.Visible = false;

                }
                else if (emailTxt.Text.Length > 25)
                {
                    emailValText.ForeColor = Color.Red;
                    emailValText.Visible = true;
                    emailValText.Text = "Maximum characters are 25";
                }
                else
                {
                    emailValText.Visible = false;
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

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addressTxt.Text))
            {
                addressValText.Visible = false;
            }

            else if (addressTxt.Text.Length > 50)
            {
                addressValText.Visible = true;
                addressValText.ForeColor = Color.Red;
                addressValText.Text = "Maximum characters are 50";
            }
            else
            {
                addressValText.Visible = false;
            }
            
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTxt.Text))
            {
                passwordVal2Txt.Visible = false;
            }
            else if (passwordTxt.Text.Length < 4 || passwordTxt.Text.Length > 15)
            {
                passwordVal2Txt.ForeColor = Color.Red;
                passwordVal2Txt.Visible = true;
                if (passwordTxt.Text.Length < 4)
                {
                    passwordVal2Txt.Text = "Password must be greater than 4 letters";
                }
                else
                {
                    passwordVal2Txt.Text = "Maximum characters are 15";
                }
            }
            else
            {
                passwordVal2Txt.Visible = false;
            }
        }

        private void confPassTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(confPassTxt.Text))
            {
                passwordValText.Visible = false;
            }
            else if (passwordTxt.Text != confPassTxt.Text)
            {
                passwordValText.ForeColor = Color.Red;
                passwordValText.Visible = true;
                passwordValText.Text = "Password must be same";
            }
            else
            {
                passwordValText.Visible = false;
            }
        }

        private void maximizeIconBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void emailValText_Click(object sender, EventArgs e)
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
                nameValText.Text = "Only Letters,space are allowed";
            }
            else
            {
                nameValText.Visible = false;
            }
        }

        private void emailTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetterOrDigit(c) && c != '@' && !char.IsControl(c) && c !=  '.')
            {
                e.Handled = true;
                emailValText.Visible = true;
                emailValText.ForeColor = Color.Red;
                emailValText.Text = "Only Letters,Digits,@ Allowed";
            }
            else
            {
                emailValText.Visible = false;
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

        private void addressTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsLetterOrDigit(c) && c != 8 && c != 32 && c != 44 && c != 13 && c != 9)
            {
                e.Handled = true;
                addressValText.Visible = true;
                addressValText.ForeColor = Color.Red;
                addressValText.Text = "Only letters,digits,spaces are allowed";
            }
            else
            {
                addressValText.Visible = false;
            }
        }

        private void passwordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetterOrDigit(c) && !char.IsControl(c))
            {
                e.Handled = true;
                passwordVal2Txt.ForeColor = Color.Red;
                passwordVal2Txt.Visible = true;
                passwordVal2Txt.Text = "Only letters,digits are allowed";
            }
            else
            {
                passwordVal2Txt.Visible = false;
            }
        }

        private void confPassTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetterOrDigit(c) && !char.IsControl(c))
            {
                e.Handled = true;
                passwordValText.ForeColor = Color.Red;
                passwordValText.Visible = true;
                passwordValText.Text = "Only letters,digits are allowed";
            }
            else
            {
                passwordValText.Visible = false;
            }
        }
        private async Task ChangeEmail(string useremail)
        {
            try
            {
                var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");

                if (string.IsNullOrEmpty(apiKey))
                {
                    throw new Exception("SendGrid API key not found in environment variables.");
                }

                var client = new SendGridClient(apiKey);

                var from = new EmailAddress("dtaha6529@gmail.com", "Taha Manshoor");
                var subject = "Welcome to Our Service! CAR RENTAL SYSTEM";

                var to = new EmailAddress(useremail, nameTxt.Text);
                var plainTextContent = $"Dear {nameTxt.Text},\n\n" +
                                       $"Your Email Has Been Succesfully Changed. If you have any questions, feel free to contact us.\n\n" +
                                       "Best Regards,\n" +
                                       "CAR RENTAL SYSTEM";

                var htmlContent = "<p>Dear " + nameTxt.Text + ",</p>" +
                                  "<p>Your Email Has Been Succesfully Changed. If you have any questions, feel free to contact us.</p>" +
                                  "<p>Best Regards,<br>" +
                                  "CAR RENTAL SYSTEM</p>";

                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = await client.SendEmailAsync(msg);

                if (response.StatusCode == System.Net.HttpStatusCode.OK ||
               response.StatusCode == System.Net.HttpStatusCode.Accepted)
                {
                    MessageBox.Show("Email changed successfully.", "Email Changed", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"Failed to send email. Status code: {response.StatusCode}");
                    MessageBox.Show(await response.Body.ReadAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
