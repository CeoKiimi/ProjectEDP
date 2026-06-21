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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            CustomerDashboard form = new CustomerDashboard();
            form.Show();
        }

        private void reserveListbtn_Click(object sender, EventArgs e)
        {
            CustomerReservationPage form = new CustomerReservationPage();
            form.Show();
        }
    }
}
