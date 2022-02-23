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
    public partial class FormBolumler : Form
    {
        string sorguCumlesi;
        VeriTabani vt = new VeriTabani();
        public FormBolumler()
        {
            InitializeComponent();
        }

        void Tazele()
        {
            sorguCumlesi = "SELECT * FROM tblBolumler";
            dgvBolumler.DataSource = vt.KayitListele(sorguCumlesi);
        }
        private void FormBolumler_Load(object sender, EventArgs e)
        {
            Tazele();
        }

        private void dgvBolumler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBolumAd.Text = dgvBolumler.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string id= dgvBolumler.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"UPDATE tblBolumler SET BolumAd='{txtBolumAd.Text}' WHERE ID={id}";
            vt.Islem(sorguCumlesi);
            Tazele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string id = dgvBolumler.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"DELETE tblBolumler WHERE ID={id}";
            vt.Islem(sorguCumlesi);
            Tazele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dgvBolumler.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"INSERT INTO tblBolumler VALUES ('{txtBolumAd.Text}')";
            vt.Islem(sorguCumlesi);
            Tazele();
            
        }

        private void txtBolumAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                txtBolumAd.Clear();

            }
        }

        private void FormBolumler_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna formAna = new FormAna();
            formAna.Show();
            this.Hide();
        }
    }
}

