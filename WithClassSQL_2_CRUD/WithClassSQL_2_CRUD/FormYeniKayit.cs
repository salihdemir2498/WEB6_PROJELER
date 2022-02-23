using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithClassSQL_2_CRUD
{
    public partial class FormYeniKayit : Form
    {
        VeriTabani vt = new VeriTabani();
        string sorguCumlesi;
        public FormYeniKayit()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtTc.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtMail.Clear();
            txtAdres.Clear();
            cmbCinsiyet.SelectedIndex=0;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {


            if (vt.KontrolEt(txtTc.Text, txtAd.Text, txtSoyad.Text, cmbCinsiyet.Text))
            {
                string cinsiyet = cmbCinsiyet.Text == "Kadın" ? "K" : "E";
                sorguCumlesi = $"INSERT INTO tblHastalar VALUES ('{txtTc.Text}', '{txtAd.Text}', '{txtSoyad.Text}', '{cinsiyet}','{txtAdres.Text}','{txtTelefon.Text}','{txtMail.Text}')";
                vt.Islem(sorguCumlesi);
                MessageBox.Show("Kayıt Başarılı");
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen boş yerleri doldurun");
            }
        }

        private void FormYeniKayit_Load(object sender, EventArgs e)
        {

        }

        private void FormYeniKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormHastalar hastalarform = new FormHastalar();
            hastalarform.Show();
            this.Hide();
        }
    }
}








