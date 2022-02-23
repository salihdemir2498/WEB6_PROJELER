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
    public partial class FormUyeler : Form
    {
        string sorguCumlesi;
        VeriTabani vt = new VeriTabani();
        public FormUyeler()
        {
            InitializeComponent();
        }

        private void FormUyeler_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna formAna = new FormAna();
            formAna.Show();
            this.Hide();
        }
        void Tazele()
        {
            sorguCumlesi = "SELECT * FROM tblUyeler";
            dgvUyeler.DataSource = vt.KayitListele(sorguCumlesi);

        }
        private void FormUyeler_Load(object sender, EventArgs e)
        {
            Tazele();
        }

        private void dgvUyeler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text=dgvUyeler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvUyeler.CurrentRow.Cells[2].Value.ToString();
            txtTC.Text = dgvUyeler.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dgvUyeler.CurrentRow.Cells[4].Value.ToString();
            txtMail.Text = dgvUyeler.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //string ID = dgvUyeler.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"INSERT INTO tblUyeler VALUES ('{txtAd.Text}','{txtSoyad.Text}','{txtTC.Text}','{txtTel.Text}','{txtMail.Text}')";
            vt.Islem(sorguCumlesi);
            Tazele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string ID = dgvUyeler.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"DELETE tblUyeler WHERE ID={ID}";
            vt.Islem(sorguCumlesi);
            Tazele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string ID = dgvUyeler.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"UPDATE tblUyeler SET UyeAd='{txtAd.Text}',UyeSoyad='{txtSoyad.Text}',UyeTC='{txtTC.Text}',UyeTel='{txtTel.Text}',UyeMail='{txtMail.Text}' WHERE ID='{ID}'";
            vt.Islem(sorguCumlesi);
            Tazele();
        }
    }
}
