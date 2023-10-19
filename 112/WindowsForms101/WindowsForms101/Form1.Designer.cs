namespace WindowsForms101
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.radioButtonErkek = new System.Windows.Forms.RadioButton();
            this.radioButtonKiz = new System.Windows.Forms.RadioButton();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.ogrdtp = new System.Windows.Forms.DateTimePicker();
            this.txtPuan = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.comboBoxSinif = new System.Windows.Forms.ComboBox();
            this.txtAranacakIfade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cinsiyet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sınıf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Puan";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(95, 222);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 20);
            this.txtNo.TabIndex = 8;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(95, 248);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 9;
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.Location = new System.Drawing.Point(95, 300);
            this.radioButtonErkek.Name = "radioButtonErkek";
            this.radioButtonErkek.Size = new System.Drawing.Size(53, 17);
            this.radioButtonErkek.TabIndex = 14;
            this.radioButtonErkek.TabStop = true;
            this.radioButtonErkek.Text = "Erkek";
            this.radioButtonErkek.UseVisualStyleBackColor = true;
            this.radioButtonErkek.CheckedChanged += new System.EventHandler(this.radioButtonErkek_CheckedChanged);
            // 
            // radioButtonKiz
            // 
            this.radioButtonKiz.AutoSize = true;
            this.radioButtonKiz.Location = new System.Drawing.Point(186, 299);
            this.radioButtonKiz.Name = "radioButtonKiz";
            this.radioButtonKiz.Size = new System.Drawing.Size(52, 17);
            this.radioButtonKiz.TabIndex = 15;
            this.radioButtonKiz.TabStop = true;
            this.radioButtonKiz.Text = "Kadın";
            this.radioButtonKiz.UseVisualStyleBackColor = true;
            this.radioButtonKiz.CheckedChanged += new System.EventHandler(this.radioButtonKiz_CheckedChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(95, 274);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 16;
            // 
            // ogrdtp
            // 
            this.ogrdtp.Location = new System.Drawing.Point(95, 323);
            this.ogrdtp.Name = "ogrdtp";
            this.ogrdtp.Size = new System.Drawing.Size(200, 20);
            this.ogrdtp.TabIndex = 17;
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(95, 376);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(100, 20);
            this.txtPuan.TabIndex = 18;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(323, 168);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(126, 44);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(455, 168);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(126, 44);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(587, 168);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(126, 44);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // comboBoxSinif
            // 
            this.comboBoxSinif.FormattingEnabled = true;
            this.comboBoxSinif.Items.AddRange(new object[] {
            "9A",
            "9B",
            "9C",
            "10A",
            "10B",
            "10C",
            "11A",
            "11B",
            "11C",
            "12A",
            "12B",
            "12C"});
            this.comboBoxSinif.Location = new System.Drawing.Point(95, 349);
            this.comboBoxSinif.Name = "comboBoxSinif";
            this.comboBoxSinif.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSinif.TabIndex = 22;
            // 
            // txtAranacakIfade
            // 
            this.txtAranacakIfade.Location = new System.Drawing.Point(95, 196);
            this.txtAranacakIfade.Name = "txtAranacakIfade";
            this.txtAranacakIfade.Size = new System.Drawing.Size(100, 20);
            this.txtAranacakIfade.TabIndex = 24;
            this.txtAranacakIfade.TextChanged += new System.EventHandler(this.txtAranacakIfade_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Aranacak İfade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAranacakIfade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxSinif);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtPuan);
            this.Controls.Add(this.ogrdtp);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.radioButtonKiz);
            this.Controls.Add(this.radioButtonErkek);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.RadioButton radioButtonErkek;
        private System.Windows.Forms.RadioButton radioButtonKiz;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.DateTimePicker ogrdtp;
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox comboBoxSinif;
        private System.Windows.Forms.TextBox txtAranacakIfade;
        private System.Windows.Forms.Label label8;
    }
}

