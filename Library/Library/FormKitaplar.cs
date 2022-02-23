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
    public partial class FormKitaplar : Form
    {
        VeriTabani vt = new VeriTabani();
        string sorguCumlesi;
        public FormKitaplar()
        {
            InitializeComponent();
        }
        void Doldur()
        {
            sorguCumlesi = $"SELECT * FROM tblKitaplar";
            dgvKitaplar.DataSource = vt.KayitListele(sorguCumlesi);
        }
        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void dgvKitaplar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtISBN.Text = dgvKitaplar.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dgvKitaplar.CurrentRow.Cells[1].Value.ToString();
            txtSySayisi.Text = dgvKitaplar.CurrentRow.Cells[2].Value.ToString();
            txtAdedi.Text = dgvKitaplar.CurrentRow.Cells[3].Value.ToString();
            txtTur.Text = dgvKitaplar.CurrentRow.Cells[4].Value.ToString();
            txtYazar.Text = dgvKitaplar.CurrentRow.Cells[5].Value.ToString();
            txtYayinevi.Text = dgvKitaplar.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sorguCumlesi = $"INSERT INTO tblKitaplar VALUES ('{txtISBN.Text}','{txtAd.Text}','{txtSySayisi.Text}'," +
                        $"'{txtAdedi.Text}','{txtTur.Text}','{txtYazar.Text}','{txtYayinevi.Text}')";
            vt.Islem(sorguCumlesi);
            Doldur();
        }

        private void FormKitaplar_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna formAna = new FormAna();
            formAna.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string ID = dgvKitaplar.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"DELETE tblKitaplar WHERE ISBN='{ID}'";
            vt.Islem(sorguCumlesi);
            Doldur();
        }
    }
}
