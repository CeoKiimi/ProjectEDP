using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectEDP
{
    public partial class LoginForm : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\TEST\ProjectEDP\ProjectEDP\EasyLaundry.mdf;Integrated Security=True;Connect Timeout=30";

        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameOrEmail = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(usernameOrEmail))
            {
                MessageBox.Show("Please enter your email or admin username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    //admin
                    string adminQuery = @"SELECT adminID, adminName
                      FROM Admin
                      WHERE adminName = @Username
                      AND [password] = @Password";

                    using (SqlCommand adminCmd = new SqlCommand(adminQuery, con))
                    {
                        adminCmd.Parameters.AddWithValue("@Username", usernameOrEmail);
                        adminCmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = adminCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CurrentUser.AdminID = Convert.ToInt32(reader["adminID"]);
                                CurrentUser.AdminName = reader["adminName"].ToString();
                                CurrentUser.IsAdmin = true;

                                MessageBox.Show("Welcome Admin, " + CurrentUser.AdminName + "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                AdminHomepage form = new AdminHomepage();
                                form.Show();
                                this.Hide();
                                return;
                            }
                        }

                        //customer
                        string customerQuery = @"SELECT customerID, custName 
                         FROM Customer 
                         WHERE custEmail = @Email 
                         AND [password] = @Password";

                        using (SqlCommand customerCmd = new SqlCommand(customerQuery, con))
                        {
                            customerCmd.Parameters.AddWithValue("@Email", usernameOrEmail);
                            customerCmd.Parameters.AddWithValue("@Password", password);

                            using (SqlDataReader reader = customerCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    CurrentUser.CustomerID = Convert.ToInt32(reader["customerID"]);
                                    CurrentUser.CustomerName = reader["custName"].ToString();

                                    MessageBox.Show("Customer login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Homepage form = new Homepage();
                                    form.Show();
                                    this.Hide();
                                    return;
                                }
                            }
                        }

                        MessageBox.Show("Account not found. Please register first, or check your password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}