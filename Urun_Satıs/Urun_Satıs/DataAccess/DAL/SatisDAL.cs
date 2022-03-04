using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urun_Satıs.DataAccess.BaglantiDAL;
using Urun_Satıs.Entity;

namespace Urun_Satıs.DataAccess.DAL
{
    class SatisDAL
    {
        public List<Urun> GetAll(string kosulCumlesi = "")
        {
            List<Urun> satislar = new List<Urun>();
            try
            {
                //Buraya yazacağımız işlmeleri yapmayı dene, sorun yoksa çalıştır.
                using (SqlCommand command = new SqlCommand($"SELECT * FROM tblUrunler {kosulCumlesi}", Baglanti.BaglantiNesnesi))
                {
                    //Using satrında yaratılan command adlı nesne, sadece
                    //bu scopeda yaşayacak. Bu scope dışında yok olmuş olacak.
                    //Bu nesnenin yok edilmesini Garbage Collector'ün
                    //insiyatifine bırakmamış olduk.
                    Baglanti.Ac();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())//geri dönen değerlerin hepsine bakmamızı sağlıyor
                        {
                            Urun satis = new Urun
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                UrunAd = reader["UrunAd"].ToString(),
                                StokMiktari = Convert.ToInt32(reader["StokMiktari"])
                            };
                            satislar.Add(satis);
                        }
                    }
                }
                return satislar;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Baglanti.Ac();
            }
        }
        public bool Insert(Satis satis)
        {

            string sorguCumlesi =
                $"INSERT INTO tblSatislar (SatisTarihi,UrunID,SatisAdedi) VALUES (@p1,@p2,@p3)";
            try
            {
                using (SqlCommand command = new SqlCommand(sorguCumlesi, Baglanti.BaglantiNesnesi))
                {
                    command.Parameters.AddWithValue("@p1", satis.SatisTarihi);
                    command.Parameters.AddWithValue("@p2", satis.UrunID);
                    command.Parameters.AddWithValue("@p3", satis.SatisAdedi);
                    Baglanti.Ac();
                    command.ExecuteNonQuery();
                }
                return true;//Kayıt başarılı anlamında
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;//Kayıt başarısız anlamında
            }
            finally
            {
                Baglanti.Kapa();
            }
        }
        public bool Update(Satis satis)
        {
            bool result = false;

            string sorguCumlesi =
            $"UPDATE tblUrunler SET StokMiktari =(StokMiktari-@p1) WHERE ID = @p2";
            try
            {
                using (SqlCommand command = new SqlCommand(sorguCumlesi, Baglanti.BaglantiNesnesi))
                {
                    command.Parameters.AddWithValue("@p1", satis.SatisAdedi);
                    command.Parameters.AddWithValue("@p2",  satis.UrunID);
                    Baglanti.Ac();
                    command.ExecuteNonQuery();
                }
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            finally
            {
                Baglanti.Kapa();
            }
            return result;

        }

    }
}


