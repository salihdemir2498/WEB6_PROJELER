using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urun_Satıs.DataAccess.BaglantiDAL;
using Urun_Satıs.DataAccess.DAL;
using Urun_Satıs.Entity;

namespace Urun_Satıs
{
    public partial class FormAna : Form
    {
        SatisDAL satisDAL = new SatisDAL();
        Satis satis = null;
        public FormAna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbUrunAd.DataSource = satisDAL.GetAll();
            cmbUrunAd.ValueMember = "ID";
            cmbUrunAd.DisplayMember = "UrunAd"; 
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
                satis = new Satis
                {
                    SatisTarihi = dtpSatisTarih.Value,
                    UrunID = Convert.ToInt32(cmbUrunAd.SelectedValue.ToString()),
                    SatisAdedi = Convert.ToInt32(txtSatisAdedi.Text)
                };
                bool result = satisDAL.Insert(satis);
                if (result)
                {
                    Refresh();
                    MessageBox.Show("Kayıt işlemi başarıyla tamamlandı");
                }
                //satisDAL.Update(satis);
        }

        private void dtpSatisTarih_ValueChanged(object sender, EventArgs e)
        {
            dtpSatisTarih.Format = DateTimePickerFormat.Long;
        }
    }
}
