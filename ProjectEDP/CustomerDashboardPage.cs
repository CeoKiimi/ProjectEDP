using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectEDP
{
    public partial class CustomerDashboard : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\TEST\ProjectEDP\ProjectEDP\EasyLaundry.mdf;Integrated Security=True;Connect Timeout=30";
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void reserveLbl_Click(object sender, EventArgs e)
        {

        }

        private void TimeLbl_Click(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (CurrentUser.CustomerID == 0)
            {
                MessageBox.Show("Please login first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> services = new List<string>();

            if (pickupChkBox.Checked)
            {
                services.Add("Pickup");
            }

            if (DeliveryChkBox.Checked)
            {
                services.Add("Delivery");
            }

            if (SpecialChkBox.Checked)
            {
                services.Add("Specialty Laundry");
            }

            if (services.Count == 0)
            {
                MessageBox.Show("Please select at least one service type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string serviceType = string.Join(", ", services);

            string timeSlot = "";

            if (morningRB.Checked)
            {
                timeSlot = "8:00 - 11:00 AM";
            }
            else if (eveningRB.Checked)
            {
                timeSlot = "12:00 - 14:00 PM";
            }
            else if (nightRB.Checked)
            {
                timeSlot = "16:00 - 20:00 PM";
            }
            else
            {
                MessageBox.Show("Please select a time slot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string paymentMethod = "";

            if (CodRB.Checked)
            {
                paymentMethod = "Cash";
            }
            else if (OnlineRB.Checked)
            {
                paymentMethod = "FPX Online Banking";
            }
            else if (CardRB.Checked)
            {
                paymentMethod = "Card Credit/Debit";
            }
            else
            {
                MessageBox.Show("Please select a payment method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string deliveryAddress = AddressTxtBox.Text.Trim();
            string specialtyDetails = InstructionsTxt.Text.Trim();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO Reservation
                             (customerID, serviceType, reservationDate, timeSlot, paymentMethod, deliveryAddress, specialtyDetails)
                             VALUES
                             (@CustomerID, @ServiceType, @ReservationDate, @TimeSlot, @PaymentMethod, @DeliveryAddress, @SpecialtyDetails)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", CurrentUser.CustomerID);
                        cmd.Parameters.AddWithValue("@ServiceType", serviceType);
                        cmd.Parameters.AddWithValue("@ReservationDate", dateTimePickerOrder.Value.Date);
                        cmd.Parameters.AddWithValue("@TimeSlot", timeSlot);
                        cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        cmd.Parameters.AddWithValue("@DeliveryAddress", deliveryAddress);
                        cmd.Parameters.AddWithValue("@SpecialtyDetails", specialtyDetails);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Reservation submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CustomerReservationPage form = new CustomerReservationPage();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}