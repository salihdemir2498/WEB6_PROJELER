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

namespace KutuphaneProjesi
{
    public partial class FormKutuphane : Form
    {
        VeriTabani vt = new VeriTabani();
        public FormKutuphane()
        {
            InitializeComponent();
        }
        private void FormKutuphane_Load(object sender, EventArgs e)
        {
            pnlTeslimTarihi.Visible = false;

        }

        private void btnKitapTurYeni_Click(object sender, EventArgs e)
        {
            Turler yeniTur = new Turler();
            yeniTur.TurAd = txtKitaptur.Text;
            string sorguCumlesi = $"INSERT INTO tblTurler VALUES (@turAd)"; //böyle yazmamızın nedeni hackerlara karşı korunmak
            vt.TurEkle(sorguCumlesi, yeniTur.TurAd);
        }

        private void btnYeniKitap_Click(object sender, EventArgs e)
        {

            Kitaplar yeniKitap = new Kitaplar();
            yeniKitap.ISBN = txtISBN.Text;
            yeniKitap.Ad = txtKitapAdi.Text;
            yeniKitap.SayfaSayisi = Convert.ToInt32(txtKitapSayfaSayisi.Text);
            yeniKitap.Stok = Convert.ToInt32(txtStok.Text);

            List<string> gonderilecek = new List<string>();
            gonderilecek.Add(yeniKitap.ISBN);
            gonderilecek.Add(yeniKitap.Ad);
            gonderilecek.Add(yeniKitap.SayfaSayisi.ToString());
            gonderilecek.Add(yeniKitap.Stok.ToString());

            string sorguCumlesi = $"INSERT INTO tblKitaplar (ISBN,Ad,SayfaSayisi,Stok) VALUES (@p1,@p2,@p3,@p4)"; //böyle yazmamızın nedeni hackerlara karşı korunmak
            vt.KitapEkle(sorguCumlesi, gonderilecek);
        }

        private void btnYayineviEkle_Click(object sender, EventArgs e)
        {
            YayinEvleri yeniYayinevi = new YayinEvleri();
            yeniYayinevi.Ad = txtYayineviAdi.Text;
            yeniYayinevi.Adres = txtYayineviAdres.Text;
            yeniYayinevi.Tel = txtYayineviTel.Text;

            List<string> gonder = new List<string>();
            gonder.Add(yeniYayinevi.Ad);
            gonder.Add(yeniYayinevi.Adres);
            gonder.Add(yeniYayinevi.Tel);

            string sorguCumlesi = $"INSERT INTO tblYayinevleri (AdSoyad,Adres,Tel) VALUES (@p1,@p2,@p3)"; //böyle yazmamızın nedeni hackerlara karşı korunmak
            vt.YayineviEkle(sorguCumlesi, gonder);
        }
    }
}
