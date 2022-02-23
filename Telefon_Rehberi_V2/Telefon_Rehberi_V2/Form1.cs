using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        private void btnYeni_Click(object sender, EventArgs e)
        {
            YeniKayitFormu yeni = new YeniKayitFormu();
            yeni.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnCikis.PerformClick();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            ListeFormu liste = new ListeFormu();
            liste.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
