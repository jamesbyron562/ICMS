using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ICMS
{
    public class TransactionForm : Form
    {
        TextBox txtCustomer = new TextBox();
        ComboBox cmbPC = new ComboBox();
        DateTimePicker dtIn = new DateTimePicker();
        DateTimePicker dtOut = new DateTimePicker();
        TextBox txtHours = new TextBox();
        TextBox txtRate = new TextBox();
        TextBox txtTotal = new TextBox();
        DataGridView dgv = new DataGridView();

        public TransactionForm()
        {
            Text = "ICMS - Transactions";
            Size = new Size(900, 580);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;

            Label title = new Label { Text = "New Transaction", Font = new Font("Segoe UI", 16, FontStyle.Bold), Location = new Point(25, 20), Size = new Size(250, 35) };
            Controls.Add(title);

            AddLabel("Customer Name", 30, 80); Place(txtCustomer, 170, 78);
            AddLabel("PC Number", 30, 125); Place(cmbPC, 170, 123);
            AddLabel("Time In", 30, 170); Place(dtIn, 170, 168);
            AddLabel("Time Out", 30, 215); Place(dtOut, 170, 213);
            AddLabel("Hours Used", 30, 260); Place(txtHours, 170, 258);
            AddLabel("Rate Per Hour", 30, 305); Place(txtRate, 170, 303);
            AddLabel("Total Amount", 30, 350); Place(txtTotal, 170, 348);

            txtHours.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtRate.Text = "25";
            dtIn.Format = DateTimePickerFormat.Custom; dtIn.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtOut.Format = DateTimePickerFormat.Custom; dtOut.CustomFormat = "MM/dd/yyyy hh:mm tt";

            Button compute = Btn("COMPUTE", 30, 410, Color.RoyalBlue); compute.Click += (s, e) => Compute();
            Button save = Btn("SAVE", 145, 410, Color.SeaGreen); save.Click += (s, e) => SaveTransaction();
            Button clear = Btn("CLEAR", 260, 410, Color.DarkOrange); clear.Click += (s, e) => ClearFields();

            dgv.Location = new Point(390, 80);
            dgv.Size = new Size(470, 380);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Controls.Add(dgv);

            Button del = Btn("DELETE", 390, 480, Color.Red); del.Click += (s, e) => DeleteTransaction();

            Load += (s, e) => { LoadPC(); LoadTransactions(); };
        }

        void AddLabel(string t, int x, int y) { Controls.Add(new Label { Text = t, Location = new Point(x, y), Size = new Size(130, 25) }); }
        void Place(Control c, int x, int y) { c.Location = new Point(x, y); c.Size = new Size(180, 30); Controls.Add(c); }
        Button Btn(string t, int x, int y, Color color) { Button b = new Button { Text = t, Location = new Point(x, y), Size = new Size(100, 35), BackColor = color, ForeColor = Color.White, FlatStyle = FlatStyle.Flat }; Controls.Add(b); return b; }

        void LoadPC()
        {
            cmbPC.Items.Clear();
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT PCNumber FROM Computers WHERE Status='Available'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) cmbPC.Items.Add(dr[0].ToString());
            }
        }

        void LoadTransactions()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Transactions", con);
                DataTable dt = new DataTable(); da.Fill(dt); dgv.DataSource = dt;
            }
        }

        void Compute()
        {
            double hours = (dtOut.Value - dtIn.Value).TotalHours;
            double rate = Convert.ToDouble(txtRate.Text);
            txtHours.Text = hours.ToString("0.00");
            txtTotal.Text = (hours * rate).ToString("0.00");
        }

        void SaveTransaction()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Transactions VALUES(@c,@pc,@in,@out,@h,@r,@t)", con);
                cmd.Parameters.AddWithValue("@c", txtCustomer.Text);
                cmd.Parameters.AddWithValue("@pc", cmbPC.Text);
                cmd.Parameters.AddWithValue("@in", dtIn.Value);
                cmd.Parameters.AddWithValue("@out", dtOut.Value);
                cmd.Parameters.AddWithValue("@h", Convert.ToDouble(txtHours.Text));
                cmd.Parameters.AddWithValue("@r", Convert.ToDouble(txtRate.Text));
                cmd.Parameters.AddWithValue("@t", Convert.ToDouble(txtTotal.Text));
                cmd.ExecuteNonQuery();

                SqlCommand upd = new SqlCommand("UPDATE Computers SET Status='In Use' WHERE PCNumber=@pc", con);
                upd.Parameters.AddWithValue("@pc", cmbPC.Text);
                upd.ExecuteNonQuery();
            }
            MessageBox.Show("Transaction Saved");
            LoadPC(); LoadTransactions();
        }

        void DeleteTransaction()
        {
            if (dgv.CurrentRow == null) return;
            int id = Convert.ToInt32(dgv.CurrentRow.Cells["TransactionID"].Value);
            string pc = dgv.CurrentRow.Cells["PCNumber"].Value.ToString();
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Transactions WHERE TransactionID=@id", con);
                cmd.Parameters.AddWithValue("@id", id); cmd.ExecuteNonQuery();
                SqlCommand upd = new SqlCommand("UPDATE Computers SET Status='Available' WHERE PCNumber=@pc", con);
                upd.Parameters.AddWithValue("@pc", pc); upd.ExecuteNonQuery();
            }
            LoadPC(); LoadTransactions();
        }

        void ClearFields() { txtCustomer.Clear(); cmbPC.Text = ""; txtHours.Clear(); txtTotal.Clear(); txtRate.Text = "25"; }
    }
}
