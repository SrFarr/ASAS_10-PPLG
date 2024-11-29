using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Daftar_Hadir
{
    public partial class FrmDel : Form
    {
        Koneksi konek = new Koneksi();
       

       
        public FrmDel()
        {
            InitializeComponent();
        }

        private void FrmDel_Load(object sender, EventArgs e)
        {
            awal();
        }

        void awal()
        {
            TXTBabs.Text = string.Empty;
            TXTBnm.Text = string.Empty;
            CMBklas.Items.Clear(); // Membersihkan items sebelumnya
            CMBket.Items.Clear();

            CMBklas.Items.Add("10 PPLG");
            CMBklas.Items.Add("10 BR");
            CMBklas.Items.Add("10 AKL");
            CMBklas.Items.Add("10 MPLB 1");
            CMBklas.Items.Add("10 MPLB 2");

            CMBket.Items.Add("Hadir");
            CMBket.Items.Add("Sakit");
            CMBket.Items.Add("Izin");
            CMBket.Items.Add("Alpha");

            set();
        }

        public void set()
        {
            SqlConnection conn = null;
            DataSet ds = new DataSet();
            try
            {
                conn = konek.getConn();
                string query = "SELECT * FROM absensi";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "absensi");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "absensi";
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memuat data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ButtonInp_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = konek.getConn();
                string query = "DELETE FROM absensi WHERE nama = @nama AND absen = @absen AND kelas = @kelas AND keterangan = @keterangan";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", TXTBnm.Text.Trim());
                cmd.Parameters.AddWithValue("@absen", TXTBabs.Text.Trim());
                cmd.Parameters.AddWithValue("@kelas", CMBklas.Text.Trim());
                cmd.Parameters.AddWithValue("@keterangan", CMBket.Text.Trim());

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    set();
                    awal(); // Reset input
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan atau sudah dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; // Ambil baris yang diklik
                TXTBnm.Text = row.Cells["nama"].Value.ToString();
                TXTBabs.Text = row.Cells["absen"].Value.ToString();
                CMBklas.Text = row.Cells["kelas"].Value.ToString();
                CMBket.Text = row.Cells["keterangan"].Value.ToString();
            }
        }

        private void BTNback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
