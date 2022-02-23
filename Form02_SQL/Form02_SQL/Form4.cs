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

namespace Form02_SQL
{
    public partial class Form4 : Form
    {
        SqlConnection baglanti = null;
        SqlCommand komut = null;
        SqlDataReader dr = null;
        string sorguCumlesi = "";
        string baglantiCumlesi = @"Server=DESKTOP-4JE8ADO\SQLEXPRESS; Database=Sirket100; User=sa; Pwd=123";
        int sayac = 1;

        public Form4()
        {
            InitializeComponent();
        }
        void Status()
        {
            lblStatus.Text += ".";
            sayac++;
        }
        void Login()
        {
            string ad = txtUser.Text;
            string pass = txtPass.Text;
            sorguCumlesi = $"SELECT * FROM tblUsers WHERE UserName='{ad}' AND Pass='{pass}'";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();
            if (dr.Read() == true) //onu okuduğunda...
            {
                lblStatus.Text = "Giriş Başarılı,yönlendiriliyorsunuz,lütfen bekleyin";
                txtUser.Enabled = false;
                txtPass.Enabled = false;
                timer1.Start();
            }
            else
            {
                lblStatus.Text = "Giriş Başarısız";

            }
            baglanti.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        void ProgressBar1()
        {
            //lblProgressBar.Text += "";
            lblProgressBar.Width += 80;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac <= 5)
            {
                Status();
                ProgressBar1();
            }
            else
            {
                timer1.Stop();
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //e.Handled = false;
                txtPass.Focus();
            }


        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //btnLogin.PerformClick();
                Login();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //lblProgressBar.Text = "";
        }
    }
}

