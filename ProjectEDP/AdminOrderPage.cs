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
    public partial class AdminOrderPage : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EasyLaundry.mdf;Integrated Security=True;Connect Timeout=30";

        public AdminOrderPage()
        {
            InitializeComponent();

            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ReadOnly = true;
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AdminOrderPage_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT
                                        o.orderID AS [Order ID],
                                        o.reservationID AS [Reservation ID],
                                        c.customerID AS [Customer ID],
                                        c.custName AS [Customer Name],
                                        c.custEmail AS [Customer Email],
                                        c.contactNo AS [Contact No],
                                        r.serviceType AS [Service Type],
                                        r.reservationDate AS [Reservation Date],
                                        r.timeSlot AS [Time Slot],
                                        r.paymentMethod AS [Payment Method],
                                        r.deliveryAddress AS [Delivery Address],
                                        r.specialtyDetails AS [Specialty Details],
                                        r.status AS [Reservation Status],
                                        r.totalAmount AS [Amount (RM)],
                                        o.orderStatus AS [Order Status],
                                        ISNULL(p.paymentStatus, 'Unpaid') AS [Payment Status],
                                        p.paymentDate AS [Payment Date],
                                        o.orderDate AS [Order Created At]
                                     FROM [Order] o
                                     INNER JOIN Reservation r
                                     ON o.reservationID = r.reservationID
                                     INNER JOIN Customer c
                                     ON o.customerID = c.customerID
                                     LEFT JOIN Payment p
                                     ON o.orderID = p.orderID
                                     ORDER BY o.orderDate DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvOrders.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("Please select an order first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int orderID = Convert.ToInt32(dgvOrders.CurrentRow.Cells["Order ID"].Value);
            string paymentStatus = dgvOrders.CurrentRow.Cells["Payment Status"].Value.ToString();

            if (paymentStatus != "Paid")
            {
                MessageBox.Show("This order cannot be completed because payment is not paid yet.", "Not Paid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Mark this order as completed?",
                "Confirm Completed",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"UPDATE [Order]
                                     SET orderStatus = @OrderStatus
                                     WHERE orderID = @OrderID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@OrderStatus", "Completed");
                        cmd.Parameters.AddWithValue("@OrderID", orderID);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Order marked as completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHomepage form = new AdminHomepage();
            form.Show();
            this.Hide();
        }

        private void reserveLbl_Click(object sender, EventArgs e)
        {

        }
    }
}