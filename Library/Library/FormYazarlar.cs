using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormYazarlar : Form
    {
        string sorguCumlesi;
        VeriTabani vt = new VeriTabani();
        public FormYazarlar()
        {
            InitializeComponent();
        }

        private void FormYazarlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna formAna = new FormAna();
            formAna.Show();
            this.Hide();
        }
        void Doldur()
        {
            sorguCumlesi = "SELECT * FROM tblYazarlar";
            dgvYazarlar.DataSource = vt.KayitListele(sorguCumlesi);
        }

        private void FormYazarlar_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void dgvYazarlar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgvYazarlar.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvYazarlar.CurrentRow.Cells[2].Value.ToString();
            cmbCinsiyet.Text = dgvYazarlar.CurrentRow.Cells[3].Value.ToString();
            dtpDogumTarih.Text = dgvYazarlar.CurrentRow.Cells[4].Value.ToString();
            txtTel.Text = dgvYazarlar.CurrentRow.Cells[5].Value.ToString();
            txtMail.Text = dgvYazarlar.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string cinsiyet = "";
            if (cmbCinsiyet.Text == "Kadın")
            {
                cinsiyet = "K";
            }
            else
            {
                cinsiyet = "E";
            }
            sorguCumlesi = $"INSERT INTO tblYazarlar VALUES ('{txtAd.Text}','{txtSoyad.Text}','{cinsiyet}','{dtpDogumTarih.Text}','{txtTel.Text}','{txtMail.Text}')";
            vt.Islem(sorguCumlesi);
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string ID = dgvYazarlar.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"DELETE tblYazarlar WHERE ID={ID}";
            vt.Islem(sorguCumlesi);
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string ID = dgvYazarlar.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"UPDATE tblYazarlar SET YazarAd='{txtAd.Text}',YazarSoyad='{txtSoyad.Text}',YazarCinsiyet='{cmbCinsiyet.Text}',YazarDogumTarihi='{dtpDogumTarih.Text}',YazarTel='{txtTel.Text}',YazarMail='{txtMail.Text}' WHERE ID='{ID}'";
            vt.Islem(sorguCumlesi);
            Doldur();
        }
    }
}
