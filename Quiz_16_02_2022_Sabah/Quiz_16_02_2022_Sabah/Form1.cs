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

namespace Quiz_16_02_2022_Sabah
{
    //DESKTOP-4JE8ADO\SQLEXPRESS
    public partial class Form1 : Form
    {
        string baglantiCumlesi = @"Server=DESKTOP-4JE8ADO\SQLEXPRESS; Database=sRehber; User=sa; Pwd=123";
        string sorguCumlesi;
        SqlConnection baglanti;
        DataTable dt;
        SqlDataAdapter adapter;

        public Form1()
        {
            InitializeComponent();
        }
        void Doldur()
        {
            sorguCumlesi = "SELECT * FROM tblKisiler";
            baglanti = new SqlConnection(baglantiCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesi,baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
            

