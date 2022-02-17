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

namespace Kargo_Otomasyon
{
    public partial class frm_Müşteri : Form
    {
        public frm_Müşteri()
        {
            InitializeComponent();
        }
        public void VeriGoruntule()
        {
            dataGridView1.DataSource = Müsteriler.Listele();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Müsteriler.Listele();

            dataGridView1.Visible = true;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = true;

            Müsteri müsteriekle = new Müsteri();
            müsteriekle.SevkiyatID = Convert.ToInt32(comboSevkiyatNo.Text);
            müsteriekle.MusteriAdSoyad = txtMüsteriAdSoyad.Text;
            müsteriekle.Adres = txtAdres.Text;
            müsteriekle.Telefon = maskedTelefon.Text;
            müsteriekle.Mail = txtMail.Text;
            müsteriekle.OdemeDurum = ComboOdemeDurum.Text;

            if (!Müsteriler.Ekle(müsteriekle))
            {
                MessageBox.Show("Ekleme İşlemi Başarısız Oldu !");
            }
            else
            {
                MessageBox.Show("Ekleme İşlemi Başarılı");
            }
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            VeriGoruntule();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            Müsteri müsterisil = new Müsteri();

            müsterisil.MusteriID = Convert.ToInt32(txtMüsteriNo.Text);

            if (!Müsteriler.Sil(müsterisil))
            {
                MessageBox.Show("Silme İşlemi Başarısız Oldu !");
            }
            else
            {
                MessageBox.Show("Silme İşlemi Başarılı");
            }
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            VeriGoruntule();


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            Müsteri müsteriguncelle = new Müsteri();

            müsteriguncelle.MusteriID = Convert.ToInt32(txtMüsteriNo.Text);
            müsteriguncelle.SevkiyatID = Convert.ToInt32(comboSevkiyatNo.Text);
            müsteriguncelle.MusteriAdSoyad = txtMüsteriAdSoyad.Text;
            müsteriguncelle.Adres = txtAdres.Text;
            müsteriguncelle.Telefon = maskedTelefon.Text;
            müsteriguncelle.Mail = txtMail.Text;
            müsteriguncelle.OdemeDurum = ComboOdemeDurum.Text;

            if (!Müsteriler.Guncelle(müsteriguncelle))
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız Oldu !");
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Başarılı");
            }
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }
            VeriGoruntule();
          
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            Müsteri müsteriarama = new Müsteri();
            müsteriarama.MusteriAdSoyad = txtMüsteriAdSoyad.Text;

            dataGridView1.DataSource = Müsteriler.Arama(müsteriarama);


        }

        private void frm_Müşteri_Load(object sender, EventArgs e)
        {
         

            comboSevkiyatNo.ValueMember = "SevkiyatID";
            comboSevkiyatNo.DataSource = Müsteriler.Doldur();

            dataGridView1.Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;

            txtMüsteriNo.Text = satir.Cells["MusteriID"].Value.ToString();
            comboSevkiyatNo.Text = satir.Cells["SevkiyatID"].Value.ToString();
            txtMüsteriAdSoyad.Text = satir.Cells["MusteriAdSoyad"].Value.ToString();
            txtAdres.Text = satir.Cells["Adres"].Value.ToString();
            maskedTelefon.Text = satir.Cells["Telefon"].Value.ToString();
            txtMail.Text = satir.Cells["Mail"].Value.ToString();
            ComboOdemeDurum.Text = satir.Cells["OdemeDurum"].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 geridön = new Form1();
            geridön.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
