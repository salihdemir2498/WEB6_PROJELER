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

namespace Telefon_Rehberi_V2
{
    public partial class ListeFormu : Form
    {
        string baglantiCumlesi = @"Server=DESKTOP-4JE8ADO\SQLEXPRESS; Database=sRehber; User=sa; Pwd=123";
        string sorguCumlesi;
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adapter;
        DataTable dt;
        public ListeFormu()
        {
            InitializeComponent();
        }

        private void ListeFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FormClosing kapat(x) tuşuna basınca ne olucak onu söylüyo.
            button1.PerformClick();
        }
        void Doldur()
        {
            baglanti = new SqlConnection(baglantiCumlesi);
            sorguCumlesi = "SELECT * FROM tblKisiler";
            adapter = new SqlDataAdapter(sorguCumlesi,baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;
            
        }
        private void ListeFormu_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        void Duzelt()
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string cinsiyet;
            if (cmbCinsiyet.Text=="Kadın")
            {
                cinsiyet = "K";
            }
            else
            {
                cinsiyet = "E";
            }
            string telefon = txtTelefon.Text;
            sorguCumlesi = $"UPDATE tblKisiler SET Ad ='{ad}',Soyad='{soyad}',Cinsiyet='{cinsiyet}',Telefon='{telefon}' WHERE ID='{dgvKisiler.CurrentRow.Cells[0].Value}' ";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi,baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Doldur();
        }
        void Aktar()
        {
            //dgvKisiler üzerinde tıklandığında, yan tarafa ilgili kaydın değerlerini koy.
            txtAd.Text = dgvKisiler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvKisiler.CurrentRow.Cells[2].Value.ToString();
            if (dgvKisiler.CurrentRow.Cells[3].Value.ToString() == "K")
            {
                cmbCinsiyet.Text = "Kadın";
            }
            else
            {
                cmbCinsiyet.Text = "Erkek";
            }
            txtTelefon.Text = dgvKisiler.CurrentRow.Cells[4].Value.ToString();


        }
        private void btnDüzelt_Click(object sender, EventArgs e)
        {
            Duzelt();
        }

        private void dgvKisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }
         void Sil()
        {
            sorguCumlesi = $"DELETE FROM tblKisiler WHERE ID = {dgvKisiler.CurrentRow.Cells[0].Value}";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
