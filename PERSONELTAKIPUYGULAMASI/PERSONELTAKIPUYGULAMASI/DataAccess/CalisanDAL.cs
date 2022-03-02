using PERSONELTAKIPUYGULAMASI.Entities;
using PERSONELTAKIPUYGULAMASI.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERSONELTAKIPUYGULAMASI.DataAccess
{
    class CalisanDAL
    {
        //Burada ise Data Access Layer hazırlıyoruz.
        //Yani Calisan entitiemizle ilgili CRUD vb. işlemlerimiz burada gerçekleştirilecek.

        /// <summary>
        /// Bu metot geriye içinde Calisan tipinde değerler barındıran bir
        /// List tipinde değer döndürecek.
        /// </summary>
        /// <param name="kosulCumlesi">
        /// Bu parametre boş bırakılırsa yani "" veya string.empty şeklinde
        /// kullanılırsa,tüm kayıtları dönderecek.Eğer buraya uygun bir 
        /// WHERE ifadesi yazılırsa koşula uygun kayıtları döndürecek.
        /// </param>
        /// <returns></returns>
        public List<Calisan> GetAll(string kosulCumlesi = "") //tümünü getir
        {
            List<Calisan> calisanlar = new List<Calisan>();
            try
            {
                //Buraya yazacağımız işlemleri dene, sorun yoksa çalıştır.
                using (SqlCommand command = new SqlCommand($"SELECT * FROM tblCalisanlar {kosulCumlesi}", SQLBaglanti.Baglanti))
                {
                    //Using satırında yaratılan command adlı nesne, sadece bu scope ta yaşayacak.Bu 
                    //scope dışında yok olmuş olacak.
                    //Bu nesnenin yok edilmesini Garbage Collector ' ün
                    //insiyatifine bırakmamış olduk.
                    SQLBaglanti.BaglantiAc();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) //geri dönen değerlerin hepsine bakmamızı sağlıyor.
                        {
                            Calisan calisan = new Calisan
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Ad = reader["Ad"].ToString(),
                                Soyad = reader["Soyad"].ToString(),
                                TcNo = reader["TcNo"].ToString(),
                                PersonelNo = reader["PersonelNo"].ToString(),
                                DogumTarihi = Convert.ToDateTime(reader["DogumTarihi"]),
                                IseBaslamaTarihi = Convert.ToDateTime(reader["IseBaslamaTarihi"]),
                                Departman = reader["Departman"].ToString(),
                                Unvan = reader["Unvan"].ToString(),
                                Durumu = reader["Durumu"].ToString()
                            };
                            calisanlar.Add(calisan);
                        }
                    }
                }
                return calisanlar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                SQLBaglanti.BaglantiKapat();
            }
        }
        public bool Insert(Calisan calisan)
        {
            if (Duplicate($"WHERE PersonelNo='{calisan.PersonelNo}'")==1)
            {
                MessageBox.Show("Bu personel No ile daha önce kayıt oluşturulmuş!\nLütfen yeniden deneyiniz...");
                return false;
            }
            else
            {
                string sorguCumlesi = $"INSERT INTO tblCalisanlar (Ad,Soyad,TcNo,PersonelNo,DogumTarihi,IseBaslamaTarihi,Departman," +
               $"Unvan,Durumu) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";
                try
                {
                    using (SqlCommand command = new SqlCommand(sorguCumlesi, SQLBaglanti.Baglanti))
                    {
                        command.Parameters.AddWithValue("@p1", calisan.Ad);
                        command.Parameters.AddWithValue("@p2", calisan.Soyad);
                        command.Parameters.AddWithValue("@p3", calisan.TcNo);
                        command.Parameters.AddWithValue("@p4", calisan.PersonelNo);
                        command.Parameters.AddWithValue("@p5", calisan.DogumTarihi);
                        command.Parameters.AddWithValue("@p6", calisan.IseBaslamaTarihi);
                        command.Parameters.AddWithValue("@p7", calisan.Departman);
                        command.Parameters.AddWithValue("@p8", calisan.Unvan);
                        command.Parameters.AddWithValue("@p9", calisan.Durumu);
                        SQLBaglanti.BaglantiAc();
                        command.ExecuteNonQuery();
                    }
                    return true;//Kayıt başarılı
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    SQLBaglanti.BaglantiKapat();
                }
            }
        }
        public bool Update(Calisan calisan,string orjinalPersonelNo)
        {
            bool result = false;
            short adet = 0;
            if(calisan.PersonelNo!=orjinalPersonelNo)
            {
                adet = Duplicate($"WHERE PersonelNo='{calisan.PersonelNo}'"); //1 tane bile kullanılmışmı ona baktık
            }
            if (adet == 1)
            {
                MessageBox.Show("Bu personel no daha önce kullanılmış");
                result = false;
            }
            else
            {
                string sorguCumlesi = $"UPDATE tblCalisanlar SET Ad=@p1, Soyad=@p2, TcNo=@p3, PersonelNo=@p4," +
                $"DogumTarihi=@p5, IseBaslamaTarihi=@p6, Departman=@p7, Unvan=@p8, Durumu=@p9 WHERE ID=@p10";
                try
                {
                    using (SqlCommand command = new SqlCommand(sorguCumlesi, SQLBaglanti.Baglanti))
                    {
                        command.Parameters.AddWithValue("@p1", calisan.Ad);
                        command.Parameters.AddWithValue("@p2", calisan.Soyad);
                        command.Parameters.AddWithValue("@p3", calisan.TcNo);
                        command.Parameters.AddWithValue("@p4", calisan.PersonelNo);
                        command.Parameters.AddWithValue("@p5", calisan.DogumTarihi);
                        command.Parameters.AddWithValue("@p6", calisan.IseBaslamaTarihi);
                        command.Parameters.AddWithValue("@p7", calisan.Departman);
                        command.Parameters.AddWithValue("@p8", calisan.Unvan);
                        command.Parameters.AddWithValue("@p9", calisan.Durumu);
                        command.Parameters.AddWithValue("@p10", calisan.ID);
                        SQLBaglanti.BaglantiAc();
                        command.ExecuteNonQuery();
                    }
                    result=true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    result=false;
                }
                finally
                {
                    SQLBaglanti.BaglantiKapat();
                }
            }
            return result;
            
        }
        public bool Delete(int id)
        {
            string sorguCumlesi = $"DELETE FROM tblCalisanlar WHERE ID = @p1";
            try
            {
                using (SqlCommand command = new SqlCommand(sorguCumlesi, SQLBaglanti.Baglanti))
                {
                    command.Parameters.AddWithValue("@p1", id);
                    SQLBaglanti.BaglantiAc();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                SQLBaglanti.BaglantiKapat();
            }
        }
        public bool Delete(string kosulCumlesi = "")
        {
            string sorguCumlesi = $"DELETE FROM tblCalisanlar {kosulCumlesi}";
            try
            {
                using (SqlCommand command = new SqlCommand(sorguCumlesi, SQLBaglanti.Baglanti))
                {
                    //command.Parameters.AddWithValue("@p1",kosulCumlesi);
                    SQLBaglanti.BaglantiAc();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                SQLBaglanti.BaglantiKapat();
            }
        }
        public Calisan Get(string kosulCumlesi)
        {
            Calisan calisan = null;
            try
            {
                int adet = 0;
                using (SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM tblCalisanlar {kosulCumlesi}", SQLBaglanti.Baglanti))
                {
                    SQLBaglanti.BaglantiAc();
                    adet = Convert.ToInt32(command.ExecuteScalar());
                    //SQLBaglanti.BaglantiKapat();
                }
                if (adet > 1)
                {
                    MessageBox.Show("Aradığınız kritere uygun çok sayıda kayıt var.\nLütfen kriterlerinizi daraltıp yeniden deneyiniz.");
                    return null;
                }
                else if (adet == 1)
                {
                    using (SqlCommand command = new SqlCommand($"SELECT * FROM tblCalisanlar {kosulCumlesi}", SQLBaglanti.Baglanti))
                    {
                        using (SqlDataReader okuyucu = command.ExecuteReader())
                        {
                            while (okuyucu.Read())
                            {
                                calisan = new Calisan
                                {
                                    ID = Convert.ToInt32(okuyucu["ID"]),
                                    Ad = okuyucu["Ad"].ToString(),
                                    Soyad = okuyucu["Soyad"].ToString(),
                                    TcNo = okuyucu["TcNo"].ToString(),
                                    PersonelNo = okuyucu["PersonelNo"].ToString(),
                                    DogumTarihi = Convert.ToDateTime(okuyucu["DogumTarihi"]),
                                    IseBaslamaTarihi = Convert.ToDateTime(okuyucu["IseBaslamaTarihi"]),
                                    Departman = okuyucu["Departman"].ToString(),
                                    Unvan = okuyucu["Unvan"].ToString(),
                                    Durumu = okuyucu["Durumu"].ToString()
                                };
                            }
                        }
                    }
                    return calisan;

                }
                else
                {
                    MessageBox.Show("Uygun kayıt bulunamadı yeniden deneyin.");
                    return null;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                SQLBaglanti.BaglantiKapat();

            }

        }
        public short Duplicate(string kosulCumlesi)
        {
            short adet = 0;
            try
            {
                using (SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM tblCalisanlar {kosulCumlesi}", SQLBaglanti.Baglanti))
                {
                    SQLBaglanti.BaglantiAc();
                    adet = Convert.ToInt16(command.ExecuteScalar());
                }
                return adet;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return adet;
            }
            finally
            {
                SQLBaglanti.BaglantiKapat();
            }
        }
    }
}

