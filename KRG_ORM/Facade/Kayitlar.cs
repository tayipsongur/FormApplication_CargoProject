using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using KRG_ORM.Entity;

namespace KRG_ORM.Facade
{
   public class Kayitlar
    {
        public static bool KayitOl(Kayit kayit)
        {
            SqlCommand komut = new SqlCommand("KayıtOl", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("KullaniciAdi", kayit.KullaniciAdi);
            komut.Parameters.AddWithValue("Sifre", kayit.Sifre);
            komut.Parameters.AddWithValue("Telefon", kayit.Telefon);
            komut.Parameters.AddWithValue("Email", kayit.Email);

            return Tools.ExecuteNonQuery(komut);

        }
        public static bool Giris(Kayit giris)
        {
            SqlCommand komut = new SqlCommand("Giris", Tools.Baglanti);

            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("KullaniciAdi", giris.KullaniciAdi);
            komut.Parameters.AddWithValue("Sifre", giris.Sifre);

            return Tools.ExecuteNonQuery(komut);



        }

    }
}
