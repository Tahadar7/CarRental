using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stripe.Apps;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stripe;

namespace Screens.Components
{
    class Payment
    {
        /*Fields*/
        private int id;
        private string cardNumber;
        private double amount;

        public Payment() { }

        public Payment(int id, string cardNumber, double amount)
        {
            this.id = id;
            this.cardNumber = cardNumber;
            this.amount = amount;
        }

        /*Properties*/
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }



        public static string NewPaymentId()
        {
            try
            {
                string query = "EXEC GetNewPaymentID;";
                SqlDataReader reader = DBConnection.SqlReader(query);

                reader.Read();
                return reader["ID"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred" + ex.Message, "Error");
                return null;
            }
    }
        public string ProcessPayment()
        {
            try
            {
                string stripeSecret = Environment.GetEnvironmentVariable("STRIPE_SECRET_KEY");

                var options = new ChargeCreateOptions
                {
                    Amount = (long)(amount * 100), // Amount in cents
                    Currency = "eur",
                    Source = cardNumber, // This should be a token representing the card number
                    Description = $"Payment for Rental ID: {id}"
                };

                var service = new ChargeService();
                Charge charge = service.Create(options);

                return charge.Id; // Return the charge ID if needed
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment processing failed: " + ex.Message, "Error");
                return null;
            }
        }
    }
}