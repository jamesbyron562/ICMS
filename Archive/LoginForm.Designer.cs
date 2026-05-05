namespace ICMS
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        // ── Controls ──────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblAppSubtitle;
        private System.Windows.Forms.Label lblAppVersion;

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSignIn;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.LinkLabel lblForgotPassword;

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblAppSubtitle = new System.Windows.Forms.Label();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.pnlLeft.Controls.Add(this.lblAppTitle);
            this.pnlLeft.Controls.Add(this.lblAppSubtitle);
            this.pnlLeft.Controls.Add(this.lblAppVersion);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(270, 500);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(3, 145);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(319, 50);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "Mel and Friends";
            this.lblAppTitle.Click += new System.EventHandler(this.lblAppTitle_Click);
            // 
            // lblAppSubtitle
            // 
            this.lblAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.lblAppSubtitle.Location = new System.Drawing.Point(30, 215);
            this.lblAppSubtitle.Name = "lblAppSubtitle";
            this.lblAppSubtitle.Size = new System.Drawing.Size(200, 50);
            this.lblAppSubtitle.TabIndex = 1;
            this.lblAppSubtitle.Text = "Internet Cafe Management System";
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAppVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.lblAppVersion.Location = new System.Drawing.Point(30, 450);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(200, 20);
            this.lblAppVersion.TabIndex = 2;
            this.lblAppVersion.Text = "Version 1.0";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlRight.Controls.Add(this.lblWelcome);
            this.pnlRight.Controls.Add(this.lblSignIn);
            this.pnlRight.Controls.Add(this.lblUsername);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.lblPassword);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.chkShowPassword);
            this.pnlRight.Controls.Add(this.lblError);
            this.pnlRight.Controls.Add(this.lblForgotPassword);
            this.pnlRight.Controls.Add(this.btnLogin);
            this.pnlRight.Controls.Add(this.btnClear);
            this.pnlRight.Location = new System.Drawing.Point(267, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(383, 500);
            this.pnlRight.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.lblWelcome.Location = new System.Drawing.Point(16, 58);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(404, 40);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to our System!";
            // 
            // lblSignIn
            // 
            this.lblSignIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblSignIn.Location = new System.Drawing.Point(40, 98);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(310, 20);
            this.lblSignIn.TabIndex = 1;
            this.lblSignIn.Text = "Sign in to your account to continue";
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.lblUsername.Location = new System.Drawing.Point(40, 145);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(310, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(40, 168);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(310, 30);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.lblPassword.Location = new System.Drawing.Point(40, 215);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(310, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(40, 238);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(310, 30);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.chkShowPassword.Location = new System.Drawing.Point(40, 276);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(120, 20);
            this.chkShowPassword.TabIndex = 6;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblError.Location = new System.Drawing.Point(40, 300);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(310, 20);
            this.lblError.TabIndex = 7;
            this.lblError.Visible = false;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.lblForgotPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.lblForgotPassword.Location = new System.Drawing.Point(220, 276);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(130, 20);
            this.lblForgotPassword.TabIndex = 8;
            this.lblForgotPassword.TabStop = true;
            this.lblForgotPassword.Text = "Forgot Password?";
            this.lblForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgotPassword_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(40, 335);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(310, 42);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.btnClear.Location = new System.Drawing.Point(40, 388);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(310, 36);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 500);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(650, 30);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.lblFooter.Location = new System.Drawing.Point(0, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(650, 30);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "© 2026 ICMS  —  Internet Cafe Management System";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(650, 530);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ICMS - Login";
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
