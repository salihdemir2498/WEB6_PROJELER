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

namespace Form02_SQL
{
    public partial class Form3 : Form
    {
        string baglantiCumlesi = "";
        string sorguCumlesi = "";
        public Form3()
        {
            InitializeComponent();
        }
        void DataGridViewDoldur() 
        {
            baglantiCumlesi = @"Server=DESKTOP-4JE8ADO\SQLEXPRESS; Database=Sirket100; User=sa; Pwd=123";
            sorguCumlesi = "SELECT * FROM tblPersonel";
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            SqlDataAdapter adapter = new SqlDataAdapter(sorguCumlesi,baglanti); //open ve close 'ı arka planda yapar data adapter ama ınsert veya update gibi komutlarda open ve close yapmalıyız.
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvPersonel.DataSource = dt;
            dgvPersonel.Columns["ID"].Visible = false;
            dgvPersonel.Columns[5].Visible = false;
            dgvPersonel.Columns[7].Visible = false;
            dgvPersonel.Columns[8].Visible = false;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataGridViewDoldur();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
