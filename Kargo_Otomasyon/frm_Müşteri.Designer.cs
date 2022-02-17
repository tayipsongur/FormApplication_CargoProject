
namespace Kargo_Otomasyon
{
    partial class frm_Müşteri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Müşteri));
            this.ComboOdemeDurum = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtMüsteriAdSoyad = new System.Windows.Forms.TextBox();
            this.txtMüsteriNo = new System.Windows.Forms.TextBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboSevkiyatNo = new System.Windows.Forms.ComboBox();
            this.maskedTelefon = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboOdemeDurum
            // 
            this.ComboOdemeDurum.FormattingEnabled = true;
            this.ComboOdemeDurum.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kart"});
            this.ComboOdemeDurum.Location = new System.Drawing.Point(15, 615);
            this.ComboOdemeDurum.Name = "ComboOdemeDurum";
            this.ComboOdemeDurum.Size = new System.Drawing.Size(131, 21);
            this.ComboOdemeDurum.TabIndex = 53;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(15, 528);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(241, 40);
            this.txtMail.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(4, 585);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "Ödeme Durumu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(4, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(4, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = "Müşteri Adı Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Sevkiyat ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Müşteri No:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(21, 340);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(241, 60);
            this.txtAdres.TabIndex = 43;
            // 
            // txtMüsteriAdSoyad
            // 
            this.txtMüsteriAdSoyad.Location = new System.Drawing.Point(40, 272);
            this.txtMüsteriAdSoyad.Multiline = true;
            this.txtMüsteriAdSoyad.Name = "txtMüsteriAdSoyad";
            this.txtMüsteriAdSoyad.Size = new System.Drawing.Size(131, 24);
            this.txtMüsteriAdSoyad.TabIndex = 42;
            // 
            // txtMüsteriNo
            // 
            this.txtMüsteriNo.Location = new System.Drawing.Point(40, 115);
            this.txtMüsteriNo.Name = "txtMüsteriNo";
            this.txtMüsteriNo.Size = new System.Drawing.Size(131, 20);
            this.txtMüsteriNo.TabIndex = 40;
            // 
            // btnArama
            // 
            this.btnArama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArama.BackgroundImage")));
            this.btnArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArama.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArama.Location = new System.Drawing.Point(132, 747);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(60, 54);
            this.btnArama.TabIndex = 39;
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Location = new System.Drawing.Point(12, 747);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(60, 56);
            this.btnGuncelle.TabIndex = 38;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSil.Location = new System.Drawing.Point(132, 661);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(60, 54);
            this.btnSil.TabIndex = 37;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.BackgroundImage")));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Location = new System.Drawing.Point(12, 661);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(60, 54);
            this.btnEkle.TabIndex = 36;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListele.BackgroundImage")));
            this.btnListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListele.Location = new System.Drawing.Point(1330, 557);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(69, 52);
            this.btnListele.TabIndex = 35;
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gold;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(705, 615);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(703, 200);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboSevkiyatNo
            // 
            this.comboSevkiyatNo.FormattingEnabled = true;
            this.comboSevkiyatNo.Location = new System.Drawing.Point(40, 192);
            this.comboSevkiyatNo.Name = "comboSevkiyatNo";
            this.comboSevkiyatNo.Size = new System.Drawing.Size(131, 21);
            this.comboSevkiyatNo.TabIndex = 54;
            // 
            // maskedTelefon
            // 
            this.maskedTelefon.Location = new System.Drawing.Point(21, 456);
            this.maskedTelefon.Mask = "(999) 000-0000";
            this.maskedTelefon.Name = "maskedTelefon";
            this.maskedTelefon.Size = new System.Drawing.Size(131, 20);
            this.maskedTelefon.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(0, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 40);
            this.button1.TabIndex = 56;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(66, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 40);
            this.button2.TabIndex = 57;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_Müşteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1402, 815);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTelefon);
            this.Controls.Add(this.comboSevkiyatNo);
            this.Controls.Add(this.ComboOdemeDurum);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtMüsteriAdSoyad);
            this.Controls.Add(this.txtMüsteriNo);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Müşteri";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.frm_Müşteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboOdemeDurum;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtMüsteriAdSoyad;
        private System.Windows.Forms.TextBox txtMüsteriNo;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboSevkiyatNo;
        private System.Windows.Forms.MaskedTextBox maskedTelefon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}