using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urun_Satıs.Entity
{
    class Satis
    {
        public int ID { get; set; }
        public DateTime SatisTarihi { get; set; }
        public int UrunID { get; set; }
        public int SatisAdedi { get; set; }

    }
}
