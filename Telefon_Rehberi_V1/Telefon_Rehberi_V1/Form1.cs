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

namespace Telefon_Rehberi_V1
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter adapter;
        DataTable dt;
        SqlCommand komut;
        string baglantiCumlesi = @"Server=DESKTOP-4JE8ADO\SQLEXPRESS; Database=sRehber; User=sa; Pwd=123";
        string sorguCumlesi;

        public Form1()
        {
            InitializeComponent();
        }
        void KisileriGetir()
        {
            sorguCumlesi = "SELECT * FROM tblKisiler";
            baglanti = new SqlConnection(baglantiCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesi,baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;
        }

        void Aktar()
        {
            //dgvKisiler üzerinde tıklandığında, yan tarafa ilgili kaydın değerlerini koy.
            lblId.Text = dgvKisiler.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dgvKisiler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvKisiler.CurrentRow.Cells[2].Value.ToString();
            if (dgvKisiler.CurrentRow.Cells[3].Value.ToString() == "K")
            {
                rdbKadin.Checked = true;
            }
            else
            {
                rdbErkek.Checked = true;
            }
            txtTel.Text = dgvKisiler.CurrentRow.Cells[4].Value.ToString();


        }
        void Duzelt()
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            char cinsiyet;
            if (rdbKadin.Checked==true)
            {
                cinsiyet = 'K';
            }
            else
            {
                cinsiyet = 'E';
            }
            string tel = txtTel.Text;
            string ID = lblId.Text;
            sorguCumlesi = $"UPDATE tblKisiler SET Ad = '{ad}', Soyad = '{soyad}', Cinsiyet = '{cinsiyet}',Telefon = '{tel}' WHERE ID = {ID}";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi,baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisileriGetir(); //tabloda anında değişikliği görmek için
        }
        void Sil()
        {
            string ID = lblId.Text;
            sorguCumlesi = $"DELETE FROM tblKisiler WHERE ID = {ID}";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisileriGetir(); //tabloda anında değişikliği görmek için

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KisileriGetir();
        }

        private void dgvKisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();

        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            Duzelt();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
            
        }
        void Temizle()
        {
            lblId.Text = "Yeni Kayıt";
            txtAd.ResetText();
            txtSoyad.ResetText();
            rdbKadin.Checked = true;
            txtTel.ResetText();
            txtAd.Focus();
        }
        void YeniKayıt()
        {
            if (btnYeni.Text == "Yeni")
            {
                btnYeni.Text = "Kaydet";
                Temizle();

            }
            else
            {
                btnYeni.Text = "Yeni";
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                char cinsiyet;
                if (rdbKadin.Checked == true)
                {
                    cinsiyet = 'K';
                }
                else
                {
                    cinsiyet = 'E';
                }
                string tel = txtTel.Text;
                
                sorguCumlesi = $"INSERT INTO tblKisiler VALUES ('{ad}','{soyad}','{cinsiyet}','{tel}')";
                baglanti = new SqlConnection(baglantiCumlesi);
                komut = new SqlCommand(sorguCumlesi,baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                KisileriGetir();
            }
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            YeniKayıt();
        }
        void Ara()
        {
            string aranan = txtAranan.Text;
            DataView dw = dt.DefaultView;
            dw.RowFilter = $"Ad LIKE '{aranan}%'";
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            Ara();
        }

        private void txtAranan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Ara();
            }
        }

        private void txtAranan_KeyUp(object sender, KeyEventArgs e)
        {
            Ara();
        }

        private void dgvKisiler_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }
    }
}
