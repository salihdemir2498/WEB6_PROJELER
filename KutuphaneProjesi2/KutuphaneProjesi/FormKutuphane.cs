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
        void OduncRefresh()
        {
            vt.TableName = "tblOdunc";
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;
        }
        private void FormKutuphane_Load(object sender, EventArgs e)
        {
            //Ödünç listesini güncelliyor
            vt.TableName = "tblOdunc";
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;

            //üye listesini güncelliyor
            vt.TableName = "tblUyeler";
            vt.Islem();
            dgvUye.DataSource = vt.dt;
            for (int i = 0; i < dgvUye.Columns.Count; i++)
            {
                dgvUye.Columns[i].Visible = false;
            }
            dgvUye.Columns[1].Visible = true;
            dgvUye.Columns[0].Visible = true;

            //Kitap listesini güncelliyor
            vt.TableName = "tblKitaplar";
            vt.Islem();
            dgvKitap.DataSource = vt.dt;
            for (int i = 0; i < dgvKitap.Columns.Count; i++)
            {
                dgvKitap.Columns[i].Visible = false;
            }
            dgvKitap.Columns[1].Visible = true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dgvOdunc.CurrentRow.Cells[0].Value.ToString());
            vt.TableName = "tblOdunc";
            vt.Islem(ID);
            OduncRefresh();

        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            vt.TableName = "tblOdunc";
            Odunc yeniOdunc = new Odunc();
            yeniOdunc.UyeID = Convert.ToInt32(dgvUye.SelectedRows[0].Cells[0].Value.ToString());
            yeniOdunc.KitapISBN = dgvKitap.SelectedRows[0].Cells[0].Value.ToString();
            yeniOdunc.VerilisTarihi = dtpVerilisTarihi.Value; // nesne içine aktardık
            yeniOdunc.Iptal = false;
            vt.Islem(yeniOdunc);
            OduncRefresh();
        }

        private void dgvUye_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //txtUye.Text = dgvUye.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvKitap_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //txtKitap.Text = dgvKitap.CurrentRow.Cells[1].Value.ToString();

        }
        void Aktar()
        {
            int aranan = Convert.ToInt32(dgvOdunc.SelectedRows[0].Cells[1].Value.ToString());

            foreach (DataGridViewRow satir in dgvUye.Rows)
            {
                DataGridViewCell hucre = satir.Cells[0];
                if (Convert.ToInt32(hucre.Value.ToString())==aranan)
                {
                    satir.Selected = true;
                    break;
                }
            }
            int arananKitap = Convert.ToInt32(dgvOdunc.SelectedRows[0].Cells[2].Value.ToString());//kitapısbn den seçiyo
            foreach (DataGridViewRow satir in dgvKitap.Rows)
            {
                DataGridViewCell hucre = satir.Cells[0];
                if (Convert.ToInt32(hucre.Value.ToString()) == arananKitap)
                {
                    satir.Selected = true;
                    break;
                }
            }
           
        }
        private void dgvOdunc_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Aktar();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow seciliSatir in dgvOdunc.SelectedRows)
            {
                MessageBox.Show(seciliSatir.Cells[0].Value.ToString());
            }
        }
    }
}
