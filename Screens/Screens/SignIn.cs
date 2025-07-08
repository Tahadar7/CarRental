using Screens.Components;
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
    public partial class SignIn : Form
    {

        public SignIn()
        {
            InitializeComponent();
        }
        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTxt.Text))
            {
                usernameValText.Visible = false;
            }
            else if (usernameTxt.Text.Length < 4 || usernameTxt.Text.Length > 10)
            {
                usernameValText.ForeColor = Color.Red;
                usernameValText.Visible = true;
                if (usernameTxt.Text.Length > 10)
                {
                    usernameValText.Text = "Maximum characters are 10";
                }
                else
                {
                    usernameValText.Text = "Length should be 4 to 10";
                }
            }
            else
            {
                usernameValText.Visible = false;
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTxt.Text) || string.IsNullOrEmpty(passwordTxt.Text))
            {
                MessageBox.Show("Fill all the fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ( usernameValText.Visible ||  warningPass.Visible  )
            {
                MessageBox.Show("Invalid input! Fill all the fields correctly", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else   {
                if (Admin.login(usernameTxt.Text, passwordTxt.Text))
                {
                    await LogninEmail(Admin.Email);

                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else { 
                    MessageBox.Show("Username or Password is invalid", "Error"); 
                }
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
            private void maximizeIconBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            warningPass.Text = "";
            usernameValText.Text = "";
        }

        private void passwordTxt_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTxt.Text))
            {
                warningPass.Visible = false;
            }
            else if (passwordTxt.Text.Length < 4 || passwordTxt.Text.Length > 15)
            {
                warningPass.ForeColor = Color.Red;
                warningPass.Visible = true;
                if (passwordTxt.Text.Length < 4)
                {
                    warningPass.Text = "Password must be greater than 4 letters";
                }
                else
                {
                    warningPass.Text = "Maximum characters are 15";
                }
            }
            else
            {
                warningPass.Visible = false;
            }
        }

        private void usernameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetterOrDigit(c) && c != '_' && !char.IsControl(c))
            {
                e.Handled = true;
                usernameValText.ForeColor = Color.Red;
                usernameValText.Visible = true;
                usernameValText.Text = "Only letters,digits,underscore allowed";
            }
            else
            {
                usernameValText.Visible = false;
            }
        }

        private void passwordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetterOrDigit(c) && !char.IsControl(c))
            {
                e.Handled = true;
                warningPass.ForeColor = Color.Red;
                warningPass.Visible = true;
                warningPass.Text = "Only letters,digits are allowed";
            }
            else
            {
                warningPass.Visible = false;
            }
        }
        private async Task LogninEmail(string useremail)
        {
            try
            {
                var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");

                if (string.IsNullOrEmpty(apiKey))
                {
                    throw new Exception("SendGrid API key not found in environment variables.");
                }

                var client = new SendGridClient(apiKey);

                var from = new EmailAddress("tahaamanshoor@gmail.com", "Taha Manshoor");
                var subject = "Welcome to Our Service! CAR RENTAL SYSTEM";

                var to = new EmailAddress(useremail, Admin.Name);
                var plainTextContent = $"Dear {Admin.Name},\n\n" +
                                       $"Thank you for Logn in on this system.. If you have any questions, feel free to contact us.\n\n" +
                                       "Best Regards,\n" +
                                       "CAR RENTAL SYSTEM";

                var htmlContent = "<p>Dear " + Admin.Name + ",</p>" +
                                  "<p>Thank you for Logn in on this system. If you have any questions, feel free to contact us.</p>" +
                                  "<p>Best Regards,<br>" +
                                  "CAR RENTAL SYSTEM</p>";

                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = await client.SendEmailAsync(msg);

                if (response.StatusCode == System.Net.HttpStatusCode.OK ||
               response.StatusCode == System.Net.HttpStatusCode.Accepted)
                {
                    MessageBox.Show("Email sent successfully.", "Logn In", MessageBoxButtons.OK);
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
