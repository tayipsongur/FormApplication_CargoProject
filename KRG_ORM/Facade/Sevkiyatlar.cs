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
   public class Sevkiyatlar
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SevkiyatListele", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Sil(Sevkiyat SevkiyatSil)
        {
            SqlCommand komut = new SqlCommand("SevkiyatSil", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("SevkiyatID", SevkiyatSil.SevkiyatID);
            return Tools.ExecuteNonQuery(komut);
        }
        public static bool Ekle(Sevkiyat SevkiyatEkle)
        {
            SqlCommand komut = new SqlCommand("SevkiyatEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("SevkiyatAdi", SevkiyatEkle.SevkiyatAdi);
            komut.Parameters.AddWithValue("SevkAlımNoktası", SevkiyatEkle.SevkAlımNoktası);
            komut.Parameters.AddWithValue("SevkUlasimNoktası", SevkiyatEkle.SevkUlasimNoktası);
            komut.Parameters.AddWithValue("Mesafe", SevkiyatEkle.Mesafe);
            komut.Parameters.AddWithValue("MesafeTutar", SevkiyatEkle.MesafeTutar);
            komut.Parameters.AddWithValue("AracID", SevkiyatEkle.AracID);


            return Tools.ExecuteNonQuery(komut);

        }
        public static bool Guncelle(Sevkiyat SevkiyatGuncelle)
        {
            SqlCommand komut = new SqlCommand("SevkiyatGuncelle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("SevkiyatID", SevkiyatGuncelle.SevkiyatID);
            komut.Parameters.AddWithValue("SevkiyatAdi", SevkiyatGuncelle.SevkiyatAdi);
            komut.Parameters.AddWithValue("SevkAlımNoktası", SevkiyatGuncelle.SevkAlımNoktası);
            komut.Parameters.AddWithValue("SevkUlasimNoktası", SevkiyatGuncelle.SevkUlasimNoktası);
            komut.Parameters.AddWithValue("Mesafe", SevkiyatGuncelle.Mesafe);
            komut.Parameters.AddWithValue("MesafeTutar", SevkiyatGuncelle.MesafeTutar);
            komut.Parameters.AddWithValue("AracID", SevkiyatGuncelle.AracID);

            return Tools.ExecuteNonQuery(komut);
        }
        public static DataTable Arama(Sevkiyat SevkiyatArama)
        {
            SqlCommand komut = new SqlCommand("SevkiyatArama",Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("SevkiyatAdi", SevkiyatArama.SevkiyatAdi);
            Tools.ExecuteNonQuery(komut);
            SqlDataAdapter adp = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public static DataTable Doldur()
        {
            SqlCommand komut = new SqlCommand();
            DataTable doldur = new DataTable();
            SqlDataAdapter goster = new SqlDataAdapter("Select AracID from Araçlar",Tools.Baglanti);
            goster.Fill(doldur);
            return doldur;
            

        }
    }
}
