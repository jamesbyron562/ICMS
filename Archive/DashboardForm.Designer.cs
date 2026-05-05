namespace ICMS
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            this.pnlCards = new System.Windows.Forms.Panel();

            this.pnlCustomers = new System.Windows.Forms.Panel();
            this.lblTotalCustomersLabel = new System.Windows.Forms.Label();
            this.lblTotalCustomersValue = new System.Windows.Forms.Label();

            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.lblTotalTransactionsLabel = new System.Windows.Forms.Label();
            this.lblTotalTransactionsValue = new System.Windows.Forms.Label();

            this.pnlAccounts = new System.Windows.Forms.Panel();
            this.lblTotalAccountsLabel = new System.Windows.Forms.Label();
            this.lblTotalAccountsValue = new System.Windows.Forms.Label();

            this.pnlTopBar.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.pnlCustomers.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
            this.pnlAccounts.SuspendLayout();
            this.SuspendLayout();

            // ── Form ──────────────────────────────────────────────
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Text = "ICMS - Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardForm_FormClosing);
            this.Load += new System.EventHandler(this.DashboardForm_Load);

            // ── Top Bar ───────────────────────────────────────────
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Height = 55;
            this.pnlTopBar.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);

            this.lblTitle.Text = "ICMS Dashboard";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(16, 14);

            // Nav buttons
            int navX = 220;
            SetNavButton(this.btnCustomers, "Customers", navX, 8);
            SetNavButton(this.btnTransactions, "Transactions", navX + 115, 8);
            SetNavButton(this.btnAccounts, "Accounts / Users", navX + 240, 8);

            this.btnLogout.Text = "Logout";
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(180, 50, 50);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.Size = new System.Drawing.Size(80, 35);
            this.btnLogout.Location = new System.Drawing.Point(800, 10);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Controls.Add(this.btnCustomers);
            this.pnlTopBar.Controls.Add(this.btnTransactions);
            this.pnlTopBar.Controls.Add(this.btnAccounts);
            this.pnlTopBar.Controls.Add(this.btnLogout);

            // ── Cards Panel ───────────────────────────────────────
            this.pnlCards.BackColor = System.Drawing.Color.Transparent;
            this.pnlCards.Location = new System.Drawing.Point(60, 110);
            this.pnlCards.Size = new System.Drawing.Size(780, 160);

            // Card: Total Customers
            BuildCard(this.pnlCustomers, this.lblTotalCustomersLabel, this.lblTotalCustomersValue,
                "Total Customers", System.Drawing.Color.FromArgb(24, 95, 165), 0);

            // Card: Total Transactions
            BuildCard(this.pnlTransactions, this.lblTotalTransactionsLabel, this.lblTotalTransactionsValue,
                "Total Transactions", System.Drawing.Color.FromArgb(29, 158, 117), 260);

            // Card: Total Accounts
            BuildCard(this.pnlAccounts, this.lblTotalAccountsLabel, this.lblTotalAccountsValue,
                "Total Accounts", System.Drawing.Color.FromArgb(133, 79, 11), 520);

            this.pnlCards.Controls.Add(this.pnlCustomers);
            this.pnlCards.Controls.Add(this.pnlTransactions);
            this.pnlCards.Controls.Add(this.pnlAccounts);

            // ── Add to Form ───────────────────────────────────────
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlCards);

            this.pnlTopBar.ResumeLayout(false);
            this.pnlCards.ResumeLayout(false);
            this.pnlCustomers.ResumeLayout(false);
            this.pnlTransactions.ResumeLayout(false);
            this.pnlAccounts.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // ── Helpers ───────────────────────────────────────────────
        private void SetNavButton(System.Windows.Forms.Button btn, string text, int x, int y)
        {
            btn.Text = text;
            btn.ForeColor = System.Drawing.Color.White;
            btn.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 30);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            btn.Size = new System.Drawing.Size(110, 35);
            btn.Location = new System.Drawing.Point(x, y);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;

            if (text == "Customers")
                btn.Click += new System.EventHandler(this.btnCustomers_Click);
            else if (text == "Transactions")
                btn.Click += new System.EventHandler(this.btnTransactions_Click);
            else
                btn.Click += new System.EventHandler(this.btnAccounts_Click);
        }

        private void BuildCard(
            System.Windows.Forms.Panel panel,
            System.Windows.Forms.Label lblLabel,
            System.Windows.Forms.Label lblValue,
            string labelText,
            System.Drawing.Color accentColor,
            int x)
        {
            panel.BackColor = System.Drawing.Color.White;
            panel.Size = new System.Drawing.Size(240, 140);
            panel.Location = new System.Drawing.Point(x, 0);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Accent bar on left
            var accent = new System.Windows.Forms.Panel();
            accent.BackColor = accentColor;
            accent.Size = new System.Drawing.Size(6, 140);
            accent.Location = new System.Drawing.Point(0, 0);
            panel.Controls.Add(accent);

            lblLabel.Text = labelText;
            lblLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblLabel.ForeColor = System.Drawing.Color.Gray;
            lblLabel.AutoSize = true;
            lblLabel.Location = new System.Drawing.Point(20, 30);

            lblValue.Text = "0";
            lblValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            lblValue.ForeColor = accentColor;
            lblValue.AutoSize = true;
            lblValue.Location = new System.Drawing.Point(20, 65);

            panel.Controls.Add(lblLabel);
            panel.Controls.Add(lblValue);
        }

        // ── Controls ──────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel pnlCards;

        private System.Windows.Forms.Panel pnlCustomers;
        private System.Windows.Forms.Label lblTotalCustomersLabel;
        private System.Windows.Forms.Label lblTotalCustomersValue;

        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Label lblTotalTransactionsLabel;
        private System.Windows.Forms.Label lblTotalTransactionsValue;

        private System.Windows.Forms.Panel pnlAccounts;
        private System.Windows.Forms.Label lblTotalAccountsLabel;
        private System.Windows.Forms.Label lblTotalAccountsValue;

        #endregion
    }
}