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
    public partial class FormTurler : Form
    {
        string sorguCumlesi;
        VeriTabani vt = new VeriTabani();
        public FormTurler()
        {
            InitializeComponent();
        }

        private void FormTurler_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna formAna = new FormAna();
            formAna.Show();
            this.Hide();
        }

        void Tazele()
        {
            sorguCumlesi = "SELECT * FROM tblTurler";
            dgvTurler.DataSource = vt.KayitListele(sorguCumlesi);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
       
            sorguCumlesi = $"INSERT INTO tblTurler VALUES ('{txtAd.Text}')";
            vt.Islem(sorguCumlesi);
            Tazele();
        }

        private void dgvTurler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dgvTurler.CurrentRow.Cells[1].Value.ToString();
        }

        private void FormTurler_Load(object sender, EventArgs e)
        {
            Tazele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string ID = dgvTurler.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"DELETE tblTurler WHERE ID={ID}";
            vt.Islem(sorguCumlesi);
            Tazele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string ID = dgvTurler.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"UPDATE tblTurler SET TurAd='{txtAd.Text}' WHERE ID='{ID}'";
            vt.Islem(sorguCumlesi);
            Tazele();
        }

     
    }
}
