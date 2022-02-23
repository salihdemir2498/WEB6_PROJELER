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

namespace WithClassSQL_2_CRUD
{
    public partial class FormAna : Form
    {


        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            System.Environment.Exit(0);
            
        }

        private void btnHastalar_Click(object sender, EventArgs e)
        {
            FormHastalar hastalarform = new FormHastalar();
            hastalarform.Show();
            this.Hide();
        }

        private void btnBolum_Click(object sender, EventArgs e)
        {
            FormBolumler bolumlerForm = new FormBolumler();
            bolumlerForm.Show();
            this.Hide();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {

        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            FormRandevu formRandevu = new FormRandevu();
            formRandevu.Show();
            this.Hide();
        }
    }
}
      