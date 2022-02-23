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
    public partial class FormYayinevleri : Form
    {
        string sorguCumlesi;
        VeriTabani vt = new VeriTabani();
        public FormYayinevleri()
        {
            InitializeComponent();
        }

        private void FormYayinevleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna formAna = new FormAna();
            formAna.Show();
            this.Hide();
        }
        void Doldur()
        {
            sorguCumlesi = "SELECT * FROM tblYayinevleri";
            dgvYayınEvleri.DataSource = vt.KayitListele(sorguCumlesi);
        }
        private void FormYayinevleri_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sorguCumlesi = $"INSERT INTO tblYayinevleri VALUES ('{txtAd.Text}','{txtAdres.Text}','{txtTel.Text}')";
            vt.Islem(sorguCumlesi);
            Doldur();
        }

        private void dgvYayınEvleri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgvYayınEvleri.CurrentRow.Cells[1].Value.ToString();
            txtAdres.Text = dgvYayınEvleri.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = dgvYayınEvleri.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string ID = dgvYayınEvleri.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"DELETE tblYayinevleri WHERE ID={ID}";
            vt.Islem(sorguCumlesi);
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string ID = dgvYayınEvleri.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"UPDATE tblYayinevleri SET YayineviAd='{txtAd.Text}', YayıneviAdres='{txtAdres.Text}', YayıneviTel='{txtTel.Text}' WHERE ID='{ID}'";
            vt.Islem(sorguCumlesi);
            Doldur();
        }
    }
}
