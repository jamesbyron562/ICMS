namespace ICMS
{
    partial class ProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Button btnUploadPicture;
        private System.Windows.Forms.Label lblPictureHint;

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;

        private System.Windows.Forms.Panel pnlPasswordSection;
        private System.Windows.Forms.Label lblPasswordHeader;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.btnUploadPicture = new System.Windows.Forms.Button();
            this.lblPictureHint = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.pnlPasswordSection = new System.Windows.Forms.Panel();
            this.lblPasswordHeader = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlPasswordSection.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ─────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(780, 70);
            this.pnlHeader.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customer Profile";

            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(190, 215, 255);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 44);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(300, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Manage customer information and credentials";

            // ── pnlLeft ───────────────────────────────────────────
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.picProfile);
            this.pnlLeft.Controls.Add(this.btnUploadPicture);
            this.pnlLeft.Controls.Add(this.lblPictureHint);
            this.pnlLeft.Location = new System.Drawing.Point(20, 85);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 480);
            this.pnlLeft.TabIndex = 1;

            // picProfile
            this.picProfile.BackColor = System.Drawing.Color.FromArgb(230, 235, 245);
            this.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfile.Location = new System.Drawing.Point(25, 20);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(150, 150);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 0;
            this.picProfile.TabStop = false;

            // btnUploadPicture
            this.btnUploadPicture.BackColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.btnUploadPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadPicture.FlatAppearance.BorderSize = 0;
            this.btnUploadPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPicture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUploadPicture.ForeColor = System.Drawing.Color.White;
            this.btnUploadPicture.Location = new System.Drawing.Point(15, 185);
            this.btnUploadPicture.Name = "btnUploadPicture";
            this.btnUploadPicture.Size = new System.Drawing.Size(170, 36);
            this.btnUploadPicture.TabIndex = 1;
            this.btnUploadPicture.Text = "Upload Picture";
            this.btnUploadPicture.UseVisualStyleBackColor = false;
            this.btnUploadPicture.Click += new System.EventHandler(this.btnUploadPicture_Click);

            // lblPictureHint
            this.lblPictureHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblPictureHint.ForeColor = System.Drawing.Color.Gray;
            this.lblPictureHint.Location = new System.Drawing.Point(15, 230);
            this.lblPictureHint.Name = "lblPictureHint";
            this.lblPictureHint.Size = new System.Drawing.Size(170, 40);
            this.lblPictureHint.TabIndex = 2;
            this.lblPictureHint.Text = "JPG, PNG, BMP supported";
            this.lblPictureHint.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // ── pnlRight ──────────────────────────────────────────
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Controls.Add(this.pnlPasswordSection);
            this.pnlRight.Controls.Add(this.txtPhone);
            this.pnlRight.Controls.Add(this.lblPhone);
            this.pnlRight.Controls.Add(this.txtFullName);
            this.pnlRight.Controls.Add(this.lblFullName);
            this.pnlRight.Location = new System.Drawing.Point(235, 85);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(520, 480);
            this.pnlRight.TabIndex = 2;

            // lblFullName
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(50, 60, 80);
            this.lblFullName.Location = new System.Drawing.Point(0, 10);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(500, 20);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name  *";

            // txtFullName
            this.txtFullName.BackColor = System.Drawing.Color.White;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.Location = new System.Drawing.Point(0, 33);
            this.txtFullName.MaxLength = 100;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(500, 30);
            this.txtFullName.TabIndex = 1;

            // lblPhone
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(50, 60, 80);
            this.lblPhone.Location = new System.Drawing.Point(0, 79);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(500, 20);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone Number  *";

            // txtPhone
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(0, 102);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(500, 30);
            this.txtPhone.TabIndex = 3;

            // ── pnlPasswordSection ────────────────────────────────
            this.pnlPasswordSection.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.pnlPasswordSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPasswordSection.Controls.Add(this.chkShowPassword);
            this.pnlPasswordSection.Controls.Add(this.txtConfirmPassword);
            this.pnlPasswordSection.Controls.Add(this.lblConfirmPassword);
            this.pnlPasswordSection.Controls.Add(this.txtNewPassword);
            this.pnlPasswordSection.Controls.Add(this.lblNewPassword);
            this.pnlPasswordSection.Controls.Add(this.lblPasswordHeader);
            this.pnlPasswordSection.Location = new System.Drawing.Point(0, 155);
            this.pnlPasswordSection.Name = "pnlPasswordSection";
            this.pnlPasswordSection.Size = new System.Drawing.Size(500, 210);
            this.pnlPasswordSection.TabIndex = 4;

            // lblPasswordHeader
            this.lblPasswordHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPasswordHeader.ForeColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.lblPasswordHeader.Location = new System.Drawing.Point(12, 10);
            this.lblPasswordHeader.Name = "lblPasswordHeader";
            this.lblPasswordHeader.Size = new System.Drawing.Size(470, 20);
            this.lblPasswordHeader.TabIndex = 0;
            this.lblPasswordHeader.Text = "Change Password  (leave blank to keep current)";

            // lblNewPassword
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(50, 60, 80);
            this.lblNewPassword.Location = new System.Drawing.Point(12, 38);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(470, 18);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New Password";

            // txtNewPassword
            this.txtNewPassword.BackColor = System.Drawing.Color.White;
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.Location = new System.Drawing.Point(12, 59);
            this.txtNewPassword.MaxLength = 50;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(470, 30);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.UseSystemPasswordChar = true;

            // lblConfirmPassword
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(50, 60, 80);
            this.lblConfirmPassword.Location = new System.Drawing.Point(12, 103);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(470, 18);
            this.lblConfirmPassword.TabIndex = 3;
            this.lblConfirmPassword.Text = "Confirm New Password";

            // txtConfirmPassword
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(12, 124);
            this.txtConfirmPassword.MaxLength = 50;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(470, 30);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.UseSystemPasswordChar = true;

            // chkShowPassword
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110);
            this.chkShowPassword.Location = new System.Drawing.Point(12, 170);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(130, 20);
            this.chkShowPassword.TabIndex = 5;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);

            // ── pnlButtons ────────────────────────────────────────
            this.pnlButtons.BackColor = System.Drawing.Color.White;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 580);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(780, 60);
            this.pnlButtons.TabIndex = 3;

            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(610, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 38);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Profile";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(240, 243, 248);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 210, 225);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.btnClear.Location = new System.Drawing.Point(490, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 38);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // btnClose
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(20, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // ── ProfileForm ───────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(780, 640);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Profile";

            this.pnlButtons.ResumeLayout(false);
            this.pnlPasswordSection.ResumeLayout(false);
            this.pnlPasswordSection.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}