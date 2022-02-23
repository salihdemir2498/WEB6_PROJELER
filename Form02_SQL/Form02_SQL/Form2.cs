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
    public partial class Form2 : Form
    {
        SqlConnection baglanti;
        string baglantiCumlesi = "";
        string sorguCumlesi = "";

        public Form2()
        {
            InitializeComponent();
        }

        void VerileriCek()
        {
            baglantiCumlesi = (@"Server=DESKTOP-4JE8ADO\SQLEXPRESS; Database=Sirket100; User=sa; Pwd=123");
            baglanti = new SqlConnection(baglantiCumlesi);
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM tblDepartman";
            komut.Connection = baglanti;
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                //Her satırı almak için gerekli kodları yazacağız
                int ID = (int)dr["ID"];
                string departmanAd = (string)dr["Ad"];    //.ToString()  
                lstDepartman.Items.Add($"{ID}\t{departmanAd}");

            }
            baglanti.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            VerileriCek();
        }
    }
}
