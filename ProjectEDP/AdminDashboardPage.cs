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
    public partial class AdminDashboardPage : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\TEST\ProjectEDP\ProjectEDP\EasyLaundry.mdf;Integrated Security=True;Connect Timeout=30";

        public AdminDashboardPage()
        {
            InitializeComponent();

            dgvAdminReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdminReservations.ReadOnly = true;
            dgvAdminReservations.AllowUserToAddRows = false;
            dgvAdminReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadAllReservations();
        }

        private void LoadAllReservations()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT
                                        r.reservationID AS [Reservation ID],
                                        c.customerID AS [Customer ID],
                                        c.custName AS [Customer Name],
                                        c.custEmail AS [Customer Email],
                                        c.contactNo AS [Contact No],
                                        r.serviceType AS [Service Type],
                                        r.reservationDate AS [Date],
                                        r.timeSlot AS [Time Slot],
                                        r.paymentMethod AS [Payment Method],
                                        r.deliveryAddress AS [Delivery Address],
                                        r.specialtyDetails AS [Specialty Details],
                                        r.status AS [Status],
                                        r.totalAmount AS [Amount (RM)],
                                        r.createdAt AS [Submitted At]
                                     FROM Reservation r
                                     INNER JOIN Customer c
                                     ON r.customerID = c.customerID
                                     ORDER BY r.createdAt DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvAdminReservations.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllReservations();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            ApproveReservationAndCreateOrder();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            RejectReservationAndRemoveOrder();
        }

        private void RejectReservationAndRemoveOrder()
        {
            if (dgvAdminReservations.CurrentRow == null)
            {
                MessageBox.Show("Please select a reservation first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int reservationID = Convert.ToInt32(dgvAdminReservations.CurrentRow.Cells["Reservation ID"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to reject this reservation?",
                "Confirm Reject",
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

                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        string updateReservationQuery = @"UPDATE Reservation
                                                  SET status = @Status
                                                  WHERE reservationID = @ReservationID";

                        using (SqlCommand updateCmd = new SqlCommand(updateReservationQuery, con, transaction))
                        {
                            updateCmd.Parameters.AddWithValue("@Status", "Rejected");
                            updateCmd.Parameters.AddWithValue("@ReservationID", reservationID);

                            updateCmd.ExecuteNonQuery();
                        }

                        string deleteOrderQuery = @"DELETE FROM [Order]
                                            WHERE reservationID = @ReservationID";

                        using (SqlCommand deleteCmd = new SqlCommand(deleteOrderQuery, con, transaction))
                        {
                            deleteCmd.Parameters.AddWithValue("@ReservationID", reservationID);

                            deleteCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Reservation rejected and removed from Order table.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadAllReservations();
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

        private void ApproveReservationAndCreateOrder()
        {
            if (dgvAdminReservations.CurrentRow == null)
            {
                MessageBox.Show("Please select a reservation first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int reservationID = Convert.ToInt32(dgvAdminReservations.CurrentRow.Cells["Reservation ID"].Value);
            int customerID = Convert.ToInt32(dgvAdminReservations.CurrentRow.Cells["Customer ID"].Value);

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        string updateReservationQuery = @"UPDATE Reservation
                                                  SET status = @Status
                                                  WHERE reservationID = @ReservationID";

                        using (SqlCommand updateCmd = new SqlCommand(updateReservationQuery, con, transaction))
                        {
                            updateCmd.Parameters.AddWithValue("@Status", "Approved");
                            updateCmd.Parameters.AddWithValue("@ReservationID", reservationID);

                            updateCmd.ExecuteNonQuery();
                        }

                        string checkOrderQuery = @"SELECT COUNT(*)
                                           FROM [Order]
                                           WHERE reservationID = @ReservationID";

                        using (SqlCommand checkCmd = new SqlCommand(checkOrderQuery, con, transaction))
                        {
                            checkCmd.Parameters.AddWithValue("@ReservationID", reservationID);

                            int orderCount = (int)checkCmd.ExecuteScalar();

                            if (orderCount == 0)
                            {
                                string insertOrderQuery = @"INSERT INTO [Order]
                                                    (reservationID, customerID, orderStatus, orderDate)
                                                    VALUES
                                                    (@ReservationID, @CustomerID, @OrderStatus, GETDATE())";

                                using (SqlCommand insertCmd = new SqlCommand(insertOrderQuery, con, transaction))
                                {
                                    insertCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                                    insertCmd.Parameters.AddWithValue("@CustomerID", customerID);
                                    insertCmd.Parameters.AddWithValue("@OrderStatus", "Processing");

                                    insertCmd.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();

                        MessageBox.Show("Reservation approved and added to Order table!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadAllReservations();
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

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            AdminOrderPage form = new AdminOrderPage();
            form.Show();
            this.Hide();
        }
    }
}