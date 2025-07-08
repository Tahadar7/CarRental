namespace Screens
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CarRentalSystemLabel = new System.Windows.Forms.Label();
            this.LodingScreenProgressImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.homeBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.usernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.cellTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.confPassTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.changeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.nameValText = new System.Windows.Forms.Label();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.minimizeIconBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.exitIconBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.cellValText = new System.Windows.Forms.Label();
            this.emailValText = new System.Windows.Forms.Label();
            this.addressValText = new System.Windows.Forms.Label();
            this.passwordValText = new System.Windows.Forms.Label();
            this.addressTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.maximizeIconBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.passwordVal2Txt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LodingScreenProgressImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeIconBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitIconBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeIconBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.CarRentalSystemLabel);
            this.panel1.Controls.Add(this.LodingScreenProgressImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 760);
            this.panel1.TabIndex = 2;
            // 
            // CarRentalSystemLabel
            // 
            this.CarRentalSystemLabel.AutoSize = true;
            this.CarRentalSystemLabel.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarRentalSystemLabel.Location = new System.Drawing.Point(109, 468);
            this.CarRentalSystemLabel.Name = "CarRentalSystemLabel";
            this.CarRentalSystemLabel.Size = new System.Drawing.Size(140, 47);
            this.CarRentalSystemLabel.TabIndex = 3;
            this.CarRentalSystemLabel.Text = "Admin";
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
            this.LodingScreenProgressImage.TabIndex = 1;
            this.LodingScreenProgressImage.TabStop = false;
            this.LodingScreenProgressImage.UseTransparentBackground = true;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.Location = new System.Drawing.Point(423, 6);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.homeBtn.ShadowDecoration.Parent = this.homeBtn;
            this.homeBtn.Size = new System.Drawing.Size(37, 42);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.homeBtn.TabIndex = 44;
            this.homeBtn.TabStop = false;
            this.homeBtn.UseTransparentBackground = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(416, 96);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(134, 37);
            this.LoginLabel.TabIndex = 12;
            this.LoginLabel.Text = "PROFILE";
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
            this.usernameTxt.Location = new System.Drawing.Point(423, 181);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PasswordChar = '\0';
            this.usernameTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.usernameTxt.PlaceholderText = "Username";
            this.usernameTxt.SelectedText = "";
            this.usernameTxt.ShadowDecoration.Parent = this.usernameTxt;
            this.usernameTxt.Size = new System.Drawing.Size(502, 60);
            this.usernameTxt.TabIndex = 51;
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
            this.nameTxt.Location = new System.Drawing.Point(966, 181);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.nameTxt.PlaceholderText = "Name";
            this.nameTxt.SelectedText = "";
            this.nameTxt.ShadowDecoration.Parent = this.nameTxt;
            this.nameTxt.Size = new System.Drawing.Size(502, 60);
            this.nameTxt.TabIndex = 0;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            this.nameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTxt_KeyPress);
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
            this.emailTxt.Location = new System.Drawing.Point(423, 294);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.emailTxt.PlaceholderText = "Email";
            this.emailTxt.SelectedText = "";
            this.emailTxt.ShadowDecoration.Parent = this.emailTxt;
            this.emailTxt.Size = new System.Drawing.Size(502, 60);
            this.emailTxt.TabIndex = 1;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            this.emailTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailTxt_KeyPress);
            // 
            // cellTxt
            // 
            this.cellTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.cellTxt.Location = new System.Drawing.Point(966, 294);
            this.cellTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cellTxt.MaximumSize = new System.Drawing.Size(502, 60);
            this.cellTxt.MinimumSize = new System.Drawing.Size(502, 60);
            this.cellTxt.Name = "cellTxt";
            this.cellTxt.PasswordChar = '\0';
            this.cellTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.cellTxt.PlaceholderText = "Cell";
            this.cellTxt.SelectedText = "";
            this.cellTxt.ShadowDecoration.Parent = this.cellTxt;
            this.cellTxt.Size = new System.Drawing.Size(502, 60);
            this.cellTxt.TabIndex = 2;
            this.cellTxt.TextChanged += new System.EventHandler(this.cellTxt_TextChanged);
            this.cellTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cellTxt_KeyPress);
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
            this.passwordTxt.Location = new System.Drawing.Point(423, 529);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '●';
            this.passwordTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.passwordTxt.PlaceholderText = "New Password";
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.ShadowDecoration.Parent = this.passwordTxt;
            this.passwordTxt.Size = new System.Drawing.Size(502, 60);
            this.passwordTxt.TabIndex = 4;
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            this.passwordTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTxt_KeyPress);
            // 
            // confPassTxt
            // 
            this.confPassTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.confPassTxt.BorderRadius = 10;
            this.confPassTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confPassTxt.DefaultText = "";
            this.confPassTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confPassTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confPassTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confPassTxt.DisabledState.Parent = this.confPassTxt;
            this.confPassTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confPassTxt.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.confPassTxt.FocusedState.Parent = this.confPassTxt;
            this.confPassTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confPassTxt.ForeColor = System.Drawing.Color.Black;
            this.confPassTxt.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.confPassTxt.HoverState.Parent = this.confPassTxt;
            this.confPassTxt.Location = new System.Drawing.Point(966, 529);
            this.confPassTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.confPassTxt.Name = "confPassTxt";
            this.confPassTxt.PasswordChar = '●';
            this.confPassTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.confPassTxt.PlaceholderText = "Confirm Password";
            this.confPassTxt.SelectedText = "";
            this.confPassTxt.ShadowDecoration.Parent = this.confPassTxt;
            this.confPassTxt.Size = new System.Drawing.Size(502, 60);
            this.confPassTxt.TabIndex = 5;
            this.confPassTxt.UseSystemPasswordChar = true;
            this.confPassTxt.TextChanged += new System.EventHandler(this.confPassTxt_TextChanged);
            this.confPassTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confPassTxt_KeyPress);
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.Transparent;
            this.changeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.changeBtn.BorderRadius = 17;
            this.changeBtn.BorderThickness = 1;
            this.changeBtn.CheckedState.Parent = this.changeBtn;
            this.changeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeBtn.CustomImages.Parent = this.changeBtn;
            this.changeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.changeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBtn.ForeColor = System.Drawing.Color.Black;
            this.changeBtn.HoverState.Parent = this.changeBtn;
            this.changeBtn.Location = new System.Drawing.Point(853, 650);
            this.changeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.ShadowDecoration.Parent = this.changeBtn;
            this.changeBtn.Size = new System.Drawing.Size(202, 56);
            this.changeBtn.TabIndex = 21;
            this.changeBtn.Text = "Change";
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // nameValText
            // 
            this.nameValText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameValText.ForeColor = System.Drawing.Color.Red;
            this.nameValText.Location = new System.Drawing.Point(1058, 246);
            this.nameValText.Name = "nameValText";
            this.nameValText.Size = new System.Drawing.Size(337, 25);
            this.nameValText.TabIndex = 55;
            this.nameValText.Text = "Name can\'t be same as Old";
            this.nameValText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.Location = new System.Drawing.Point(1366, 6);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.logoutBtn.ShadowDecoration.Parent = this.logoutBtn;
            this.logoutBtn.Size = new System.Drawing.Size(35, 42);
            this.logoutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoutBtn.TabIndex = 56;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.UseTransparentBackground = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // minimizeIconBtn
            // 
            this.minimizeIconBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeIconBtn.Image")));
            this.minimizeIconBtn.Location = new System.Drawing.Point(1407, 6);
            this.minimizeIconBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minimizeIconBtn.Name = "minimizeIconBtn";
            this.minimizeIconBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.minimizeIconBtn.ShadowDecoration.Parent = this.minimizeIconBtn;
            this.minimizeIconBtn.Size = new System.Drawing.Size(39, 42);
            this.minimizeIconBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimizeIconBtn.TabIndex = 57;
            this.minimizeIconBtn.TabStop = false;
            this.minimizeIconBtn.UseTransparentBackground = true;
            this.minimizeIconBtn.Click += new System.EventHandler(this.minimizeIconBtn_Click);
            // 
            // exitIconBtn
            // 
            this.exitIconBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitIconBtn.Image")));
            this.exitIconBtn.Location = new System.Drawing.Point(1491, 6);
            this.exitIconBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitIconBtn.Name = "exitIconBtn";
            this.exitIconBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitIconBtn.ShadowDecoration.Parent = this.exitIconBtn;
            this.exitIconBtn.Size = new System.Drawing.Size(39, 42);
            this.exitIconBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.exitIconBtn.TabIndex = 58;
            this.exitIconBtn.TabStop = false;
            this.exitIconBtn.UseTransparentBackground = true;
            this.exitIconBtn.Click += new System.EventHandler(this.exitIconBtn_Click);
            // 
            // cellValText
            // 
            this.cellValText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellValText.ForeColor = System.Drawing.Color.Red;
            this.cellValText.Location = new System.Drawing.Point(1108, 359);
            this.cellValText.Name = "cellValText";
            this.cellValText.Size = new System.Drawing.Size(302, 25);
            this.cellValText.TabIndex = 52;
            this.cellValText.Text = "Cell can\'t be same as Old";
            this.cellValText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailValText
            // 
            this.emailValText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailValText.ForeColor = System.Drawing.Color.Red;
            this.emailValText.Location = new System.Drawing.Point(537, 359);
            this.emailValText.Name = "emailValText";
            this.emailValText.Size = new System.Drawing.Size(320, 25);
            this.emailValText.TabIndex = 53;
            this.emailValText.Text = "Email can\'t be same as Old";
            this.emailValText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emailValText.Click += new System.EventHandler(this.emailValText_Click);
            // 
            // addressValText
            // 
            this.addressValText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressValText.ForeColor = System.Drawing.Color.Red;
            this.addressValText.Location = new System.Drawing.Point(1058, 468);
            this.addressValText.Name = "addressValText";
            this.addressValText.Size = new System.Drawing.Size(343, 25);
            this.addressValText.TabIndex = 54;
            this.addressValText.Text = "Address can\'t be same as Old";
            this.addressValText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordValText
            // 
            this.passwordValText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordValText.ForeColor = System.Drawing.Color.Red;
            this.passwordValText.Location = new System.Drawing.Point(1077, 594);
            this.passwordValText.Name = "passwordValText";
            this.passwordValText.Size = new System.Drawing.Size(343, 25);
            this.passwordValText.TabIndex = 63;
            this.passwordValText.Text = "Password must be same";
            this.passwordValText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.addressTxt.Location = new System.Drawing.Point(423, 409);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.PasswordChar = '\0';
            this.addressTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.addressTxt.PlaceholderText = "Address";
            this.addressTxt.SelectedText = "";
            this.addressTxt.ShadowDecoration.Parent = this.addressTxt;
            this.addressTxt.Size = new System.Drawing.Size(1045, 60);
            this.addressTxt.TabIndex = 3;
            this.addressTxt.TextChanged += new System.EventHandler(this.addressTxt_TextChanged);
            this.addressTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressTxt_KeyPress);
            // 
            // maximizeIconBtn
            // 
            this.maximizeIconBtn.BackColor = System.Drawing.Color.Transparent;
            this.maximizeIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("maximizeIconBtn.Image")));
            this.maximizeIconBtn.Location = new System.Drawing.Point(1446, 6);
            this.maximizeIconBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maximizeIconBtn.Name = "maximizeIconBtn";
            this.maximizeIconBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.maximizeIconBtn.ShadowDecoration.Parent = this.maximizeIconBtn;
            this.maximizeIconBtn.Size = new System.Drawing.Size(39, 42);
            this.maximizeIconBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizeIconBtn.TabIndex = 71;
            this.maximizeIconBtn.TabStop = false;
            this.maximizeIconBtn.UseTransparentBackground = true;
            this.maximizeIconBtn.Click += new System.EventHandler(this.maximizeIconBtn_Click);
            // 
            // passwordVal2Txt
            // 
            this.passwordVal2Txt.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordVal2Txt.ForeColor = System.Drawing.Color.Red;
            this.passwordVal2Txt.Location = new System.Drawing.Point(537, 594);
            this.passwordVal2Txt.Name = "passwordVal2Txt";
            this.passwordVal2Txt.Size = new System.Drawing.Size(388, 25);
            this.passwordVal2Txt.TabIndex = 72;
            this.passwordVal2Txt.Text = "Password must be grater than 4 letters";
            this.passwordVal2Txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1556, 760);
            this.Controls.Add(this.passwordVal2Txt);
            this.Controls.Add(this.maximizeIconBtn);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.passwordValText);
            this.Controls.Add(this.addressValText);
            this.Controls.Add(this.emailValText);
            this.Controls.Add(this.cellValText);
            this.Controls.Add(this.exitIconBtn);
            this.Controls.Add(this.minimizeIconBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.nameValText);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.confPassTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.cellTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LodingScreenProgressImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeIconBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitIconBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeIconBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CarRentalSystemLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox LodingScreenProgressImage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox homeBtn;
        private System.Windows.Forms.Label LoginLabel;
        private Guna.UI2.WinForms.Guna2TextBox usernameTxt;
        private Guna.UI2.WinForms.Guna2TextBox nameTxt;
        private Guna.UI2.WinForms.Guna2TextBox emailTxt;
        private Guna.UI2.WinForms.Guna2TextBox cellTxt;
        private Guna.UI2.WinForms.Guna2TextBox passwordTxt;
        private Guna.UI2.WinForms.Guna2TextBox confPassTxt;
        private Guna.UI2.WinForms.Guna2Button changeBtn;
        private System.Windows.Forms.Label nameValText;
        private Guna.UI2.WinForms.Guna2CirclePictureBox logoutBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox minimizeIconBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox exitIconBtn;
        private System.Windows.Forms.Label cellValText;
        private System.Windows.Forms.Label emailValText;
        private System.Windows.Forms.Label addressValText;
        private System.Windows.Forms.Label passwordValText;
        private Guna.UI2.WinForms.Guna2TextBox addressTxt;
        private Guna.UI2.WinForms.Guna2CirclePictureBox maximizeIconBtn;
        private System.Windows.Forms.Label passwordVal2Txt;
    }
}