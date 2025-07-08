namespace Screens
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CarRentalSystemLabel = new System.Windows.Forms.Label();
            this.LodingScreenProgressImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelLoading = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MyProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LodingScreenProgressImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(371, 679);
            this.panel1.TabIndex = 1;
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
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.Location = new System.Drawing.Point(626, 198);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(162, 37);
            this.labelLoading.TabIndex = 4;
            this.labelLoading.Text = "Loading....";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MyProgress
            // 
            this.MyProgress.FillThickness = 10;
            this.MyProgress.Location = new System.Drawing.Point(657, 327);
            this.MyProgress.Name = "MyProgress";
            this.MyProgress.ProgressColor = System.Drawing.Color.Black;
            this.MyProgress.ProgressColor2 = System.Drawing.Color.Black;
            this.MyProgress.ProgressThickness = 28;
            this.MyProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MyProgress.ShadowDecoration.Parent = this.MyProgress;
            this.MyProgress.Size = new System.Drawing.Size(119, 105);
            this.MyProgress.TabIndex = 5;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(599, 284);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(284, 193);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 679);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.MyProgress);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LodingScreenProgressImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CarRentalSystemLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox LodingScreenProgressImage;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar MyProgress;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}