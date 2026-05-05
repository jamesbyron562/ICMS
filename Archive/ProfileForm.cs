using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ICMS
{
    public partial class ProfileForm : Form
    {
        private string selectedImagePath = "";
        private int customerId = 0; // Set this when loading a specific customer

        public ProfileForm()
        {
            InitializeComponent();
        }

        public ProfileForm(int custId)
        {
            InitializeComponent();
            customerId = custId;
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            if (customerId <= 0) return;

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT FullName, PhoneNumber, ProfilePicture FROM Customers WHERE CustomerID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", customerId);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txtFullName.Text = dr["FullName"].ToString();
                                txtPhone.Text = dr["PhoneNumber"].ToString();

                                if (dr["ProfilePicture"] != DBNull.Value)
                                {
                                    byte[] imgBytes = (byte[])dr["ProfilePicture"];
                                    using (MemoryStream ms = new MemoryStream(imgBytes))
                                    {
                                        picProfile.Image = Image.FromStream(ms);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Select Profile Picture";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    picProfile.Image = Image.FromFile(selectedImagePath);
                    picProfile.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone Number is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            // Validate password change
            if (!string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("New Password and Confirm Password do not match.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPassword.Focus();
                    return;
                }

                if (txtNewPassword.Text.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNewPassword.Focus();
                    return;
                }
            }

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // Build image bytes if a new picture was selected
                    byte[] imgBytes = null;
                    if (!string.IsNullOrEmpty(selectedImagePath))
                    {
                        imgBytes = File.ReadAllBytes(selectedImagePath);
                    }

                    string query;
                    if (customerId > 0)
                    {
                        // UPDATE existing customer
                        if (!string.IsNullOrWhiteSpace(txtNewPassword.Text))
                        {
                            query = imgBytes != null
                                ? "UPDATE Customers SET FullName=@name, PhoneNumber=@phone, Password=@pwd, ProfilePicture=@pic WHERE CustomerID=@id"
                                : "UPDATE Customers SET FullName=@name, PhoneNumber=@phone, Password=@pwd WHERE CustomerID=@id";
                        }
                        else
                        {
                            query = imgBytes != null
                                ? "UPDATE Customers SET FullName=@name, PhoneNumber=@phone, ProfilePicture=@pic WHERE CustomerID=@id"
                                : "UPDATE Customers SET FullName=@name, PhoneNumber=@phone WHERE CustomerID=@id";
                        }
                    }
                    else
                    {
                        // INSERT new customer
                        query = "INSERT INTO Customers (FullName, PhoneNumber, Password, ProfilePicture) VALUES (@name, @phone, @pwd, @pic)";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());

                        if (query.Contains("@pwd"))
                            cmd.Parameters.AddWithValue("@pwd", txtNewPassword.Text);

                        if (query.Contains("@pic"))
                            cmd.Parameters.AddWithValue("@pic", (object)imgBytes ?? DBNull.Value);

                        if (query.Contains("@id"))
                            cmd.Parameters.AddWithValue("@id", customerId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Customer profile saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear password fields after save
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving profile: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtPhone.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            picProfile.Image = null;
            selectedImagePath = "";
            customerId = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            txtConfirmPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
