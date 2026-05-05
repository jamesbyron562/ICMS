using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ICMS
{
    public class AccountForm : Form
    {
        TextBox txtUsername = new TextBox();
        TextBox txtPassword = new TextBox();
        TextBox txtFullName = new TextBox();
        ComboBox cmbRole = new ComboBox();
        ComboBox cmbStatus = new ComboBox();
        DataGridView dgv = new DataGridView();

        public AccountForm()
        {
            Text = "ICMS - Accounts";
            Size = new Size(900, 580);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;

            Label title = new Label { Text = "Account Management", Font = new Font("Segoe UI", 16, FontStyle.Bold), Location = new Point(25, 20), Size = new Size(300, 35) };
            Controls.Add(title);

            dgv.Location = new Point(30, 70); dgv.Size = new Size(820, 270); dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.CellClick += Dgv_CellClick;
            Controls.Add(dgv);

            AddLabel("Username", 30, 370); Place(txtUsername, 130, 368);
            AddLabel("Password", 30, 415); Place(txtPassword, 130, 413);
            AddLabel("Full Name", 380, 370); Place(txtFullName, 480, 368);
            AddLabel("Role", 380, 415); Place(cmbRole, 480, 413);
            AddLabel("Status", 30, 460); Place(cmbStatus, 130, 458);

            cmbRole.Items.AddRange(new string[] { "Administrator", "Staff" });
            cmbStatus.Items.AddRange(new string[] { "Active", "Inactive" });

            Btn("ADD", 480, 460, Color.RoyalBlue).Click += (s, e) => AddUser();
            Btn("UPDATE", 570, 460, Color.SeaGreen).Click += (s, e) => UpdateUser();
            Btn("DELETE", 680, 460, Color.Red).Click += (s, e) => DeleteUser();
            Btn("CLEAR", 770, 460, Color.DarkOrange).Click += (s, e) => ClearFields();

            Load += (s, e) => LoadUsers();
        }

        void AddLabel(string t, int x, int y) { Controls.Add(new Label { Text = t, Location = new Point(x, y), Size = new Size(100, 25) }); }
        void Place(Control c, int x, int y) { c.Location = new Point(x, y); c.Size = new Size(200, 30); Controls.Add(c); }
        Button Btn(string t, int x, int y, Color color) { Button b = new Button { Text = t, Location = new Point(x, y), Size = new Size(80, 35), BackColor = color, ForeColor = Color.White, FlatStyle = FlatStyle.Flat }; Controls.Add(b); return b; }

        void LoadUsers()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open(); SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", con);
                DataTable dt = new DataTable(); da.Fill(dt); dgv.DataSource = dt;
            }
        }

        void AddUser()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open(); SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES(@u,@p,@f,@r,@s)", con);
                cmd.Parameters.AddWithValue("@u", txtUsername.Text); cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                cmd.Parameters.AddWithValue("@f", txtFullName.Text); cmd.Parameters.AddWithValue("@r", cmbRole.Text); cmd.Parameters.AddWithValue("@s", cmbStatus.Text);
                cmd.ExecuteNonQuery();
            }
            LoadUsers();
        }

        void UpdateUser()
        {
            if (dgv.CurrentRow == null) return;
            int id = Convert.ToInt32(dgv.CurrentRow.Cells["UserID"].Value);
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open(); SqlCommand cmd = new SqlCommand("UPDATE Users SET Username=@u, Password=@p, FullName=@f, Role=@r, Status=@s WHERE UserID=@id", con);
                cmd.Parameters.AddWithValue("@id", id); cmd.Parameters.AddWithValue("@u", txtUsername.Text); cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                cmd.Parameters.AddWithValue("@f", txtFullName.Text); cmd.Parameters.AddWithValue("@r", cmbRole.Text); cmd.Parameters.AddWithValue("@s", cmbStatus.Text);
                cmd.ExecuteNonQuery();
            }
            LoadUsers();
        }

        void DeleteUser()
        {
            if (dgv.CurrentRow == null) return;
            int id = Convert.ToInt32(dgv.CurrentRow.Cells["UserID"].Value);
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open(); SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID=@id", con);
                cmd.Parameters.AddWithValue("@id", id); cmd.ExecuteNonQuery();
            }
            LoadUsers();
        }

        void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            txtUsername.Text = dgv.CurrentRow.Cells["Username"].Value.ToString();
            txtPassword.Text = dgv.CurrentRow.Cells["Password"].Value.ToString();
            txtFullName.Text = dgv.CurrentRow.Cells["FullName"].Value.ToString();
            cmbRole.Text = dgv.CurrentRow.Cells["Role"].Value.ToString();
            cmbStatus.Text = dgv.CurrentRow.Cells["Status"].Value.ToString();
        }

        void ClearFields() { txtUsername.Clear(); txtPassword.Clear(); txtFullName.Clear(); cmbRole.Text = ""; cmbStatus.Text = ""; }
    }
}
