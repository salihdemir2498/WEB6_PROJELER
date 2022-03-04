using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProjesi.DataAccess.BaglantiDAL
{
    public static class Baglanti //static tek bir kere çalıştırır
    {
        private static SqlConnection baglantiNesnesi;

        public static SqlConnection BaglantiNesnesi
        {
            get
            {
                if (baglantiNesnesi == null)
                {
                    baglantiNesnesi = new SqlConnection(ConfigurationManager.ConnectionStrings["CsKurslar"].ConnectionString);
                }
                return baglantiNesnesi;
            }
            set
            {
                baglantiNesnesi = value;
            }
        }
        public static void Ac()
        {
            if (BaglantiNesnesi.State == ConnectionState.Closed) BaglantiNesnesi.Open();
            
        }
        public static void Kapat()
        {
            if (BaglantiNesnesi.State == ConnectionState.Open) BaglantiNesnesi.Close();

        }

    }
}
