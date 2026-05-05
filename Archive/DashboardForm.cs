using System;
using System.Drawing;
using System.Windows.Forms;

namespace ICMS
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadSummaryData();
        }

        private void LoadSummaryData()
        {
            try
            {
                // Load Total Customers
                int totalCustomers = DBConnection.GetCount("SELECT COUNT(*) FROM Customers");
                lblTotalCustomersValue.Text = totalCustomers.ToString();

                // Load Total Transactions
                int totalTransactions = DBConnection.GetCount("SELECT COUNT(*) FROM Transactions");
                lblTotalTransactionsValue.Text = totalTransactions.ToString();

                // Load Total Accounts
                int totalAccounts = DBConnection.GetCount("SELECT COUNT(*) FROM Accounts");
                lblTotalAccountsValue.Text = totalAccounts.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Navigation: Customers
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            // CustomerForm customerForm = new CustomerForm();
            // customerForm.Show();
            // this.Hide();
            MessageBox.Show("Customers module coming soon.", "ICMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Navigation: Transactions
        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Show();
            this.Hide();
        }

        // Navigation: Accounts / Users
        private void btnAccounts_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
            this.Hide();
        }

        // Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
