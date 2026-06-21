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
    public partial class CustomerReservationPage : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\TEST\ProjectEDP\ProjectEDP\EasyLaundry.mdf;Integrated Security=True;Connect Timeout=30";

        public CustomerReservationPage()
        {
            InitializeComponent();

            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.ReadOnly = true;
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservations.MultiSelect = false;

            this.Load -= CustomerReservationPage_Load;
            this.Load += CustomerReservationPage_Load;

            btnPay.Click -= btnPay_Click;
            btnPay.Click += btnPay_Click;
        }

        private void CustomerReservationPage_Load(object sender, EventArgs e)
        {
            LoadMyReservations();
        }

        private void LoadMyReservations()
        {
            if (CurrentUser.CustomerID == 0)
            {
                MessageBox.Show("Please login first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT
                                        r.reservationID AS [Reservation ID],
                                        r.serviceType AS [Service Type],
                                        r.reservationDate AS [Date],
                                        r.timeSlot AS [Time Slot],
                                        r.paymentMethod AS [Payment Method],
                                        r.deliveryAddress AS [Delivery Address],
                                        r.specialtyDetails AS [Specialty Details],
                                        r.status AS [Reservation Status],
                                        ISNULL(o.orderStatus, 'No Order Yet') AS [Order Status],
                                        ISNULL(p.paymentStatus, 'Unpaid') AS [Payment Status],
                                        r.createdAt AS [Submitted At]
                                     FROM Reservation r
                                     LEFT JOIN [Order] o
                                     ON r.reservationID = o.reservationID
                                     LEFT JOIN Payment p
                                     ON o.orderID = p.orderID
                                     WHERE r.customerID = @CustomerID
                                     ORDER BY r.createdAt DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", CurrentUser.CustomerID);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dgvReservations.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dgvReservations.CurrentRow == null)
            {
                MessageBox.Show("Please select a reservation first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int reservationID = Convert.ToInt32(dgvReservations.CurrentRow.Cells["Reservation ID"].Value);

            string reservationStatus = dgvReservations.CurrentRow.Cells["Reservation Status"].Value.ToString();
            string orderStatus = dgvReservations.CurrentRow.Cells["Order Status"].Value.ToString();
            string paymentStatus = dgvReservations.CurrentRow.Cells["Payment Status"].Value.ToString();

            if (reservationStatus != "Approved")
            {
                MessageBox.Show("You can only pay after admin approves your reservation.", "Payment Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (orderStatus == "No Order Yet")
            {
                MessageBox.Show("This reservation is approved, but no order was created yet. Please ask admin to approve again.", "Order Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (paymentStatus == "Paid")
            {
                MessageBox.Show("This reservation has already been paid.", "Already Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PaymentPage form = new PaymentPage(reservationID);
            form.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMyReservations();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Homepage form = new Homepage();
            this.Close();
        }
    }
}