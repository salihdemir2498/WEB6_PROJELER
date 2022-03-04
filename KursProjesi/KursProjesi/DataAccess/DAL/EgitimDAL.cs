﻿using KursProjesi.DataAccess.BaglantiDAL;
using KursProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursProjesi.DataAccess.DAL
{
    public class EgitimDAL
    {
        //Temel olarak burada CRUD işlemlerini yazacaz.
        public List<Kurs> GetAll()
        {
            Kurs kurs = null;
            try
            {
                List<Kurs> kurslar = new List<Kurs>(); 
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM tblEgitimler",Baglanti.BaglantiNesnesi))
                {
                    Baglanti.Ac();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            kurs = new Kurs
                            {
                                ID = Convert.ToInt32(dr["ID"]),
                                Ad = dr["Ad"].ToString(),
                                Sorumlu = dr["Sorumlu"].ToString(),
                                BaslangicTarihi = Convert.ToDateTime(dr["BaşlangıcTarihi"]),
                                Sure = Convert.ToInt32(dr["Sure"])
                            };
                            kurslar.Add(kurs);
                        }
                    }
                }
                return kurslar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {

                Baglanti.Kapat();
            }
        }
    }
}
