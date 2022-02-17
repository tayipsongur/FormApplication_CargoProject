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
    public partial class frm_Araç : Form
    {
        public frm_Araç()
        {
            InitializeComponent();
        }

        public void VeriGoster()
        {
            dataGridView1.DataSource = Araçlar.Listele();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = Araçlar.Listele();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            Araç aracekle = new Araç();
            aracekle.AracTur = txtAracTur.Text;
            aracekle.AracKapasite = Convert.ToInt32(txtAracKapasite.Text);
            aracekle.AracSofor = txtAracSofor.Text;

            if (!Araçlar.Ekle(aracekle))
            {
                MessageBox.Show("Ekleme İşlemi Başarısız");

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

            Araç aracsil = new Araç();
            aracsil.AracID = Convert.ToInt32(txtAracNo.Text);

            if (!Araçlar.Sil(aracsil))
            {
                MessageBox.Show("Silme İşlemi Başarısız");

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

            VeriGoster();



        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Araç aracguncelle = new Araç();

            aracguncelle.AracID = Convert.ToInt32(txtAracNo.Text);
            aracguncelle.AracTur = txtAracTur.Text;
            aracguncelle.AracKapasite = Convert.ToInt32(txtAracKapasite.Text);
            aracguncelle.AracSofor = txtAracSofor.Text;

            if (!Araçlar.Guncelle(aracguncelle))
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız");
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

            txtAracNo.Text = satir.Cells["AracID"].Value.ToString();
            txtAracTur.Text = satir.Cells["AracTur"].Value.ToString();
            txtAracKapasite.Text = satir.Cells["AracKapasite"].Value.ToString();
            txtAracSofor.Text = satir.Cells["AracSofor"].Value.ToString();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Araç aracara = new Araç();
            aracara.AracTur = txtAracTur.Text;

            dataGridView1.DataSource = Araçlar.Arama(aracara);

        }

        private void frm_Araç_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 geridön = new Form1();
            geridön.ShowDialog();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
