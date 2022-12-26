
namespace UniUygulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.txtOdev = new System.Windows.Forms.TextBox();
            this.txtProje = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAdSoyad = new System.Windows.Forms.ListBox();
            this.lbVize = new System.Windows.Forms.ListBox();
            this.lbOdev = new System.Windows.Forms.ListBox();
            this.lbProje = new System.Windows.Forms.ListBox();
            this.lbFinal = new System.Windows.Forms.ListBox();
            this.lbOrtalama = new System.Windows.Forms.ListBox();
            this.lbHarfNotu = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSeciliSil = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblVize = new System.Windows.Forms.Label();
            this.lblOdev = new System.Windows.Forms.Label();
            this.lblProje = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblGecmeNotu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vize (%40)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ödev (%10)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proje (%20)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Final (%30)";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(104, 33);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(140, 20);
            this.txtAdSoyad.TabIndex = 5;
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(104, 66);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(140, 20);
            this.txtVize.TabIndex = 6;
            // 
            // txtOdev
            // 
            this.txtOdev.Location = new System.Drawing.Point(104, 97);
            this.txtOdev.Name = "txtOdev";
            this.txtOdev.Size = new System.Drawing.Size(140, 20);
            this.txtOdev.TabIndex = 7;
            // 
            // txtProje
            // 
            this.txtProje.Location = new System.Drawing.Point(104, 137);
            this.txtProje.Name = "txtProje";
            this.txtProje.Size = new System.Drawing.Size(140, 20);
            this.txtProje.TabIndex = 8;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(104, 174);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(140, 20);
            this.txtFinal.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(104, 217);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(140, 26);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(274, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adı Soyadı";
            // 
            // lbAdSoyad
            // 
            this.lbAdSoyad.FormattingEnabled = true;
            this.lbAdSoyad.Location = new System.Drawing.Point(277, 35);
            this.lbAdSoyad.Name = "lbAdSoyad";
            this.lbAdSoyad.Size = new System.Drawing.Size(148, 277);
            this.lbAdSoyad.TabIndex = 12;
            // 
            // lbVize
            // 
            this.lbVize.FormattingEnabled = true;
            this.lbVize.Location = new System.Drawing.Point(431, 33);
            this.lbVize.Name = "lbVize";
            this.lbVize.Size = new System.Drawing.Size(98, 277);
            this.lbVize.TabIndex = 13;
            // 
            // lbOdev
            // 
            this.lbOdev.FormattingEnabled = true;
            this.lbOdev.Location = new System.Drawing.Point(535, 33);
            this.lbOdev.Name = "lbOdev";
            this.lbOdev.Size = new System.Drawing.Size(98, 277);
            this.lbOdev.TabIndex = 14;
            // 
            // lbProje
            // 
            this.lbProje.FormattingEnabled = true;
            this.lbProje.Location = new System.Drawing.Point(639, 33);
            this.lbProje.Name = "lbProje";
            this.lbProje.Size = new System.Drawing.Size(98, 277);
            this.lbProje.TabIndex = 15;
            // 
            // lbFinal
            // 
            this.lbFinal.FormattingEnabled = true;
            this.lbFinal.Location = new System.Drawing.Point(743, 33);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(98, 277);
            this.lbFinal.TabIndex = 16;
            // 
            // lbOrtalama
            // 
            this.lbOrtalama.FormattingEnabled = true;
            this.lbOrtalama.Location = new System.Drawing.Point(847, 33);
            this.lbOrtalama.Name = "lbOrtalama";
            this.lbOrtalama.Size = new System.Drawing.Size(98, 277);
            this.lbOrtalama.TabIndex = 17;
            // 
            // lbHarfNotu
            // 
            this.lbHarfNotu.FormattingEnabled = true;
            this.lbHarfNotu.Location = new System.Drawing.Point(951, 33);
            this.lbHarfNotu.Name = "lbHarfNotu";
            this.lbHarfNotu.Size = new System.Drawing.Size(98, 277);
            this.lbHarfNotu.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(428, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Vize";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(532, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ödev";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(636, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Proje";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(740, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Final";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(844, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Geçme Notu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(948, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Harf Notu";
            // 
            // btnSeciliSil
            // 
            this.btnSeciliSil.Location = new System.Drawing.Point(909, 341);
            this.btnSeciliSil.Name = "btnSeciliSil";
            this.btnSeciliSil.Size = new System.Drawing.Size(140, 26);
            this.btnSeciliSil.TabIndex = 26;
            this.btnSeciliSil.Text = "Seçili Satırı Sil";
            this.btnSeciliSil.UseVisualStyleBackColor = true;
            this.btnSeciliSil.Click += new System.EventHandler(this.btnSeciliSil_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(909, 373);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(140, 26);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "Tümünü Boşalt";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(909, 458);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(140, 26);
            this.btnKapat.TabIndex = 28;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(274, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Vize Ortalama";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(274, 380);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Ödev Ortalama";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(273, 408);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Proje Ortalama";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(273, 437);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Final Ortalama";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(274, 465);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Geçme Notu";
            // 
            // lblVize
            // 
            this.lblVize.AutoSize = true;
            this.lblVize.Location = new System.Drawing.Point(411, 354);
            this.lblVize.Name = "lblVize";
            this.lblVize.Size = new System.Drawing.Size(13, 13);
            this.lblVize.TabIndex = 34;
            this.lblVize.Text = "0";
            // 
            // lblOdev
            // 
            this.lblOdev.AutoSize = true;
            this.lblOdev.Location = new System.Drawing.Point(411, 380);
            this.lblOdev.Name = "lblOdev";
            this.lblOdev.Size = new System.Drawing.Size(13, 13);
            this.lblOdev.TabIndex = 35;
            this.lblOdev.Text = "0";
            // 
            // lblProje
            // 
            this.lblProje.AutoSize = true;
            this.lblProje.Location = new System.Drawing.Point(411, 408);
            this.lblProje.Name = "lblProje";
            this.lblProje.Size = new System.Drawing.Size(13, 13);
            this.lblProje.TabIndex = 36;
            this.lblProje.Text = "0";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(411, 437);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(13, 13);
            this.lblFinal.TabIndex = 37;
            this.lblFinal.Text = "0";
            // 
            // lblGecmeNotu
            // 
            this.lblGecmeNotu.AutoSize = true;
            this.lblGecmeNotu.Location = new System.Drawing.Point(411, 465);
            this.lblGecmeNotu.Name = "lblGecmeNotu";
            this.lblGecmeNotu.Size = new System.Drawing.Size(13, 13);
            this.lblGecmeNotu.TabIndex = 38;
            this.lblGecmeNotu.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 507);
            this.Controls.Add(this.lblGecmeNotu);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblProje);
            this.Controls.Add(this.lblOdev);
            this.Controls.Add(this.lblVize);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSeciliSil);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbHarfNotu);
            this.Controls.Add(this.lbOrtalama);
            this.Controls.Add(this.lbFinal);
            this.Controls.Add(this.lbProje);
            this.Controls.Add(this.lbOdev);
            this.Controls.Add(this.lbVize);
            this.Controls.Add(this.lbAdSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtProje);
            this.Controls.Add(this.txtOdev);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.TextBox txtOdev;
        private System.Windows.Forms.TextBox txtProje;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbAdSoyad;
        private System.Windows.Forms.ListBox lbVize;
        private System.Windows.Forms.ListBox lbOdev;
        private System.Windows.Forms.ListBox lbProje;
        private System.Windows.Forms.ListBox lbFinal;
        private System.Windows.Forms.ListBox lbOrtalama;
        private System.Windows.Forms.ListBox lbHarfNotu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSeciliSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblVize;
        private System.Windows.Forms.Label lblOdev;
        private System.Windows.Forms.Label lblProje;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblGecmeNotu;
    }
}

