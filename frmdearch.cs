using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Daftar_Hadir
{
    public partial class frmdearch : Form
    {
        Koneksi konek = new Koneksi();

        public frmdearch()
        {
            InitializeComponent();
        }

        private void frmdearch_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; 
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTBsearch.Text))
            {
                MessageBox.Show("Masukkan kata kunci untuk pencarian.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Buat koneksi dan gunakan blok using
                using (SqlConnection conn = konek.getConn())
                {
                    DataTable dt = new DataTable("absensi");
                    string query = @"
                        SELECT * 
                        FROM absensi 
                        WHERE 
                            nama LIKE @cari OR 
                            absen LIKE @cari OR 
                            kelas LIKE @cari OR 
                            keterangan LIKE @cari";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        string cari = "%" + TXTBsearch.Text + "%";
                        cmd.Parameters.AddWithValue("@cari", cari);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }

                 
                    BindDataToGrid(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindDataToGrid(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Tidak ada data yang ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null;
            }
        }

        private void TXTBsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) 
            {
                BTNSearch.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("yyyy-MM-dd : HH-mm-ss");
        }
    }
}
