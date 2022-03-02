using PERSONELTAKIPUYGULAMASI.DataAccess;
using PERSONELTAKIPUYGULAMASI.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERSONELTAKIPUYGULAMASI
{
    public partial class FormAna : Form
    {
        int secilenID = 0;
        string orjinalPersonelNo = string.Empty;
        CalisanDAL calisanDAL = new CalisanDAL();
        Calisan calisan = null;
        //string kosulCumlesi = "WHERE Durumu='Aktif'";
        public FormAna()
        {
            InitializeComponent();
        }
        void Refresh()
        {
            dgvCalisanlar.DataSource = calisanDAL.GetAll();  //(kosulCumlesi) yazarsak sadece aktifler gelir

        }
        private void FormAna_Load(object sender, EventArgs e)
        {
            Refresh();
            Aktar();

        }
        void ClearTools()
        {
            foreach (Control control in pnlAraclar.Controls)
            {
                if (control.GetType() != typeof(Label))
                {
                    control.Text = string.Empty;
                }
            }
            dtpDogumTarihi.Format = DateTimePickerFormat.Custom;
            dtpDogumTarihi.CustomFormat = " ";
            dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Custom;
            dtpIseBaslamaTarihi.CustomFormat = " ";
            txtAd.Focus();
            Refresh();
            Cancel();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearTools();
        }

        private void dtpDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpDogumTarihi.Format = DateTimePickerFormat.Long;
        }

        private void dtpIseBaslamaTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Long;
        }

        void Aktar()
        {
            try
            {
                //orjinalPersonelNo = dgvCalisanlar.SelectedRows[0].Cells[4].Value.ToString();
                secilenID = Convert.ToInt32(dgvCalisanlar.SelectedRows[0].Cells[0].Value);
                string Ad = dgvCalisanlar.SelectedRows[0].Cells[1].Value.ToString();
                string Soyad = dgvCalisanlar.SelectedRows[0].Cells[2].Value.ToString();
                string TcNo = dgvCalisanlar.SelectedRows[0].Cells[3].Value.ToString();
                string PersonelNo = dgvCalisanlar.SelectedRows[0].Cells[4].Value.ToString();
                string IseBaslamaTarihi = dgvCalisanlar.SelectedRows[0].Cells[5].Value.ToString();
                string DogumTarihi = dgvCalisanlar.SelectedRows[0].Cells[6].Value.ToString();
                string Departman = dgvCalisanlar.SelectedRows[0].Cells[7].Value.ToString();
                string Unvan = dgvCalisanlar.SelectedRows[0].Cells[8].Value.ToString();
                string Durumu = dgvCalisanlar.SelectedRows[0].Cells[9].Value.ToString();
                txtAd.Text = Ad;
                txtSoyad.Text = Soyad;
                txtTcNo.Text = TcNo;
                orjinalPersonelNo=txtPersonelNo.Text = PersonelNo;
                dtpDogumTarihi.Format = DateTimePickerFormat.Long;
                dtpDogumTarihi.Text = DogumTarihi;
                dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Long;
                dtpIseBaslamaTarihi.Text = IseBaslamaTarihi;
                cmbDepartman.Text = Departman;
                cmbDurumu.Text = Durumu;
                cmbUnvan.Text = Unvan;
            }
            catch (Exception)
            {

            }

        }
        private void dgvCalisanlar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }

        bool BlankControl()
        {
            bool result = true; //başlangıçta true yani hepsi dolu kabul ediyorum.
            foreach (Control control in pnlAraclar.Controls)
            {
                if (control.Text == string.Empty || control.Text == " ")
                {
                    result = false;
                    break; //bir boşluk varsa direk döngüden çık
                }
            }
            return result;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!BlankControl()) //BlankControl() == false
            {
                MessageBox.Show("Lütfen tüm alnları doldurunuz.");
            }
            else
            {
                calisan = new Calisan
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    TcNo = txtTcNo.Text,
                    PersonelNo = txtPersonelNo.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    IseBaslamaTarihi = dtpIseBaslamaTarihi.Value,
                    Departman = cmbDepartman.SelectedItem.ToString(),
                    Unvan = cmbUnvan.SelectedItem.ToString(),
                    Durumu = cmbDurumu.SelectedItem.ToString()
                };
                bool result = calisanDAL.Insert(calisan);
                if (result) //result=true
                {
                    Refresh();
                    MessageBox.Show("Kayıt Başarıyla Gerçekleştiridi.");
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenID == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz!");
            }
            else
            {
                DialogResult answer = MessageBox.Show("Seçilen Kayıt silinecektir.!\n Emin Misiniz?", "DİKKAT!", MessageBoxButtons.YesNo); //Kullanıcıdan alacağımız cevbı tutar yes veya no
                if (answer == DialogResult.Yes)
                {
                    bool result = calisanDAL.Delete(secilenID);
                    if (result)
                    {
                        Refresh();
                        MessageBox.Show($"{secilenID} ID'li Silme işlemi gerçekleşmiştir.");
                    }
                    ClearTools();
                }
            }
        }
        void Cancel()
        {
            dgvCalisanlar.ClearSelection();
            secilenID = 0;
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Tablonuzdaki tüm komutlar silinecektir!\nEmin Misiniz?", "DİKKAT! TÜM KAYITLAR SİLİNECEKTİR", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                bool result = calisanDAL.Delete();//tüm kayıtları sil
                if (result)
                {
                    Refresh();
                    MessageBox.Show("Tüm kayıtlar silindi.\nGeçmiş olsun.");
                }
            }
            //Sadece seçili kayıtları silecek metodu yazın.
        }

        private void dgvCalisanlar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape) //Basılan tuş Escape ise
            {
                ClearTools();
            }
        }
        string CreateQueryString()
        {
            string queryString = string.Empty;
            List<string> alanlar = new List<string>();
            foreach (Control control in pnlAraclar.Controls)
            {
                if (control.Tag == null) continue; //Eğer label ise bir sonraki kontrole geç continue direk foreach döngüsüne geri gider
                //Eger o sırada kontrol ettiğimiz controlün içi boşşa bir sonraki kontrole geç
                if (string.IsNullOrEmpty(control.Text) || control.Text == " ") continue; //içi boş olanları eledik
                string fieldName = control.Tag.ToString(); //tag değerini aldık
                string value = string.Empty;
                if (control.GetType() == typeof(DateTimePicker)) //kontolümüz datetimepicker ise
                {
                    value = Convert.ToDateTime(control.Text).ToString("yyyy-MM-dd");
                    alanlar.Add($"{fieldName} = '{value}'");


                }
                else
                {
                    value = control.Text;
                    if (rdbBenzer.Checked)
                    {
                        alanlar.Add($"{fieldName} LIKE '%{value}%'");
                    }
                    else if (rdbBaslar.Checked)
                    {
                        alanlar.Add($"{fieldName} LIKE '{value}%'");

                    }
                    else
                    {
                        alanlar.Add($"{fieldName} = '{value}'");

                    }


                }
                //alanlar.Add($"{fieldName} = '{value}'");
            }
            if (alanlar.Count > 0)
            {
                queryString = $"WHERE {string.Join(" AND ", alanlar)}";
            }
            return queryString;
        }
        int sayac = 0;
        private void btnBul_Click(object sender, EventArgs e)
        {
            dgvCalisanlar.DataSource = calisanDAL.GetAll(CreateQueryString());
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            Calisan calisan = new Calisan();
            calisan = calisanDAL.Get(CreateQueryString());
            if (calisan != null)
            {
                txtAd.Text = calisan.Ad;
                txtSoyad.Text = calisan.Soyad;
                txtTcNo.Text = calisan.TcNo;
                txtPersonelNo.Text = calisan.PersonelNo;
                dtpDogumTarihi.Format = DateTimePickerFormat.Long;
                dtpDogumTarihi.Value = calisan.DogumTarihi;
                dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Long;
                dtpIseBaslamaTarihi.Value = calisan.IseBaslamaTarihi;
                cmbDepartman.Text = calisan.Departman;
                cmbDurumu.Text = calisan.Durumu;
                cmbUnvan.Text = calisan.Unvan;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(calisanDAL.Duplicate($"WHERE PersonelNo='{txtPersonelNo.Text}'").ToString());
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenID == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kaydı seçiniz!\nBöyle olmaz ki kardeşim");
            }
            else if (!BlankControl())
            {
                MessageBox.Show("Lütfen tüm alanları doldurun...");
            }
            else
            {
    
                calisan = new Calisan
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    TcNo = txtTcNo.Text,
                    PersonelNo = txtPersonelNo.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    IseBaslamaTarihi = dtpIseBaslamaTarihi.Value,
                    Departman = cmbDepartman.SelectedItem.ToString(),
                    Unvan = cmbUnvan.SelectedItem.ToString(),
                    Durumu = cmbDurumu.SelectedItem.ToString(),
                    ID = secilenID
                };
                bool result = calisanDAL.Update(calisan,orjinalPersonelNo);
                if (result) //RESULT=true
                {
                    Refresh();
                    MessageBox.Show("Güncellendiii");
                }
            }
        }
    }

}





