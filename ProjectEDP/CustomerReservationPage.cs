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
        }

        private void CustomerReservationPage_Load(object sender, EventArgs e)
        {
            LoadMyReservations();
        }

        private void LoadMyReservations()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT
                                        reservationID AS [Reservation ID],
                                        serviceType AS [Service Type],
                                        reservationDate AS [Date],
                                        timeSlot AS [Time Slot],
                                        paymentMethod AS [Payment Method],
                                        deliveryAddress AS [Delivery Address],
                                        specialtyDetails AS [Specialty Details],
                                        status AS [Status],
                                        createdAt AS [Submitted At]
                                     FROM Reservation
                                     WHERE customerID = @CustomerID
                                     ORDER BY createdAt DESC";

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}