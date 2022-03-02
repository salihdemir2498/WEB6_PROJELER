using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    class VeriTabani
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adaptor;
        DataTable dt;

        string sorguCumlesi;
        //İlk olarak bir veri tabanı bağlantısı yapacak
        //metot hazırlayalım
        public SqlConnection Baglan()
        {
            string server = @"DESKTOP-4JE8ADO\SQLEXPRESS";
            //string server = @"DESKTOP-5JA1DBH";
            string baglantiCumlesi = $@"Server={server}; Database=sKutuphane; User=sa; Pwd=123";
            baglanti = new SqlConnection(baglantiCumlesi);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            return baglanti;
        }

        public void Kapat()
        {
            if (baglanti.State != ConnectionState.Closed)
            {
                baglanti.Close();
            }
        }

        public DataTable KayitListele(string sorguCumlesi)
        {
            adaptor = new SqlDataAdapter(sorguCumlesi, Baglan());
            dt = new DataTable();
            adaptor.Fill(dt);
            return dt;

        }

        public void TurEkle(string sorguCumlesi, string turAd) //tblTurler tablosu için
        {
            komut = new SqlCommand(sorguCumlesi, Baglan());
            komut.Parameters.AddWithValue("@turAd", turAd);//AddWithValue parametreye değer verir -- Add komutu ise parametre oluşturur
            komut.ExecuteNonQuery();
            Kapat();
        }
        public void KitapEkle(string sorguCumlesi, List<string> g)
        {

            //Böyle deneyeceğimmm
            komut = new SqlCommand(sorguCumlesi, Baglan());
            komut.Parameters.AddWithValue("@p1", g[0]);
            komut.Parameters.AddWithValue("@p2", g[1]);
            komut.Parameters.AddWithValue("@p3", g[2]);
            komut.Parameters.AddWithValue("@p4", g[3]);
            komut.ExecuteNonQuery();
            Kapat();


        }

        public void YayineviEkle(string sorguCumlesi, List<string> g)
        {
            komut = new SqlCommand(sorguCumlesi,Baglan());
            komut.Parameters.AddWithValue("@p1", g[0]);
            komut.Parameters.AddWithValue("@p2", g[1]);
            komut.Parameters.AddWithValue("@p3", g[2]);
            komut.ExecuteNonQuery();
            Kapat();


        }




        public bool KontrolEt(params string[] e)
        {
            bool donus = true;
            foreach (var item in e)
            {
                if (item == "")
                {
                    donus = false;
                    break;
                }
            }
            return donus;
        }
    }
}
