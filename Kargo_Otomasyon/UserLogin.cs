using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KRG_ORM.Entity;
using KRG_ORM.Facade;
using System.Data;
using System.Data.SqlClient;

namespace Kargo_Otomasyon
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Kayit kaydol = new Kayit();

            kaydol.KullaniciAdi = txtKulAdi.Text;
            kaydol.Sifre = txtKulSifre.Text;
            kaydol.Telefon = mskdTelefon.Text;
            kaydol.Email = txtMail.Text;

            if (!Kayitlar.KayitOl(kaydol))
            {
                MessageBox.Show("Kayıt İşlemi Başarısız");
            }
            else
            {
                MessageBox.Show("İşlem Başarılı");
            }
            
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            Kayit giris = new Kayit();

            giris.KullaniciAdi = txtkullaniciad.Text;
            giris.Sifre = txtkullanicisifre.Text;

         
           
           
        }
    }
}
