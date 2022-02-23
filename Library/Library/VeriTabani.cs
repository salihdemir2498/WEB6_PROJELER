using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class VeriTabani
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adaptor;
        DataTable dt;

        public SqlConnection baglan()
        {
           string baglantiCumlesi = @"Server=DESKTOP-4JE8ADO\SQLEXPRESS; Database=Kutuphane; User=sa; Pwd=123";
            baglanti = new SqlConnection(baglantiCumlesi);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            return baglanti;
        }
        public void kapat()
        {
            if (baglanti.State!=ConnectionState.Closed)
            {
                baglanti.Close();
            }
        }

        public DataTable KayitListele(string sorguCumlesi)
        {
            adaptor = new SqlDataAdapter(sorguCumlesi,baglan());
            dt = new DataTable();
            adaptor.Fill(dt);
            return dt;
        }

        public void Islem(string sorguCumlesi)
        {
            komut = new SqlCommand(sorguCumlesi,baglan());
            komut.ExecuteNonQuery();
            kapat();

        }
        
    }
}
