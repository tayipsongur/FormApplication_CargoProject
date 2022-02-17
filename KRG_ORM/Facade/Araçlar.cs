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
   public class Araçlar
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("AracListele", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Sil(Araç AracSil)
        {
            SqlCommand komut = new SqlCommand("AracSil", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("AracID", AracSil.AracID);
            return Tools.ExecuteNonQuery(komut);
        }
        public static bool Ekle (Araç AracEkle)
        {
            SqlCommand komut = new SqlCommand("AracEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("AracTur", AracEkle.AracTur);
            komut.Parameters.AddWithValue("AracKapasite", AracEkle.AracKapasite);
            komut.Parameters.AddWithValue("AracSofor", AracEkle.AracSofor);

            return Tools.ExecuteNonQuery(komut);

        }

        public static bool Guncelle(Araç AracGuncelle)
        {
            SqlCommand komut = new SqlCommand("AracGuncelle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("AracID", AracGuncelle.AracID);
            komut.Parameters.AddWithValue("AracTur", AracGuncelle.AracTur);
            komut.Parameters.AddWithValue("AracKapasite", AracGuncelle.AracKapasite);
            komut.Parameters.AddWithValue("AracSofor", AracGuncelle.AracSofor);

            return Tools.ExecuteNonQuery(komut);
        }
        public static DataTable Arama(Araç AraçArama)
        {
            SqlCommand komut = new SqlCommand("AracArama",Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("AracTur", AraçArama.AracTur);
            Tools.ExecuteNonQuery(komut);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
                     
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

    }
}
