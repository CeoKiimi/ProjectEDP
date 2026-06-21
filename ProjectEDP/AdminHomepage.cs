using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEDP
{
    public partial class AdminHomepage : Form
    {
        public AdminHomepage()
        {
            InitializeComponent();
        }

        private void manageReservationBtn_Click(object sender, EventArgs e)
        {
            AdminDashboardPage form = new AdminDashboardPage();
            form.Show();
            this.Hide();
        }

        private void manageOrderBtn_Click(object sender, EventArgs e)
        {
            AdminOrderPage form = new AdminOrderPage();
            form.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            CurrentUser.CustomerID = 0;
            CurrentUser.CustomerName = null;

            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }
    }
}