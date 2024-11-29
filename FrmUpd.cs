using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daftar_Hadir
{
    public partial class FrmUpd : Form
    {
        Koneksi konek = new Koneksi();
        public FrmUpd()
        {
            InitializeComponent();
        }

        private void FrmUpd_Load(object sender, EventArgs e)
        {
            awal();
        }
        public void awal()
        {
            TXTBabsen.Text = " ";
            TXTBnama.Text = " ";
            CMBkelas.Items.Add("10 PPLG ");
            CMBkelas.Items.Add("10 BR ");
            CMBkelas.Items.Add("10 AKL ");
            CMBkelas.Items.Add("10 MPLB 1 ");
            CMBkelas.Items.Add("10 MPLB 2 ");
            CMBket.Items.Add("Hadir");
            CMBket.Items.Add("Sakit");
            CMBket.Items.Add("Izin");
            CMBket.Items.Add("Alpha");
            set();
        }
        public void set()
        {
            SqlConnection conn = null;
            conn = konek.getConn();
            SqlCommand cmd = new SqlCommand("SELECT * FROM absensi",conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "absensi");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "absensi";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;  
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            Refresh();
            conn.Close();
        }
        private void BTNupd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            conn = konek.getConn();
            try
            {
                if(string.IsNullOrWhiteSpace(TXTBnama.Text) || string.IsNullOrWhiteSpace(TXTBabsen.Text) || string.IsNullOrWhiteSpace(CMBkelas.Text) || string.IsNullOrWhiteSpace(CMBket.Text))
                {
                    MessageBox.Show("Error", "Data harus diisi semua", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = " UPDATE absensi SET absen = @absen, kelas =  @kelas, keterangan = @keterangan WHERE nama = @nama";
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.Parameters.AddWithValue("@nama", TXTBnama.Text);
                cmd.Parameters.AddWithValue("@absen", TXTBabsen.Text);
                cmd.Parameters.AddWithValue("@kelas", CMBkelas.Text);
                cmd.Parameters.AddWithValue("@keterangan", CMBket.Text);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
               

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    set();
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan atau tidak diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" +ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                TXTBnama.Text= row.Cells["nama"].Value.ToString();
                TXTBabsen.Text = row.Cells["absen"].Value.ToString();
                CMBkelas.Text = row.Cells["kelas"].Value.ToString() ;
                CMBket.Text = row.Cells["keterangan"].Value.ToString();
            }
        }

        private void TXTBabsen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BTNupd.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
