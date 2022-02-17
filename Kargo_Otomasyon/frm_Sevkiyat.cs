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
    public partial class frm_Sevkiyat : Form
    {
        public frm_Sevkiyat()
        {
            InitializeComponent();
        }

        public void VeriGoster()
        {
            dataGridView1.DataSource = Sevkiyatlar.Listele();
        }
        private void frm_Sevkiyat_Load(object sender, EventArgs e)
        {
           

            comboAracNo.ValueMember = "AracID";
            comboAracNo.DataSource = Sevkiyatlar.Doldur();

            dataGridView1.Visible = false;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            dataGridView1.DataSource = Sevkiyatlar.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            Sevkiyat sevkiyatekle = new Sevkiyat();
            sevkiyatekle.SevkiyatAdi = txtSevkiyatAdi.Text;
            sevkiyatekle.SevkAlımNoktası = txtSevkAlimNoktası.Text;
            sevkiyatekle.SevkUlasimNoktası = txtSevkiyatUlasimNoktası.Text;
            sevkiyatekle.Mesafe = Convert.ToInt32(txtMesafe.Text);
            sevkiyatekle.MesafeTutar = Convert.ToDecimal(txtMesafeTutar.Text);
            sevkiyatekle.AracID = Convert.ToInt32(comboAracNo.Text);

            if (!Sevkiyatlar.Ekle(sevkiyatekle))
            {
                MessageBox.Show("Ekleme İşlemi Başarısız Oldu");
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
            VeriGoster();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            Sevkiyat sevkiyatsil = new Sevkiyat();

            sevkiyatsil.SevkiyatID = Convert.ToInt32(txtSevkiyatNo.Text);

            if (!Sevkiyatlar.Sil(sevkiyatsil))
            {
                MessageBox.Show("Silme İşlemi Başarısız Oldu");
            }
            else
            {
                MessageBox.Show("Silme İşlemi Başarılı");

            }
            VeriGoster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            Sevkiyat sevkiyatguncelle = new Sevkiyat();
            sevkiyatguncelle.SevkiyatID = Convert.ToInt32(txtSevkiyatNo.Text);
            sevkiyatguncelle.SevkiyatAdi = txtSevkiyatAdi.Text;
            sevkiyatguncelle.SevkAlımNoktası = txtSevkAlimNoktası.Text;
            sevkiyatguncelle.SevkUlasimNoktası = txtSevkiyatUlasimNoktası.Text;
            sevkiyatguncelle.Mesafe = Convert.ToInt32(txtMesafe.Text);
            sevkiyatguncelle.MesafeTutar = Convert.ToDecimal(txtMesafeTutar.Text);
            sevkiyatguncelle.AracID = Convert.ToInt32(comboAracNo.Text);

            if (!Sevkiyatlar.Guncelle(sevkiyatguncelle))
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız Oldu");
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

            }
            VeriGoster();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;

            txtSevkiyatNo.Text = satir.Cells["SevkiyatID"].Value.ToString();
            txtSevkiyatAdi.Text = satir.Cells["SevkiyatAdi"].Value.ToString();
            txtSevkAlimNoktası.Text = satir.Cells["SevkAlımNoktası"].Value.ToString();
            txtSevkiyatUlasimNoktası.Text = satir.Cells["SevkUlasimNoktası"].Value.ToString();
            txtMesafe.Text = satir.Cells["Mesafe"].Value.ToString();
            txtMesafeTutar.Text = satir.Cells["MesafeTutar"].Value.ToString();
            comboAracNo.Text = satir.Cells["AracID"].Value.ToString();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            Sevkiyat sevkiyatara = new Sevkiyat();
            sevkiyatara.SevkiyatAdi = txtSevkiyatAdi.Text;

            dataGridView1.DataSource = Sevkiyatlar.Arama(sevkiyatara);
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
