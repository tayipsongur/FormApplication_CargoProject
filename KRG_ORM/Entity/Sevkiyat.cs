using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRG_ORM.Entity
{
   public class Sevkiyat
    {
        public int SevkiyatID { get; set; }
        public string SevkiyatAdi { get; set; }

        public string SevkAlımNoktası { get; set; }
        public string SevkUlasimNoktası { get; set; }
        public int Mesafe { get; set; }

        public decimal MesafeTutar { get; set; }
        public int AracID { get; set; }

    }
}
