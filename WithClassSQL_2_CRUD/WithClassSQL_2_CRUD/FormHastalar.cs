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

namespace WithClassSQL_2_CRUD
{
    public partial class FormHastalar : Form
    {
        VeriTabani vt = new VeriTabani();
        string sorguCumlesi;
        public FormHastalar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Goster();
        }
        string ID;
        void Goster()
        {
            ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text == "Kadın" ? "K" : "E";
            sorguCumlesi = $"UPDATE tblHastalar SET TcNo='{txtTc.Text}', Ad='{txtAd.Text}', Soyad='{txtSoyad.Text}', Cinsiyet='{cinsiyet}',Adres='{txtAdres.Text}',Telefon='{txtTelefon.Text}',Mail='{txtMail.Text}' WHERE ID='{dataGridView1.CurrentRow.Cells[0].Value.ToString()}'";
            vt.Islem(sorguCumlesi);
            Doldur();
        }

        void Doldur()
        {
            sorguCumlesi = $"SELECT * FROM tblHastalar";
            dataGridView1.DataSource = vt.KayitListele(sorguCumlesi);
        }

        private void FormDuzeltme_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void FormDuzeltme_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna frmYeni = new FormAna();
            frmYeni.Show();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string cinsiyet = cmbCinsiyet.Text == "Kadın" ? "K" : "E";
            sorguCumlesi = $"DELETE tblHastalar Where ID={dataGridView1.CurrentRow.Cells[0].Value.ToString()}";
            vt.Islem(sorguCumlesi);
            Doldur();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            FormYeniKayit frmYeni = new FormYeniKayit();
            frmYeni.Show();
            this.Hide();
        }
    }
}






