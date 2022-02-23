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

namespace Telefon_Rehberi_V2
{
    public partial class YeniKayitFormu : Form
    {
        string sorguCumlesi;
        string baglantiCumlesi = @"Server=DESKTOP-4JE8ADO\SQLEXPRESS; Database=sRehber; User=sa; Pwd=123";
        SqlConnection baglanti;
        SqlCommand komut;
        public YeniKayitFormu()
        {
            InitializeComponent();
        }
        void Kaydet()
        {
            try
            {
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string cinsiyet = cmbCinsiyet.Text == "Erkek" ? "E" : "K";
                //if (cmbCinsiyet.Text == "Erkek")
                //{
                //    cinsiyet = "E";
                //}
                //else
                //{
                //    cinsiyet = "K";
                //}
                string tel = txtTelefon.Text;

                sorguCumlesi = $"INSERT INTO tblKisiler VALUES ('{ad}','{soyad}','{cinsiyet}','{tel}')";
                baglanti = new SqlConnection(baglantiCumlesi);
                komut = new SqlCommand(sorguCumlesi, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                
                //MessageBox.Show("Kayıt Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
                
            }
            
        }
        void Temizle()
        {
           
            txtAd.ResetText();
            txtSoyad.ResetText();
            cmbCinsiyet.ResetText();
            txtTelefon.ResetText();
            txtAd.Focus();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Form1 anaForm = new Form1();
            anaForm.Show();
            this.Hide();
        }

        private void YeniKayitFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnKapat.PerformClick(); // kapata başmıs gibi çalışır
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void YeniKayitFormu_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.SelectedIndex = 0;
        }
    }
}
            


