using Screens.Components;
using Screens.Components.SuperInterfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using SendGrid.Helpers.Mail;
using SendGrid;

namespace Screens
{
    public partial class SignUp : Form, IResetFormsState
    {
        public SignUp()
        {
            InitializeComponent();
        }

        public void Reset_All_Fields()
        {
            emailValText.Text = "";
            usernameValText.Text = "";
            nameValText.Text = "";
            cellValText.Text = "";
            addressValTxt.Text = "";
            warningPass.Text = "";
            warningPass2.Text = "";
            usernameTxt.Text = "";
            passwordTxt.Text = "";
            confirmPassTxt.Text = "";
            addressTxt.Text = "";
            nameTxt.Text = "";
            cellTxt.Text = "";
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
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

        private async void signBtn_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(usernameTxt.Text) || string.IsNullOrEmpty(nameTxt.Text)
                || string.IsNullOrEmpty(addressTxt.Text) || string.IsNullOrEmpty(cellTxt.Text)
                || string.IsNullOrEmpty(emailTxt.Text) || string.IsNullOrEmpty(passwordTxt.Text)
                  || string.IsNullOrEmpty(confirmPassTxt.Text)
                  )
            {
                MessageBox.Show("Fill all the fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (
                usernameValText.Visible || nameValText.Visible || addressValTxt.Visible || cellValText.Visible
                || emailValText.Visible || warningPass.Visible || warningPass2.Visible
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
                    Admin.Username = usernameTxt.Text;
                    Admin.Name = nameTxt.Text;
                    Admin.Address = addressTxt.Text;
                    Admin.Cell = cellTxt.Text;
                    Admin.Email = emailTxt.Text;

                    await SendEmail(emailTxt.Text);

                    Admin.SignUP(passwordTxt.Text);

                    SignIn signIn = new SignIn();
                    signIn.Show();
                    this.Hide();

                    

                    Reset_All_Fields();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred" + ex.Message, "Error");
                }
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTxt.Text))
            {
                warningPass2.Visible = false;
            }
            else if(passwordTxt.Text.Length < 4 || passwordTxt.Text.Length > 15)
            {
                warningPass2.ForeColor = Color.Red;
                warningPass2.Visible = true;
                if(passwordTxt.Text.Length < 4)
                {
                    warningPass2.Text = "Password must be greater than 4 letters";
                }
                else
                {
                    warningPass2.Text = "Maximum characters are 15";
                }
            }
            else
            {
                warningPass.Visible = false;
            }
        }

        private void confirmPassTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(confirmPassTxt.Text))
            {
                warningPass.Visible = false;
            }
            else if (passwordTxt.Text != confirmPassTxt.Text)
            {
                warningPass.ForeColor = Color.Red;
                warningPass.Visible = true;
                warningPass.Text = "Password must be same";
            }
            else
            {
                warningPass.Visible = false;
            }
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

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailTxt.Text))
            {
                emailValText.Visible = false;

            }
            else if(emailTxt.Text.Length > 25)
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

           else if (cellTxt.Text.Length !=11)
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

        private void usernameTxt_Leave(object sender, EventArgs e)
        {
            if (!Admin.Check_Avail_Username(usernameTxt.Text))
            {
                MessageBox.Show("Username is not available", "Error");

            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            Reset_All_Fields();
        }

        private void maximizeIconBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxt.Text))
            {
                nameValText.Visible = false;
            }
            else if(nameTxt.Text.Length > 25)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void usernameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if(!char.IsLetterOrDigit(c) && c != '_' && !char.IsControl(c))
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

        private void passwordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetterOrDigit(c) && !char.IsControl(c))
            {
                e.Handled = true;
                warningPass2.ForeColor = Color.Red;
                warningPass2.Visible = true;
                warningPass2.Text = "Only letters,digits are allowed";
            }
            else
            {
                warningPass2.Visible = false;
            }
        }

        private void confirmPassTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if(!char.IsLetterOrDigit(c) && !char.IsControl(c))
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

        private void emailTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if(!char.IsLetterOrDigit(c) && c != '@' && !char.IsControl(c) && c != '.')
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

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addressTxt.Text))
            {
                addressValTxt.Visible = false;
            }
            else if(addressTxt.Text.Length > 50) 
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
        private async Task SendEmail(string useremail)
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
                                       $"Thank you for signing up on this system. If you have any questions, feel free to contact us.\n\n" +
                                       "Best Regards,\n" +
                                       "CAR RENTAL SYSTEM";

                var htmlContent = "<p>Dear " + nameTxt.Text + ",</p>" +
                                  "<p>Thank you for signing up on this system. If you have any questions, feel free to contact us.</p>" +
                                  "<p>Best Regards,<br>" +
                                  "CAR RENTAL SYSTEM</p>";

                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = await client.SendEmailAsync(msg);

                if (response.StatusCode == System.Net.HttpStatusCode.OK ||
               response.StatusCode == System.Net.HttpStatusCode.Accepted)
                {
                    MessageBox.Show("Email sent successfully.", "Signing Up", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"Failed to send email. Status code: {response.StatusCode}");
                    MessageBox.Show(await response.Body.ReadAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the email sending process
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }

    }


