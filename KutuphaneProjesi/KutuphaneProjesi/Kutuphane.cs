using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    class Kutuphane
    {
        public class Turler //tblTurler tablosu için
        {
            private int id;

            public int ID //ID alanı
            {
                get { return id; } //set i sildik çünkü ID değerini sadece okuyucaz
            }
            public string TurAd { get; set; } //TurAd alanı

        }

        public class YayinEvleri //tblYayinevleri tablosu için
        {
            private int id;

            public int ID
            {
                get { return id; }
            }
            public string Ad { get; set; }
            public string Adres { get; set; }
            public string Tel { get; set; }

        }

        public class Kisiler
        {
            private int id;

            public int MyProperty
            {
                get { return id; }
            }
            public string AdSoyad { get; set; }
            public string Cinsiyet { get; set; }
            public DateTime DogumTarihi { get; set; }
            public string Tel { get; set; }
            public string Mail { get; set; }

        }
        public class Uyeler : Kisiler
        {
            public enum UTip
            {
                Standart,
                Elit
            }
            public enum EDTip
            {
                İlkokulMezunu,
                OrtaokulMezunu,
                LiseMezunu,
                ÜniversiteMezunu,
                Ogrenci

            }
            public DateTime UyelikTarihi { get; set; }
            public UTip UyelikTipi { get; set; }
            public string TcNo { get; set; }
            public string Meslek { get; set; }
            public EDTip EgitimDurumu { get; set; } //Daha sonra revize edilebilir.
        }

        public class Yazarlar : Kisiler
        {
            public int TurID { get; set; } //YAZARIN ön plana çıktığı tür bilgisi
        }
    }
}



