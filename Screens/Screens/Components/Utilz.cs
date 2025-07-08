using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screens.Components
{
    static class Utilz
    {
        public static bool questionBox(string message = "Do You Want To Exit", string title = "Car Rental System")
        {
            DialogResult res = MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            return (res == DialogResult.Yes);
        }


        public static string makeDate(string datetimeText)
        {
            DateTime dt = DateTime.Parse(datetimeText);
            return dt.ToString("yyyy-MM-dd");

        }
    }
}