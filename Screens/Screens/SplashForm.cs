using System;
using Screens.Components.SuperInterfaces;
using Screens.Components;
using System.Data.SqlClient;
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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startposition = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startposition += 5;
            MyProgress.Value = startposition;  

            if(MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();

                SignIn signIn = new SignIn();
                signIn.Show();
                this.Hide();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
