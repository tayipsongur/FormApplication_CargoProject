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
   public class Müsteriler
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("MusteriListele", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Sil(Müsteri MusteriSil)
        {
            SqlCommand komut = new SqlCommand("MusteriSil", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("MusteriID", MusteriSil.MusteriID);
            return Tools.ExecuteNonQuery(komut);
        }
        public static bool Ekle(Müsteri MüsteriEkle)
        {
            SqlCommand komut = new SqlCommand("MusteriEkleme", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("SevkiyatID", MüsteriEkle.SevkiyatID);
            komut.Parameters.AddWithValue("MusteriAdSoyad", MüsteriEkle.MusteriAdSoyad);
            komut.Parameters.AddWithValue("Adres", MüsteriEkle.Adres);
            komut.Parameters.AddWithValue("Telefon", MüsteriEkle.Telefon);
            komut.Parameters.AddWithValue("Mail", MüsteriEkle.Mail);
            komut.Parameters.AddWithValue("OdemeDurum", MüsteriEkle.OdemeDurum);


            return Tools.ExecuteNonQuery(komut);

        }
        public static bool Guncelle(Müsteri MüsteriGuncelle)
        {
            SqlCommand komut = new SqlCommand("MusteriGuncelle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("MusteriID", MüsteriGuncelle.MusteriID);
            komut.Parameters.AddWithValue("SevkiyatID", MüsteriGuncelle.SevkiyatID);
            komut.Parameters.AddWithValue("MusteriAdSoyad", MüsteriGuncelle.MusteriAdSoyad);
            komut.Parameters.AddWithValue("Adres", MüsteriGuncelle.Adres);
            komut.Parameters.AddWithValue("Telefon", MüsteriGuncelle.Telefon);
            komut.Parameters.AddWithValue("Mail", MüsteriGuncelle.Mail);
            komut.Parameters.AddWithValue("OdemeDurum", MüsteriGuncelle.OdemeDurum);

            return Tools.ExecuteNonQuery(komut);
        }
        public static DataTable Arama(Müsteri MüsteriArama)
        {
            SqlCommand komut = new SqlCommand("MusteriArama",Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("MusteriAdSoyad", MüsteriArama.MusteriAdSoyad);
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
            SqlDataAdapter goster = new SqlDataAdapter("Select SevkiyatID from Sevkiyat", Tools.Baglanti);
            goster.Fill(doldur);
            return doldur;


        }

    }
}
