namespace Screens
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CarRentalSystemLabel = new System.Windows.Forms.Label();
            this.LodingScreenProgressImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SignUpBtn = new System.Windows.Forms.Label();
            this.usernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.minimizeIconBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.exitIconBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.maximizeIconBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.usernameValText = new System.Windows.Forms.Label();
            this.warningPass = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.CarRentalSystemLabel);
            this.panel1.Controls.Add(this.LodingScreenProgressImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 749);
            this.panel1.TabIndex = 0;
            // 
            // CarRentalSystemLabel
            // 
            this.CarRentalSystemLabel.AutoSize = true;
            this.CarRentalSystemLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarRentalSystemLabel.Location = new System.Drawing.Point(60, 478);
            this.CarRentalSystemLabel.Name = "CarRentalSystemLabel";
            this.CarRentalSystemLabel.Size = new System.Drawing.Size(273, 37);
            this.CarRentalSystemLabel.TabIndex = 3;
            this.CarRentalSystemLabel.Text = "Car Rental System";
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
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(532, 128);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(109, 37);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "LOGIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(652, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "New? Sign Up here";
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.AutoSize = true;
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.Red;
            this.SignUpBtn.Location = new System.Drawing.Point(839, 134);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(78, 24);
            this.SignUpBtn.TabIndex = 17;
            this.SignUpBtn.Text = "Sign Up";
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
            this.usernameTxt.Location = new System.Drawing.Point(539, 214);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PasswordChar = '\0';
            this.usernameTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.usernameTxt.PlaceholderText = "Username";
            this.usernameTxt.SelectedText = "";
            this.usernameTxt.ShadowDecoration.Parent = this.usernameTxt;
            this.usernameTxt.Size = new System.Drawing.Size(525, 60);
            this.usernameTxt.TabIndex = 0;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            this.usernameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameTxt_KeyPress);
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
            this.passwordTxt.Location = new System.Drawing.Point(539, 331);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '●';
            this.passwordTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.passwordTxt.PlaceholderText = "Password";
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.ShadowDecoration.Parent = this.passwordTxt;
            this.passwordTxt.Size = new System.Drawing.Size(525, 60);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged_1);
            this.passwordTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTxt_KeyPress);
            // 
            // minimizeIconBtn
            // 
            this.minimizeIconBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeIconBtn.Image")));
            this.minimizeIconBtn.Location = new System.Drawing.Point(1083, 6);
            this.minimizeIconBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minimizeIconBtn.Name = "minimizeIconBtn";
            this.minimizeIconBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.minimizeIconBtn.ShadowDecoration.Parent = this.minimizeIconBtn;
            this.minimizeIconBtn.Size = new System.Drawing.Size(39, 42);
            this.minimizeIconBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimizeIconBtn.TabIndex = 35;
            this.minimizeIconBtn.TabStop = false;
            this.minimizeIconBtn.UseTransparentBackground = true;
            this.minimizeIconBtn.Click += new System.EventHandler(this.minimizeIconBtn_Click);
            // 
            // exitIconBtn
            // 
            this.exitIconBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitIconBtn.Image")));
            this.exitIconBtn.Location = new System.Drawing.Point(1170, 6);
            this.exitIconBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitIconBtn.Name = "exitIconBtn";
            this.exitIconBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitIconBtn.ShadowDecoration.Parent = this.exitIconBtn;
            this.exitIconBtn.Size = new System.Drawing.Size(39, 42);
            this.exitIconBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.exitIconBtn.TabIndex = 36;
            this.exitIconBtn.TabStop = false;
            this.exitIconBtn.UseTransparentBackground = true;
            this.exitIconBtn.Click += new System.EventHandler(this.exitIconBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.LoginBtn.BorderRadius = 17;
            this.LoginBtn.BorderThickness = 1;
            this.LoginBtn.CheckedState.Parent = this.LoginBtn;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.CustomImages.Parent = this.LoginBtn;
            this.LoginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.Black;
            this.LoginBtn.HoverState.Parent = this.LoginBtn;
            this.LoginBtn.Location = new System.Drawing.Point(874, 478);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
            this.LoginBtn.Size = new System.Drawing.Size(202, 56);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // maximizeIconBtn
            // 
            this.maximizeIconBtn.BackColor = System.Drawing.Color.Transparent;
            this.maximizeIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("maximizeIconBtn.Image")));
            this.maximizeIconBtn.Location = new System.Drawing.Point(1128, 6);
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
            // usernameValText
            // 
            this.usernameValText.AutoSize = true;
            this.usernameValText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameValText.ForeColor = System.Drawing.Color.Red;
            this.usernameValText.Location = new System.Drawing.Point(815, 279);
            this.usernameValText.Name = "usernameValText";
            this.usernameValText.Size = new System.Drawing.Size(158, 24);
            this.usernameValText.TabIndex = 72;
            this.usernameValText.Text = "Invalid Username";
            // 
            // warningPass
            // 
            this.warningPass.AutoSize = true;
            this.warningPass.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningPass.ForeColor = System.Drawing.Color.Red;
            this.warningPass.Location = new System.Drawing.Point(815, 396);
            this.warningPass.Name = "warningPass";
            this.warningPass.Size = new System.Drawing.Size(153, 24);
            this.warningPass.TabIndex = 73;
            this.warningPass.Text = "Invalid Password";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 749);
            this.Controls.Add(this.warningPass);
            this.Controls.Add(this.usernameValText);
            this.Controls.Add(this.maximizeIconBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.exitIconBtn);
            this.Controls.Add(this.minimizeIconBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
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
        private Guna.UI2.WinForms.Guna2CirclePictureBox LodingScreenProgressImage;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SignUpBtn;
        private Guna.UI2.WinForms.Guna2TextBox usernameTxt;
        private Guna.UI2.WinForms.Guna2TextBox passwordTxt;
        private Guna.UI2.WinForms.Guna2CirclePictureBox minimizeIconBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox exitIconBtn;
        private Guna.UI2.WinForms.Guna2Button LoginBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox maximizeIconBtn;
        private System.Windows.Forms.Label usernameValText;
        private System.Windows.Forms.Label warningPass;
    }
}