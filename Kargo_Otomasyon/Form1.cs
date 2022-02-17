using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kargo_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Araç aracgit = new frm_Araç();
            aracgit.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_Sevkiyat sevkiyatgit = new frm_Sevkiyat();
            sevkiyatgit.ShowDialog();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Müşteri musterigit = new frm_Müşteri();
            musterigit.Show();
            this.Hide();

        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
