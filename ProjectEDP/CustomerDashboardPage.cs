using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectEDP
{
    public partial class CustomerDashboard : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="
            + System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath, @"..\..\EasyLaundry.mdf"))
            + @";Integrated Security=True;Connect Timeout=30";

        public CustomerDashboard()
        {
            InitializeComponent();

            grpSpecialtyOptions.Visible = false;
            UpdateTotalAmount();
        }

        private List<string> GetSelectedServices()
        {
            List<string> services = new List<string>();

            if (pickupChkBox.Checked)
            {
                services.Add("Wash Only");
            }

            if (DeliveryChkBox.Checked)
            {
                services.Add("Wash and Dry");
            }

            if (SpecialChkBox.Checked)
            {
                services.Add("Specialty Laundry");
            }

            return services;
        }

        private List<string> GetSelectedSpecialtyOptions()
        {
            List<string> options = new List<string>();

            if (!SpecialChkBox.Checked)
            {
                return options;
            }

            if (chkSameDayDelivery.Checked)
            {
                options.Add("Same Day Delivery");
            }

            if (chkFolding.Checked)
            {
                options.Add("Folding");
            }

            if (chkSensitiveSkin.Checked)
            {
                options.Add("Sensitive Skin Laundry Care");
            }

            if (chkDryCleaning.Checked)
            {
                options.Add("Dry Cleaning");
            }

            return options;
        }

        private decimal GetPriceFromCatalog(SqlConnection con, string serviceName)
        {
            string query = @"SELECT price
                             FROM Pricing_Catalog
                             WHERE LTRIM(RTRIM(serviceName)) = @ServiceName";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@ServiceName", serviceName);

                object result = cmd.ExecuteScalar();

                if (result == null)
                {
                    throw new Exception("Price not found for service: " + serviceName);
                }

                return Convert.ToDecimal(result);
            }
        }

        private decimal CalculateTotalAmount()
        {
            decimal totalAmount = 0;

            List<string> services = GetSelectedServices();
            List<string> specialtyOptions = GetSelectedSpecialtyOptions();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                foreach (string service in services)
                {
                    totalAmount += GetPriceFromCatalog(con, service);
                }

                foreach (string option in specialtyOptions)
                {
                    totalAmount += GetPriceFromCatalog(con, option);
                }
            }

            return totalAmount;
        }

        private void UpdateTotalAmount()
        {
            
            try
            {
                decimal serviceAmount = CalculateTotalAmount();
                decimal totalAmount = 0.00m;

                if (GetSelectedServices().Count > 0)
                {
                    totalAmount = serviceAmount + 3.00m;
                }

                lblTotalAmount.Text = $"TOTAL AMOUNT: RM {totalAmount:0.00}";
            }
            catch (Exception ex)
            {
                lblTotalAmount.Text = "TOTAL AMOUNT: RM 0.00";
                MessageBox.Show("Pricing error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pickupChkBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void DeliveryChkBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void SpecialChkBox_CheckedChanged(object sender, EventArgs e)
        {
            grpSpecialtyOptions.Visible = SpecialChkBox.Checked;

            if (!SpecialChkBox.Checked)
            {
                chkSameDayDelivery.Checked = false;
                chkFolding.Checked = false;
                chkSensitiveSkin.Checked = false;
                chkDryCleaning.Checked = false;
                
            }

            UpdateTotalAmount();
        }

        private void chkSameDayDelivery_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void chkFolding_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void chkSensitiveSkin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void chkDryCleaning_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (CurrentUser.CustomerID == 0)
            {
                MessageBox.Show("Please login first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> services = GetSelectedServices();
            List<string> specialtyOptions = GetSelectedSpecialtyOptions();

            if (services.Count == 0)
            {
                MessageBox.Show("Please select at least one service type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SpecialChkBox.Checked && specialtyOptions.Count == 0)
            {
                MessageBox.Show("Please select at least one specialty option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string specialtyDetails = specialtyOptions.Count > 0
                ? string.Join(", ", specialtyOptions)
                : "-";

            try
            {
                decimal totalAmount = CalculateTotalAmount() + 3.00m ;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO Reservation
                                     (customerID, serviceType, reservationDate, timeSlot, paymentMethod, deliveryAddress, specialtyDetails, totalAmount)
                                     VALUES
                                     (@CustomerID, @ServiceType, @ReservationDate, @TimeSlot, @PaymentMethod, @DeliveryAddress, @SpecialtyDetails, @TotalAmount)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", CurrentUser.CustomerID);
                        cmd.Parameters.AddWithValue("@ServiceType", serviceType);
                        cmd.Parameters.AddWithValue("@ReservationDate", dateTimePickerOrder.Value.Date);
                        cmd.Parameters.AddWithValue("@TimeSlot", timeSlot);
                        cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        cmd.Parameters.AddWithValue("@DeliveryAddress", deliveryAddress);
                        cmd.Parameters.AddWithValue("@SpecialtyDetails", specialtyDetails);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

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

        private void reserveLbl_Click(object sender, EventArgs e)
        {

        }

        private void TimeLbl_Click(object sender, EventArgs e)
        {

        }


        private void grpSpecialtyOptions_Enter(object sender, EventArgs e)
        {

        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }
        private void dateTimePickerOrder_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerOrder.MinDate = DateTime.Today.AddDays(1);

            if (dateTimePickerOrder.Value.Date < DateTime.Today.AddDays(1))
            {
                MessageBox.Show("Please select a date from tomorrow onwards.",
                    "Invalid Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dateTimePickerOrder.Value = DateTime.Today.AddDays(1);
            }
        }

        private void pickupChkBox_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            dateTimePickerOrder.MinDate = DateTime.Today.AddDays(1);
            dateTimePickerOrder.Value = DateTime.Today.AddDays(1);

            lblTotalAmount.Text = "TOTAL AMOUNT: RM 0.00";
        }
    }
}