using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEDP
{
    public partial class PaymentPage : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\TEST\ProjectEDP\ProjectEDP\EasyLaundry.mdf;Integrated Security=True;Connect Timeout=30";

        private int reservationID;
        private int orderID;
        private int customerID;
        private string paymentMethod;
        private decimal amount;

        public PaymentPage()
        {
            InitializeComponent();
            SetupPaymentPageDesign();
        }

        public PaymentPage(int selectedReservationID)
        {
            InitializeComponent();
            SetupPaymentPageDesign();

            reservationID = selectedReservationID;
        }

        private void SetupPaymentPageDesign()
        {
            this.BackColor = Color.FromArgb(176, 176, 176);

            groupOrderSummary.BackColor = Color.WhiteSmoke;
            groupOrderSummary.Font = new Font("Arial", 10, FontStyle.Bold);

            groupPaymentDetails.BackColor = Color.WhiteSmoke;
            groupPaymentDetails.Font = new Font("Arial", 10, FontStyle.Bold);

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.BackColor = Color.White;
            btnBack.Font = new Font("Arial", 9, FontStyle.Bold);

            btnPayNow.FlatStyle = FlatStyle.Flat;
            btnPayNow.BackColor = Color.White;
            btnPayNow.Font = new Font("Arial", 9, FontStyle.Bold);

            lblReservationID.Font = new Font("Arial", 9, FontStyle.Bold);
            lblOrderID.Font = new Font("Arial", 9, FontStyle.Bold);
            lblServiceType.Font = new Font("Arial", 9, FontStyle.Bold);
            lblDate.Font = new Font("Arial", 9, FontStyle.Bold);
            lblTimeSlot.Font = new Font("Arial", 9, FontStyle.Bold);
            lblDeliveryAddress.Font = new Font("Arial", 9, FontStyle.Bold);
            lblSpecialtyDetails.Font = new Font("Arial", 9, FontStyle.Bold);
            lblPaymentMethod.Font = new Font("Arial", 9, FontStyle.Bold);
            lblOrderStatus.Font = new Font("Arial", 9, FontStyle.Bold);
            lblPaymentStatus.Font = new Font("Arial", 9, FontStyle.Bold);
            lblAmount.Font = new Font("Arial", 9, FontStyle.Bold);
        }

        private void PaymentPage_Load(object sender, EventArgs e)
        {
            LoadPaymentDetails();
        }

        private void LoadPaymentDetails()
        {
            if (reservationID == 0)
            {
                MessageBox.Show("No reservation selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT
                                        o.orderID,
                                        r.reservationID,
                                        r.customerID,
                                        r.serviceType,
                                        r.reservationDate,
                                        r.timeSlot,
                                        r.paymentMethod,
                                        r.deliveryAddress,
                                        r.specialtyDetails,
                                        r.totalAmount,
                                        r.status,
                                        o.orderStatus,
                                        ISNULL(p.paymentStatus, 'Unpaid') AS paymentStatus
                                     FROM Reservation r
                                     INNER JOIN [Order] o
                                     ON r.reservationID = o.reservationID
                                     LEFT JOIN Payment p
                                     ON o.orderID = p.orderID
                                     WHERE r.reservationID = @ReservationID
                                     AND r.customerID = @CustomerID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                        cmd.Parameters.AddWithValue("@CustomerID", CurrentUser.CustomerID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                orderID = Convert.ToInt32(reader["orderID"]);
                                customerID = Convert.ToInt32(reader["customerID"]);
                                amount = Convert.ToDecimal(reader["totalAmount"]);
                                paymentMethod = reader["paymentMethod"].ToString();

                                lblReservationID.Text = "Reservation ID: " + reader["reservationID"].ToString();
                                lblOrderID.Text = "Order ID: " + reader["orderID"].ToString();
                                lblServiceType.Text = "Service Type: " + reader["serviceType"].ToString();
                                lblDate.Text = "Date: " + Convert.ToDateTime(reader["reservationDate"]).ToShortDateString();
                                lblTimeSlot.Text = "Time Slot: " + reader["timeSlot"].ToString();

                                lblDeliveryAddress.Text = "Delivery Address: " + reader["deliveryAddress"].ToString();
                                lblSpecialtyDetails.Text = "Specialty Details: " + reader["specialtyDetails"].ToString();

                                lblPaymentMethod.Text = "Payment Method: " + paymentMethod;
                                lblOrderStatus.Text = "Order Status: " + reader["orderStatus"].ToString();
                                lblPaymentStatus.Text = "Payment Status: " + reader["paymentStatus"].ToString();

                                lblAmount.Text = "Amount: RM " + amount.ToString("0.00");

                                if (reader["paymentStatus"].ToString() == "Paid")
                                {
                                    btnPayNow.Enabled = false;
                                    btnPayNow.Text = "ALREADY PAID";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Payment is only available after admin approves your reservation.", "Not Approved", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                CustomerReservationPage form = new CustomerReservationPage();
                                form.Show();
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        string checkPaymentQuery = @"SELECT COUNT(*)
                                                     FROM Payment
                                                     WHERE orderID = @OrderID
                                                     AND paymentStatus = 'Paid'";

                        using (SqlCommand checkCmd = new SqlCommand(checkPaymentQuery, con, transaction))
                        {
                            checkCmd.Parameters.AddWithValue("@OrderID", orderID);

                            int count = (int)checkCmd.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("This order has already been paid.", "Already Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                transaction.Rollback();
                                return;
                            }
                        }

                        string insertPaymentQuery = @"INSERT INTO Payment
                              (orderID, reservationID, customerID, paymentMethod, paymentStatus, paymentDate, amount)
                              VALUES
                              (@OrderID, @ReservationID, @CustomerID, @PaymentMethod, @PaymentStatus, GETDATE(), @Amount)";

                        using (SqlCommand insertCmd = new SqlCommand(insertPaymentQuery, con, transaction))
                        {
                            insertCmd.Parameters.AddWithValue("@OrderID", orderID);
                            insertCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                            insertCmd.Parameters.AddWithValue("@CustomerID", customerID);
                            insertCmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                            insertCmd.Parameters.AddWithValue("@PaymentStatus", "Paid");
                            insertCmd.Parameters.AddWithValue("@Amount", amount);

                            insertCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CustomerReservationPage form = new CustomerReservationPage();
                        form.Show();
                        this.Hide();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerReservationPage form = new CustomerReservationPage();
            form.Show();
            this.Hide();
        }

        private void lblTimeSlot_Click(object sender, EventArgs e)
        {

        }

        private void groupOrderSummary_Enter(object sender, EventArgs e)
        {

        }
    }
}