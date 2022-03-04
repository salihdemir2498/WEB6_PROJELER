using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urun_Satıs.Entity;

namespace Urun_Satıs.DataAccess.BaglantiDAL
{
    public static class Baglanti
    {
        private static SqlConnection baglantiNesnesi;

        public static SqlConnection BaglantiNesnesi
        {
            get
            {
                if (baglantiNesnesi == null)
                {
                    baglantiNesnesi = new SqlConnection(ConfigurationManager.ConnectionStrings["CsSatis"].ConnectionString);
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

        public static void Kapa()
        {
            if (BaglantiNesnesi.State == ConnectionState.Open) BaglantiNesnesi.Close();
        }
    }
}
