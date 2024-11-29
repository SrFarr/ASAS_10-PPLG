using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Daftar_Hadir
{
    public partial class Regist : Form
    {
        private Login login; // Referensi ke form Login
        private SqlCommand cmd;
        private SqlDataReader rd;
        private readonly Koneksi konn = new Koneksi();

        public Regist()
        {
            InitializeComponent();
        }

        void Login_Closed(object sender, EventArgs e)
        {
            login = null;
        }

        void SetForm()
        {
            TXTBconfirm.Text = "";
            TXTBnm.Text = "";
            TXTBpass.Text = "";
            TXTBid.Text = AutoId();
            TXTBid.Enabled = false;
        }

        string AutoId()
        {
            string newId = "1";
            SqlConnection conn = konn.getConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT TOP 1 id FROM Login ORDER BY id DESC", conn);
                rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    int idLast = int.Parse(rd["id"].ToString());
                    newId = (idLast + 1).ToString();
                }
                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menghasilkan ID baru: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return newId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;

            try
            {
                conn = konn.getConn();
                if (conn != null && conn.State == ConnectionState.Closed)
                {
                    conn.Open();

                   
                    if (string.IsNullOrWhiteSpace(TXTBnm.Text) || string.IsNullOrWhiteSpace(TXTBpass.Text) || string.IsNullOrWhiteSpace(TXTBconfirm.Text))
                    {
                        MessageBox.Show("Harap isi semua field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (TXTBpass.Text.Trim() != TXTBconfirm.Text.Trim())
                    {
                        MessageBox.Show("Password dan konfirmasi password tidak cocok!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (TXTBpass.Text.Trim().Length < 3)
                    {
                        MessageBox.Show("Password minimal 3 karakter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                   
                    cmd = new SqlCommand("INSERT INTO Login (id, nama, password) VALUES (@id, @nama, @pass)", conn);
                    cmd.Parameters.AddWithValue("@id", TXTBid.Text.Trim());
                    cmd.Parameters.AddWithValue("@nama", TXTBnm.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", TXTBpass.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registrasi berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetForm();

                   
                    if (login == null)
                    {
                        login = new Login();
                        login.FormClosed += Login_Closed;
                        login.Show();
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn?.Close();
            }
        }

        private void Regist_Load(object sender, EventArgs e)
        {
            SetForm();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (login == null)
            {
                login = new Login();
                login.FormClosed += Login_Closed;
                login.Show();
            }
            this.Close();
        }
    }
}
