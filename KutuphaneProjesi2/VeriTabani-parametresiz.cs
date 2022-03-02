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
        string sorguCumlesi;
        public VeriTabani() //Constructor Method
        {

        }
        //Bu overload kayıt listeleme yapacak
        public VeriTabani(string tabloAdi, params string[] sutunlar)
        {
            
            //string sorguCumlesi = $"SELECT {sutunlar} FROM {tabloAdi}";
            //foreach (var siradakiSutunAd in sutunlar)
            //{
            //        sutunMetni += siradakiSutunAd + ",";
            //}
            //sutunMetni = sutunMetni.Substring(1, sutunMetni.Length - 1);

            string sutunMetni = string.Join(",", sutunlar);
            sorguCumlesi = $"SELECT {sutunMetni} FROM {tabloAdi}";
        }




        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adaptor;
        DataTable dt;

        //İlk olarak bir veri tabanı bağlantısı yapacak
        //metot hazırlayalım
        public SqlConnection Baglan()
        {
            string server = @"DESKTOP-4JE8ADO\SQLEXPRESS"; //DESKTOP-5JA1DBH
            string baglantiCumlesi = $@"Server={server}; Database=sKutuphane; User=sa; Pwd=123";
            baglanti = new SqlConnection(baglantiCumlesi);
            if (baglanti.State== ConnectionState.Closed) //baglantı nesnesinde state isminde property varmış, connectionçclosed ise enum gibi
            {
                baglanti.Open(); //SqlConnection classından üretilen baglanti nesnesinin open adlı metotu çağırılıyo
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
        
        DataTable KayitListele() //private yaptık
        {
            adaptor = new SqlDataAdapter(sorguCumlesi,Baglan());
            dt = new DataTable();
            adaptor.Fill(dt);
            return dt;
            
        }

        public void Islem(string sorguCumlesi)
        {
            //Bu metot INSERT, UPDATE ve DELETE işlemlerini yapabilir.
            komut = new SqlCommand(sorguCumlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }

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

       

        


