using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ICMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                lblError.Text    = "Please enter your username.";
                lblError.Visible = true;
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                lblError.Text    = "Please enter your password.";
                lblError.Visible = true;
                txtPassword.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM Accounts WHERE Username = @user AND Password = @pass";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            lblError.Visible = false;
                            DashboardForm dashboard = new DashboardForm();
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            lblError.Text    = "Invalid username or password. Please try again.";
                            lblError.Visible = true;
                            txtPassword.Clear();
                            txtPassword.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblError.Text    = "Connection error: " + ex.Message;
                lblError.Visible = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            lblError.Visible = false;
            txtUsername.Focus();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact your system administrator to reset your password.",
                "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblAppTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
