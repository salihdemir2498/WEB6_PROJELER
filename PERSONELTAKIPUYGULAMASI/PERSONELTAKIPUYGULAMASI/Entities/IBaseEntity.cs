using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSONELTAKIPUYGULAMASI.Entities
{
    interface IBaseEntity //Public felan yazılmaz interfacelere
    {
        int ID { get; set; }
        string Ad { get; set; }
    }
}
