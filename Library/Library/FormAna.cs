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
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        private void btnTurler_Click(object sender, EventArgs e)
        {
            FormTurler formTurler = new FormTurler();
            formTurler.Show();
            this.Hide();
        }

        private void btnUyeler_Click(object sender, EventArgs e)
        {
            FormUyeler formUyeler = new FormUyeler();
            formUyeler.Show();
            this.Hide();
        }

        private void btnYazarlar_Click(object sender, EventArgs e)
        {
            FormYazarlar formYazarlar = new FormYazarlar();
            formYazarlar.Show();
            this.Hide();
        }

        private void btnYayinevleri_Click(object sender, EventArgs e)
        {
            FormYayinevleri formYayinevleri = new FormYayinevleri();
            formYayinevleri.Show();
            this.Hide();
        }

        private void btnKitaplar_Click(object sender, EventArgs e)
        {
            FormKitaplar formYayinevleri = new FormKitaplar();
            formYayinevleri.Show();
            this.Hide();
        }

        private void FormAna_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void FormAna_Load(object sender, EventArgs e)
        {

        }
    }
}
