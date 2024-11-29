using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Daftar_Hadir
{
    public partial class Login : Form
    {
        private Regist regist; 
        private readonly Koneksi konek = new Koneksi();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
            TXTBid.Clear();
            TXTBnm.Clear();
            TXTBpass.Clear();
        }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (string.IsNullOrWhiteSpace(TXTBid.Text) || string.IsNullOrWhiteSpace(TXTBnm.Text) || string.IsNullOrWhiteSpace(TXTBpass.Text))
            {
                MessageBox.Show("Semua kolom harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = konek.getConn())
                {
                    string query = "SELECT * FROM Login WHERE id = @id AND nama = @nama AND password = @pass";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", TXTBid.Text.Trim());
                    cmd.Parameters.AddWithValue("@nama", TXTBnm.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", TXTBpass.Text.Trim());

                    conn.Open();
                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                      
                        MenuUtama.menu.stripLainnya.Enabled = true;
                        MenuUtama.menu.flowLogout.Enabled = true;

                        MessageBox.Show("Login berhasil! Selamat datang, " + rd["nama"].ToString(), "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        
                        MessageBox.Show("ID, Nama, atau Password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    rd.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
            if (regist == null || regist.IsDisposed)
            {
                regist = new Regist(); 
                regist.FormClosed += Regist_Closed;
                regist.Show();
            }
            else
            {
                regist.BringToFront(); 
            }
            this.Hide();
        }

        private void Regist_Closed(object sender, FormClosedEventArgs e)
        {
            regist = null;
            this.Show(); 
        }
    }
}
