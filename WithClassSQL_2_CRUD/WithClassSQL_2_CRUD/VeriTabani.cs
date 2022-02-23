using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithClassSQL_2_CRUD
{
    class VeriTabani
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adaptor;
        DataTable dt;
        //string sorguCumlesi;
        //İlk olarak bir veritabanı bağlantısı
        //yapacak metot hazırlayalım.
        public SqlConnection Baglan()
        {
            string baglantiCumlesi = @"Server=DESKTOP-4JE8ADO\SQLEXPRESS; Database=sHastane; User=sa; Pwd=123";
            baglanti = new SqlConnection(baglantiCumlesi);
            if (baglanti.State == ConnectionState.Closed) //state durumunu tutar,açık mı kapalımı
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
        public void Islem(string sorguCumlesi)
        {
            komut = new SqlCommand(sorguCumlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }
        //public void Ekle(string sorguCumlesi)
        //{
        //    komut = new SqlCommand(sorguCumlesi, Baglan());
        //    komut.ExecuteNonQuery();
        //    Kapat();
        //}

        //public void Duzelt(string sorguCumlesi)
        //{
            
        //    komut = new SqlCommand(sorguCumlesi, Baglan());
        //    komut.ExecuteNonQuery();
        //    Kapat();
          
        //}

        //public void Sil(string sorguCumlesi)
        //{
        //    komut = new SqlCommand(sorguCumlesi, Baglan());
        //    komut.ExecuteNonQuery();
        //    Kapat();
        //}

        public bool KontrolEt(params string[] e)
        {
            bool donus = true;
            foreach (var item in e)
            {
                if (item=="")
                {
                    donus = false;
                    break;
                }
            }
            return donus;
        }

    }
}




