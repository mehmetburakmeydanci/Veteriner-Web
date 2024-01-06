namespace görselprogramlama_projeödevi_c_
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl_randevu = new System.Windows.Forms.Label();
            this.btn_oluştur1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_mesaj = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_bolum = new System.Windows.Forms.ComboBox();
            this.cb_saat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_randevu
            // 
            this.lbl_randevu.AutoSize = true;
            this.lbl_randevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_randevu.ForeColor = System.Drawing.Color.Red;
            this.lbl_randevu.Location = new System.Drawing.Point(165, 516);
            this.lbl_randevu.Name = "lbl_randevu";
            this.lbl_randevu.Size = new System.Drawing.Size(192, 20);
            this.lbl_randevu.TabIndex = 29;
            this.lbl_randevu.Text = "Randevunuz Oluşturuldu";
            this.lbl_randevu.Visible = false;
            // 
            // btn_oluştur1
            // 
            this.btn_oluştur1.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_oluştur1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_oluştur1.Location = new System.Drawing.Point(56, 443);
            this.btn_oluştur1.Name = "btn_oluştur1";
            this.btn_oluştur1.Size = new System.Drawing.Size(131, 41);
            this.btn_oluştur1.TabIndex = 28;
            this.btn_oluştur1.Text = "Randevu Oluştur";
            this.btn_oluştur1.UseVisualStyleBackColor = false;
            this.btn_oluştur1.Click += new System.EventHandler(this.btn_oluştur1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(8, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 27;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(408, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(56, 116);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(172, 22);
            this.txt_isim.TabIndex = 25;
            // 
            // txt_mesaj
            // 
            this.txt_mesaj.Location = new System.Drawing.Point(56, 177);
            this.txt_mesaj.Name = "txt_mesaj";
            this.txt_mesaj.Size = new System.Drawing.Size(172, 22);
            this.txt_mesaj.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 23;
            // 
            // cb_bolum
            // 
            this.cb_bolum.FormattingEnabled = true;
            this.cb_bolum.Items.AddRange(new object[] {
            "Laboratuvar Hizmetleri",
            "Yoğun Bakım Ünitesi",
            "Görüntüleme Hizmetleri",
            "Cerrahi Hizmetler",
            "Aşı İşlemleri\t",
            "Anestezi",
            "Doğum ve Jinekoloji",
            "Veteriner Diş Hekimliği",
            "Egzotik Hayvan Muayenesi",
            "Kafes Kuşları Muayenesi"});
            this.cb_bolum.Location = new System.Drawing.Point(56, 316);
            this.cb_bolum.Name = "cb_bolum";
            this.cb_bolum.Size = new System.Drawing.Size(172, 24);
            this.cb_bolum.TabIndex = 22;
            // 
            // cb_saat
            // 
            this.cb_saat.FormattingEnabled = true;
            this.cb_saat.Items.AddRange(new object[] {
            "10.00",
            "11.00",
            "12.00",
            "13.00",
            "14.00",
            "15.00",
            "16.00",
            "17.00",
            "18.00",
            "19.00"});
            this.cb_saat.Location = new System.Drawing.Point(56, 399);
            this.cb_saat.Name = "cb_saat";
            this.cb_saat.Size = new System.Drawing.Size(172, 24);
            this.cb_saat.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Lütfen Saat Seçiniz.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hangi Bölümden Randevu Almak İstiyorsunuz.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mail Adresi Giriniz.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Telefon Numarası Giriniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(222, -27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Evcil Hayvanınız İçin Randevu Oluşturma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(225, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(367, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Evcil Hayvanınız İçin Randevu Oluşturma";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(891, 587);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_randevu);
            this.Controls.Add(this.btn_oluştur1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.txt_mesaj);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cb_bolum);
            this.Controls.Add(this.cb_saat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_randevu;
        private System.Windows.Forms.Button btn_oluştur1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_mesaj;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cb_bolum;
        private System.Windows.Forms.ComboBox cb_saat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}