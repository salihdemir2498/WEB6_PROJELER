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
    public partial class FormRandevu : Form
    {
        VeriTabani vt = new VeriTabani();
        public FormRandevu()
        {
            InitializeComponent();
        }
        void BolumDoldur()
        {
            cmbBolum.DataSource = vt.KayitListele("SELECT * FROM tblBolumler");
            cmbBolum.DisplayMember = "BolumAd";
            cmbBolum.ValueMember = "ID";

        }

        void DoktorDoldur()
        {
            string bolumID = cmbBolum.SelectedValue.ToString();
            string sorguCumlesi = $"SELECT * FROM tblDoktorlar WHERE BolumID='{bolumID}'";
            lstDoktorlar.DataSource = vt.KayitListele(sorguCumlesi);
            lstDoktorlar.DisplayMember = "AdSoyad";
            lstDoktorlar.ValueMember = "ID";
        }
        private void FormRandevu_Load(object sender, EventArgs e)
        {
            
            BolumDoldur();
            DoktorDoldur();
            HastalariDoldur();
            

        }
        void HastalariDoldur()
        {
            string sorguCumlesi = $"SELECT ID,Ad,Soyad FROM tblHastalar";
            dgvHastalar.DataSource = vt.KayitListele(sorguCumlesi);
        }


        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DoktorDoldur();
            }
            catch (Exception)
            {

            }

        }

        private void dgvHastalar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtArananHasta.Text = dgvHastalar.CurrentRow.Cells[1].Value.ToString() + " " + dgvHastalar.CurrentRow.Cells[2].Value.ToString();
        }

        //void RandevuDoldur()
        //{
        //    string sorguCumlesi = $"INSERT INTO tblRandevular VALUES ('{cmbBolum.Text}','{dtpTarih.Text}','{dtpSaat.Text}','{txtArananHasta.Text}','{lstDoktorlar.Text}')";
        //    vt.Islem(sorguCumlesi);
        //}
        void Kaydet()
        {
            try
            {
                string BolumID = cmbBolum.SelectedValue.ToString();
                string HastaID = dgvHastalar.CurrentRow.Cells[0].Value.ToString();
                string doktorID = lstDoktorlar.SelectedValue.ToString();
                string tarih = dtpTarih.Text;
                string saat = dtpSaat.Text;
                string sorguCumlesi = $"INSERT INTO tblRandevular VALUES ('{BolumID}','{doktorID}','{HastaID}','{tarih}','{saat}')";
                vt.Islem(sorguCumlesi);
                //MessageBox.Show("Tamamdır");
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string bolumad = cmbBolum.Text;//yukarıda value yaptık orada hangisi seçiliyse o gelsin dedik burada
            string hastaadsoyad = dgvHastalar.CurrentRow.Cells[1].Value.ToString() + 
                " " + dgvHastalar.CurrentRow.Cells[2].Value.ToString();
            string doktorad = lstDoktorlar.Text;
            string tarih = dtpTarih.Text;
            FormOnay formOnay = new FormOnay(bolumad, hastaadsoyad, doktorad, tarih);
            formOnay.Show();
            //Diğer formdan gelecek onaya göre kayıt yapılacak.
            Kaydet();
      
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtpTarih.Text);
        }

        private void FormRandevu_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna formAna = new FormAna();
            formAna.Show();
            this.Hide();
        }
    }
}

