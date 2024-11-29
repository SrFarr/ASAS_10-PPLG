using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daftar_Hadir
{
    public partial class frminput : Form
    {
        MenuUtama utama;
        private SqlConnection conn;
        private SqlCommand cmd;
        Koneksi konek = new Koneksi();
        public frminput()
        {
            InitializeComponent();
            
        }
        public void awal()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            CMBklas.Text = " ";
            set();
            Refresh();
        }
        public void set()
        {
            CMBklas.Items.Add(" 10 PPLG ");
            CMBklas.Items.Add(" 10 BR ");
            CMBklas.Items.Add(" 10 AKL ");
            CMBklas.Items.Add(" 10 MPLB 1 ");
            CMBklas.Items.Add(" 10 MPLB 2 ");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            awal();
        }

        private void ButtonInp_Click(object sender, EventArgs e)
        {
            try
            {
                conn = konek.getConn();
                conn.Open();
                cmd = new SqlCommand("INSERT INTO absensi (nama, absen, kelas, keterangan) VALUES (@nama,@absen,@kelas, @keterangan) ", conn);
                cmd.Parameters.AddWithValue("@nama", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@absen", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@kelas", CMBklas.Text.Trim());
                cmd.Parameters.AddWithValue("@keterangan", comboBox1.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil input data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
              
            }
        }

        private void BTNupd_Click(object sender, EventArgs e)
        {
          
        }

        private void BTNdel_Click(object sender, EventArgs e)
        {
        }

        private void BTNsearc_Click(object sender, EventArgs e)
        {
            
        }

        private void iNPUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

      

        private void BTNback_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
