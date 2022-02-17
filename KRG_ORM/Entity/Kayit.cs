using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRG_ORM.Entity
{
  public class Kayit
    {
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }

        public string Sifre { get; set; }
        public string Telefon { get; set; }

        public string Email { get; set; }

    }
}
