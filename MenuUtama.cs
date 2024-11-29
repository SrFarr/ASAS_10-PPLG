using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Daftar_Hadir
{
    public partial class MenuUtama : Form
    {
        // Fungsi untuk melakukan hashing menggunakan SHA-256
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private string hashedPassword = "GBXjYNCN/htlV60g7ADRbbm14L5gG4lF8BckPxESR60="; //password admin = FathurGanteng

        public static MenuUtama menu = new MenuUtama();
        frminput input;
        FrmUpd upd;
        FrmDel del;
        frmdearch search;
        Login login;

        void locked()
        {
            stripLainnya.Enabled = false;
            stripMenu.Enabled = false;
            flowLogout.Enabled = false;
            menu = this;
        }

        void login_Closed(object sender, EventArgs e)
        {
            login = null;
        }

        void input_Closed(object sender, EventArgs e)
        {
            input = null; 
        }

        void upd_Closed(object sender, EventArgs e)
        {
            upd = null; 
        }

        void del_Closed(object sender, EventArgs e)
        {
            del = null;
        }

        void search_Closed(object sender, EventArgs e)
        {
            search = null;
        }

        public MenuUtama()
        {
            InitializeComponent();
        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {
            locked();
        }

        private void flowAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Fathur\nAbsen 19\nKelas 10 PPLG\nAplikasi Pencatatan Kehadiran Siswa",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void flowLogout_Click(object sender, EventArgs e)
        {
            stripMenu.Enabled = false;
            stripLainnya.Enabled = false;
            flowLogout.Enabled = false;

            if (login != null)
            {
                login.Close();
                login = null;
            }

            MessageBox.Show("Anda telah logout.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void flowAdmin_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Masukkan password untuk membuka menu admin:", "Password Admin", "");

            string inputHashed = HashPassword(input);

            if (inputHashed == hashedPassword)
            {
                MessageBox.Show("Menu admin terbuka", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stripMenu.Enabled = true;
                stripLainnya.Enabled = true;
                flowGuru.Enabled = false;
            }
            else
            {
                MessageBox.Show("Password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flowInput_Click(object sender, EventArgs e)
        {
            if (input == null)
            {
                input = new frminput();
                input.FormClosed += input_Closed;
                input.Show();
            }
            else
            {
                input.BringToFront();
                input.Activate();
            }
        }

        private void flowDisplay_Click(object sender, EventArgs e)
        {
            if (search == null)
            {
                search = new frmdearch();
                search.FormClosed += search_Closed;
                search.Show();
            }
            else
            {
                search.BringToFront();
                search.Activate();
            }
        }

        private void flowGuru_Click(object sender, EventArgs e)
        {
            if (login == null)
            {
                login = new Login();
                login.FormClosed += login_Closed;
                login.Show();
            }
            else
            {
                login.BringToFront();
                login.Activate();
            }
        }

        private void flowUpdate_Click(object sender, EventArgs e)
        {
            if (upd == null)
            {
                upd = new FrmUpd();
                upd.FormClosed += upd_Closed;
                upd.Show();
            }
            else
            {
                upd.BringToFront();
                upd.Activate();
            }
        }

        private void flowDelete_Click(object sender, EventArgs e)
        {
            if (del == null)
            {
                del = new FrmDel();
                del.FormClosed += del_Closed;
                del.Show();
            }
            else
            {
                del.BringToFront();
                del.Activate();
            }
        }
    }
}
