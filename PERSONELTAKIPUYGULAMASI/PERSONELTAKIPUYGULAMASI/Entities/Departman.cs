using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSONELTAKIPUYGULAMASI.Entities
{
    class Departman : IBaseEntity
    {
        public string Sorumlu { get; set; }
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Ad { get; set; }
    }
}
