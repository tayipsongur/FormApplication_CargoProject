using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRG_ORM.Entity
{
   public class Müsteri
    {
        public int MusteriID { get; set; }
        public int SevkiyatID { get; set; }
        public string MusteriAdSoyad { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string OdemeDurum { get; set; }

    }
}
