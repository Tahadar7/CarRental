namespace Screens
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LodingScreenProgressImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.CarRentalSystemLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SignUpBtn = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.usernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.addressTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.cellTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.cellValText = new System.Windows.Forms.Label();
            this.passwordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.confirmPassTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.signBtn = new Guna.UI2.WinForms.Guna2Button();
            this.minimizeIconBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.exitIconBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.emailValText = new System.Windows.Forms.Label();
            this.warningPass = new System.Windows.Forms.Label();
            this.maximizeIconBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.usernameValText = new System.Windows.Forms.Label();
            this.nameValText = new System.Windows.Forms.Label();
            this.addressValTxt = new System.Windows.Forms.Label();
            this.warningPass2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LodingScreenProgressImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeIconBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitIconBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeIconBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.LodingScreenProgressImage);
            this.panel1.Controls.Add(this.CarRentalSystemLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 819);
            this.panel1.TabIndex = 1;
            // 
            // LodingScreenProgressImage
            // 
            this.LodingScreenProgressImage.BackColor = System.Drawing.Color.Transparent;
            this.LodingScreenProgressImage.FillColor = System.Drawing.Color.Transparent;
            this.LodingScreenProgressImage.Image = ((System.Drawing.Image)(resources.GetObject("LodingScreenProgressImage.Image")));
            this.LodingScreenProgressImage.Location = new System.Drawing.Point(36, 214);
            this.LodingScreenProgressImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LodingScreenProgressImage.Name = "LodingScreenProgressImage";
            this.LodingScreenProgressImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.LodingScreenProgressImage.ShadowDecoration.Parent = this.LodingScreenProgressImage;
            this.LodingScreenProgressImage.Size = new System.Drawing.Size(290, 250);
            this.LodingScreenProgressImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LodingScreenProgressImage.TabIndex = 4;
            this.LodingScreenProgressImage.TabStop = false;
            this.LodingScreenProgressImage.UseTransparentBackground = true;
            // 
            // CarRentalSystemLabel
            // 
            this.CarRentalSystemLabel.AutoSize = true;
            this.CarRentalSystemLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.CarRentalSystemLabel.Location = new System.Drawing.Point(60, 478);
            this.CarRentalSystemLabel.Name = "CarRentalSystemLabel";
            this.CarRentalSystemLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarRentalSystemLabel.Size = new System.Drawing.Size(273, 37);
            this.CarRentalSystemLabel.TabIndex = 3;
            this.CarRentalSystemLabel.Text = "Car Rental System";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.LoginLabel.Location = new System.Drawing.Point(438, 65);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginLabel.Size = new System.Drawing.Size(136, 37);
            this.LoginLabel.TabIndex = 11;
            this.LoginLabel.Text = "SIGN UP\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(585, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Have Account";
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.AutoSize = true;
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.Red;
            this.SignUpBtn.Location = new System.Drawing.Point(716, 70);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(58, 24);
            this.SignUpBtn.TabIndex = 18;
            this.SignUpBtn.Text = "Login";
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // usernameTxt
            // 
            this.usernameTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.usernameTxt.BorderRadius = 10;
            this.usernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxt.DefaultText = "";
            this.usernameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxt.DisabledState.Parent = this.usernameTxt;
            this.usernameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxt.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.usernameTxt.FocusedState.Parent = this.usernameTxt;
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTxt.ForeColor = System.Drawing.Color.Black;
            this.usernameTxt.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.usernameTxt.HoverState.Parent = this.usernameTxt;
            this.usernameTxt.Location = new System.Drawing.Point(444, 214);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PasswordChar = '\0';
            this.usernameTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.usernameTxt.PlaceholderText = "Username";
            this.usernameTxt.SelectedText = "";
            this.usernameTxt.ShadowDecoration.Parent = this.usernameTxt;
            this.usernameTxt.Size = new System.Drawing.Size(502, 60);
            this.usernameTxt.TabIndex = 0;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            this.usernameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameTxt_KeyPress);
            this.usernameTxt.Leave += new System.EventHandler(this.usernameTxt_Leave);
            // 
            // nameTxt
            // 
            this.nameTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.nameTxt.BorderRadius = 10;
            this.nameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTxt.DefaultText = "";
            this.nameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.DisabledState.Parent = this.nameTxt;
            this.nameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.nameTxt.FocusedState.Parent = this.nameTxt;
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameTxt.ForeColor = System.Drawing.Color.Black;
            this.nameTxt.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.nameTxt.HoverState.Parent = this.nameTxt;
            this.nameTxt.Location = new System.Drawing.Point(988, 214);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.nameTxt.PlaceholderText = "Name";
            this.nameTxt.SelectedText = "";
            this.nameTxt.ShadowDecoration.Parent = this.nameTxt;
            this.nameTxt.Size = new System.Drawing.Size(502, 60);
            this.nameTxt.TabIndex = 1;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            this.nameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTxt_KeyPress);
            // 
            // addressTxt
            // 
            this.addressTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.addressTxt.BorderRadius = 10;
            this.addressTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTxt.DefaultText = "";
            this.addressTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTxt.DisabledState.Parent = this.addressTxt;
            this.addressTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTxt.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.addressTxt.FocusedState.Parent = this.addressTxt;
            this.addressTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addressTxt.ForeColor = System.Drawing.Color.Black;
            this.addressTxt.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.addressTxt.HoverState.Parent = this.addressTxt;
            this.addressTxt.Location = new System.Drawing.Point(446, 341);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.PasswordChar = '\0';
            this.addressTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.addressTxt.PlaceholderText = "Address";
            this.addressTxt.SelectedText = "";
            this.addressTxt.ShadowDecoration.Parent = this.addressTxt;
            this.addressTxt.Size = new System.Drawing.Size(1045, 60);
            this.addressTxt.TabIndex = 2;
            this.addressTxt.TextChanged += new System.EventHandler(this.addressTxt_TextChanged);
            this.addressTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressTxt_KeyPress);
            // 
            // cellTxt
            // 
            this.cellTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.cellTxt.BorderRadius = 10;
            this.cellTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cellTxt.DefaultText = "";
            this.cellTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cellTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cellTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cellTxt.DisabledState.Parent = this.cellTxt;
            this.cellTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cellTxt.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.cellTxt.FocusedState.Parent = this.cellTxt;
            this.cellTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cellTxt.ForeColor = System.Drawing.Color.Black;
            this.cellTxt.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.cellTxt.HoverState.Parent = this.cellTxt;
            this.cellTxt.Location = new System.Drawing.Point(444, 456);
            this.cellTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cellTxt.Name = "cellTxt";
            this.cellTxt.PasswordChar = '\0';
            this.cellTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.cellTxt.PlaceholderText = "Cell";
            this.cellTxt.SelectedText = "";
            this.cellTxt.ShadowDecoration.Parent = this.cellTxt;
            this.cellTxt.Size = new System.Drawing.Size(502, 60);
            this.cellTxt.TabIndex = 3;
            this.cellTxt.TextChanged += new System.EventHandler(this.cellTxt_TextChanged);
            this.cellTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cellTxt_KeyPress);
            // 
            // emailTxt
            // 
            this.emailTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.emailTxt.BorderRadius = 10;
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxt.DefaultText = "";
            this.emailTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.DisabledState.Parent = this.emailTxt;
            this.emailTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.emailTxt.FocusedState.Parent = this.emailTxt;
            this.emailTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTxt.ForeColor = System.Drawing.Color.Black;
            this.emailTxt.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.emailTxt.HoverState.Parent = this.emailTxt;
            this.emailTxt.Location = new System.Drawing.Point(988, 456);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.emailTxt.PlaceholderText = "Email";
            this.emailTxt.SelectedText = "";
            this.emailTxt.ShadowDecoration.Parent = this.emailTxt;
            this.emailTxt.Size = new System.Drawing.Size(502, 60);
            this.emailTxt.TabIndex = 4;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            this.emailTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailTxt_KeyPress);
            // 
            // cellValText
            // 
            this.cellValText.AutoSize = true;
            this.cellValText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellValText.ForeColor = System.Drawing.Color.Red;
            this.cellValText.Location = new System.Drawing.Point(684, 521);
            this.cellValText.Name = "cellValText";
            this.cellValText.Size = new System.Drawing.Size(104, 24);
            this.cellValText.TabIndex = 42;
            this.cellValText.Text = "Invalid Cell";
            // 
            // passwordTxt
            // 
            this.passwordTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.passwordTxt.BorderRadius = 10;
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.DefaultText = "";
            this.passwordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxt.DisabledState.Parent = this.passwordTxt;
            this.passwordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxt.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.passwordTxt.FocusedState.Parent = this.passwordTxt;
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTxt.ForeColor = System.Drawing.Color.Black;
            this.passwordTxt.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.passwordTxt.HoverState.Parent = this.passwordTxt;
            this.passwordTxt.Location = new System.Drawing.Point(444, 579);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '●';
            this.passwordTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.passwordTxt.PlaceholderText = "Password";
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.ShadowDecoration.Parent = this.passwordTxt;
            this.passwordTxt.Size = new System.Drawing.Size(502, 60);
            this.passwordTxt.TabIndex = 5;
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            this.passwordTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTxt_KeyPress);
            // 
            // confirmPassTxt
            // 
            this.confirmPassTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmPassTxt.BorderRadius = 10;
            this.confirmPassTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPassTxt.DefaultText = "";
            this.confirmPassTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmPassTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmPassTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPassTxt.DisabledState.Parent = this.confirmPassTxt;
            this.confirmPassTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPassTxt.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.confirmPassTxt.FocusedState.Parent = this.confirmPassTxt;
            this.confirmPassTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmPassTxt.ForeColor = System.Drawing.Color.Black;
            this.confirmPassTxt.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.confirmPassTxt.HoverState.Parent = this.confirmPassTxt;
            this.confirmPassTxt.Location = new System.Drawing.Point(988, 579);
            this.confirmPassTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.confirmPassTxt.Name = "confirmPassTxt";
            this.confirmPassTxt.PasswordChar = '●';
            this.confirmPassTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.confirmPassTxt.PlaceholderText = "Confirm Password";
            this.confirmPassTxt.SelectedText = "";
            this.confirmPassTxt.ShadowDecoration.Parent = this.confirmPassTxt;
            this.confirmPassTxt.Size = new System.Drawing.Size(502, 60);
            this.confirmPassTxt.TabIndex = 6;
            this.confirmPassTxt.UseSystemPasswordChar = true;
            this.confirmPassTxt.TextChanged += new System.EventHandler(this.confirmPassTxt_TextChanged);
            this.confirmPassTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmPassTxt_KeyPress);
            // 
            // signBtn
            // 
            this.signBtn.BackColor = System.Drawing.Color.Transparent;
            this.signBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.signBtn.BorderRadius = 17;
            this.signBtn.BorderThickness = 1;
            this.signBtn.CheckedState.Parent = this.signBtn;
            this.signBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signBtn.CustomImages.Parent = this.signBtn;
            this.signBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.signBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signBtn.ForeColor = System.Drawing.Color.Black;
            this.signBtn.HoverState.Parent = this.signBtn;
            this.signBtn.Location = new System.Drawing.Point(864, 698);
            this.signBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signBtn.Name = "signBtn";
            this.signBtn.ShadowDecoration.Parent = this.signBtn;
            this.signBtn.Size = new System.Drawing.Size(202, 56);
            this.signBtn.TabIndex = 16;
            this.signBtn.Text = "Sign Up";
            this.signBtn.Click += new System.EventHandler(this.signBtn_Click);
            // 
            // minimizeIconBtn
            // 
            this.minimizeIconBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeIconBtn.Image")));
            this.minimizeIconBtn.Location = new System.Drawing.Point(1398, 7);
            this.minimizeIconBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minimizeIconBtn.Name = "minimizeIconBtn";
            this.minimizeIconBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.minimizeIconBtn.ShadowDecoration.Parent = this.minimizeIconBtn;
            this.minimizeIconBtn.Size = new System.Drawing.Size(39, 42);
            this.minimizeIconBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimizeIconBtn.TabIndex = 80;
            this.minimizeIconBtn.TabStop = false;
            this.minimizeIconBtn.UseTransparentBackground = true;
            this.minimizeIconBtn.Click += new System.EventHandler(this.minimizeIconBtn_Click);
            // 
            // exitIconBtn
            // 
            this.exitIconBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitIconBtn.Image")));
            this.exitIconBtn.Location = new System.Drawing.Point(1488, 7);
            this.exitIconBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitIconBtn.Name = "exitIconBtn";
            this.exitIconBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitIconBtn.ShadowDecoration.Parent = this.exitIconBtn;
            this.exitIconBtn.Size = new System.Drawing.Size(43, 49);
            this.exitIconBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.exitIconBtn.TabIndex = 81;
            this.exitIconBtn.TabStop = false;
            this.exitIconBtn.UseTransparentBackground = true;
            this.exitIconBtn.Click += new System.EventHandler(this.exitIconBtn_Click);
            // 
            // emailValText
            // 
            this.emailValText.AutoSize = true;
            this.emailValText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailValText.ForeColor = System.Drawing.Color.Red;
            this.emailValText.Location = new System.Drawing.Point(1219, 521);
            this.emailValText.Name = "emailValText";
            this.emailValText.Size = new System.Drawing.Size(119, 24);
            this.emailValText.TabIndex = 82;
            this.emailValText.Text = "Invalid Email";
            // 
            // warningPass
            // 
            this.warningPass.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningPass.ForeColor = System.Drawing.Color.Red;
            this.warningPass.Location = new System.Drawing.Point(1157, 644);
            this.warningPass.Name = "warningPass";
            this.warningPass.Size = new System.Drawing.Size(333, 30);
            this.warningPass.TabIndex = 84;
            this.warningPass.Text = "Password must be same";
            this.warningPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maximizeIconBtn
            // 
            this.maximizeIconBtn.BackColor = System.Drawing.Color.Transparent;
            this.maximizeIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("maximizeIconBtn.Image")));
            this.maximizeIconBtn.Location = new System.Drawing.Point(1443, 7);
            this.maximizeIconBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maximizeIconBtn.Name = "maximizeIconBtn";
            this.maximizeIconBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.maximizeIconBtn.ShadowDecoration.Parent = this.maximizeIconBtn;
            this.maximizeIconBtn.Size = new System.Drawing.Size(39, 42);
            this.maximizeIconBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizeIconBtn.TabIndex = 85;
            this.maximizeIconBtn.TabStop = false;
            this.maximizeIconBtn.UseTransparentBackground = true;
            this.maximizeIconBtn.Click += new System.EventHandler(this.maximizeIconBtn_Click);
            // 
            // usernameValText
            // 
            this.usernameValText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameValText.ForeColor = System.Drawing.Color.Red;
            this.usernameValText.Location = new System.Drawing.Point(565, 279);
            this.usernameValText.Name = "usernameValText";
            this.usernameValText.Size = new System.Drawing.Size(354, 30);
            this.usernameValText.TabIndex = 86;
            this.usernameValText.Text = "Username length should be 4 to 10";
            this.usernameValText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usernameValText.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameValText
            // 
            this.nameValText.AutoSize = true;
            this.nameValText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameValText.ForeColor = System.Drawing.Color.Red;
            this.nameValText.Location = new System.Drawing.Point(1214, 285);
            this.nameValText.Name = "nameValText";
            this.nameValText.Size = new System.Drawing.Size(124, 24);
            this.nameValText.TabIndex = 87;
            this.nameValText.Text = "Invalid Name";
            // 
            // addressValTxt
            // 
            this.addressValTxt.AutoSize = true;
            this.addressValTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressValTxt.ForeColor = System.Drawing.Color.Red;
            this.addressValTxt.Location = new System.Drawing.Point(1214, 406);
            this.addressValTxt.Name = "addressValTxt";
            this.addressValTxt.Size = new System.Drawing.Size(142, 24);
            this.addressValTxt.TabIndex = 88;
            this.addressValTxt.Text = "Invalid Address";
            // 
            // warningPass2
            // 
            this.warningPass2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningPass2.ForeColor = System.Drawing.Color.Red;
            this.warningPass2.Location = new System.Drawing.Point(598, 644);
            this.warningPass2.Name = "warningPass2";
            this.warningPass2.Size = new System.Drawing.Size(354, 30);
            this.warningPass2.TabIndex = 83;
            this.warningPass2.Text = "Password must be grater than 4 letters";
            this.warningPass2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1541, 819);
            this.Controls.Add(this.addressValTxt);
            this.Controls.Add(this.nameValText);
            this.Controls.Add(this.usernameValText);
            this.Controls.Add(this.maximizeIconBtn);
            this.Controls.Add(this.warningPass);
            this.Controls.Add(this.warningPass2);
            this.Controls.Add(this.emailValText);
            this.Controls.Add(this.exitIconBtn);
            this.Controls.Add(this.minimizeIconBtn);
            this.Controls.Add(this.signBtn);
            this.Controls.Add(this.confirmPassTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.cellValText);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.cellTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LodingScreenProgressImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeIconBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitIconBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeIconBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CarRentalSystemLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SignUpBtn;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox LodingScreenProgressImage;
        private Guna.UI2.WinForms.Guna2TextBox usernameTxt;
        private Guna.UI2.WinForms.Guna2TextBox nameTxt;
        private Guna.UI2.WinForms.Guna2TextBox addressTxt;
        private Guna.UI2.WinForms.Guna2TextBox cellTxt;
        private Guna.UI2.WinForms.Guna2TextBox emailTxt;
        private System.Windows.Forms.Label cellValText;
        private Guna.UI2.WinForms.Guna2TextBox passwordTxt;
        private Guna.UI2.WinForms.Guna2TextBox confirmPassTxt;
        private Guna.UI2.WinForms.Guna2Button signBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox minimizeIconBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox exitIconBtn;
        private System.Windows.Forms.Label emailValText;
        private System.Windows.Forms.Label warningPass;
        private Guna.UI2.WinForms.Guna2CirclePictureBox maximizeIconBtn;
        private System.Windows.Forms.Label usernameValText;
        private System.Windows.Forms.Label nameValText;
        private System.Windows.Forms.Label addressValTxt;
        private System.Windows.Forms.Label warningPass2;
    }
}

