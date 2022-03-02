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
        public DataTable dt;
        SqlConnection baglanti;
        SqlDataAdapter adapter;
        string sorguCumlesi;
        string baglantiCumlesi;
        //DataTable dt;
        public string TableName { get; set; }
        public VeriTabani()
        {
            baglanti=Yarat();
            Ac();
        }
        
        SqlConnection Yarat()
        {
            baglantiCumlesi = @"Server=DESKTOP-4JE8ADO\SQLEXPRESS; Database=sKutuphane; User=sa; Pwd=123";
            baglanti = new SqlConnection(baglantiCumlesi);
            
            return baglanti;
        }
        void Ac()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        void Kapat()
        {
            if (baglanti.State==ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        

        /// <summary>
        /// Kayıt listeleme işlemi için kullanılır.
        /// </summary>
        public void Islem()
        {
           
            sorguCumlesi = $"SELECT * FROM {TableName}";
            adapter = new SqlDataAdapter(sorguCumlesi,Yarat());
            dt=new DataTable();
            adapter.Fill(dt);
        }
        /// <summary>
        /// Verilen ID' ye göre silme işlemi yapar ama gerçekte silmez.
        /// İlgili kaydın iptal kolonuna true yazar.
        /// </summary>
        /// <param name="ID"></param>
        public void Islem(int ID)
        {
            Ac();
            sorguCumlesi = $"UPDATE {TableName} SET Iptal=1 WHERE ID={ID}"; //1 true 0 false
            SqlCommand komut = new SqlCommand(sorguCumlesi, baglanti);
            komut.ExecuteNonQuery();
            Kapat();
        }
        public void Islem(Odunc yeniOdunc)
        {
            Ac();
            sorguCumlesi = $"INSERT INTO {TableName} (UyeID,KitapISBN,VerilisTarihi,Iptal) VALUES (@uyeID,@kitapISBN,@verilisTarihi,@iptal)";
            SqlCommand komut = new SqlCommand(sorguCumlesi,baglanti);
            komut.Parameters.AddWithValue("@uyeID",yeniOdunc.UyeID);
            komut.Parameters.AddWithValue("@kitapISBN", yeniOdunc.KitapISBN);
            komut.Parameters.AddWithValue("@verilisTarihi", yeniOdunc.VerilisTarihi.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@iptal", yeniOdunc.Iptal);
            komut.ExecuteNonQuery();
            Kapat();
        }
    }
}
