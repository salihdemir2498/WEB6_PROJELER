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
    public partial class FormOnay : Form
    {
        string bolumad1;
        string hastaad1;
        string doktorad1;
        string tarih1;
        public FormOnay(string bolumad, string hastaad, string doktorad, string tarih)
        {
             bolumad1 = bolumad;
             hastaad1 = hastaad;
             doktorad1 = doktorad;
             tarih1 = tarih;
            InitializeComponent();
        }

        private void FormOnay_Load(object sender, EventArgs e)
        {
            label1.Text = bolumad1 + " " + hastaad1 + " " + doktorad1 + " " + tarih1;
        }
    }
}
