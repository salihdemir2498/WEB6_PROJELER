using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSONELTAKIPUYGULAMASI.Tools
{
    class SQLBaglanti
    {
       private static SqlConnection baglanti;

        public static SqlConnection Baglanti
        {
            get 
            {
                if (baglanti==null) //baglanti bossa baglantiyi açacak.Sadece 1 kez çalışır çünkü 1 kere açtıktan sonra baglanti null olmaz.
                {
                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["CsPersonel"].ConnectionString);
                }
                return baglanti; 
            }
            set { baglanti = value; }
        }
        public static void BaglantiAc()
        {
            if (Baglanti.State==ConnectionState.Closed)
            {
                Baglanti.Open();
            }
        }
        public static void BaglantiKapat()
        {
            if (Baglanti.State == ConnectionState.Open)
            {
                Baglanti.Close();
            }
        }

    }
}
