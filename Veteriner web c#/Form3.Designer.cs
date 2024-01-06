namespace görselprogramlama_projeödevi_c_
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lbl_randevu2 = new System.Windows.Forms.Label();
            this.btn_oluştur2 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_randevu2
            // 
            this.lbl_randevu2.AutoSize = true;
            this.lbl_randevu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_randevu2.ForeColor = System.Drawing.Color.Red;
            this.lbl_randevu2.Location = new System.Drawing.Point(169, 496);
            this.lbl_randevu2.Name = "lbl_randevu2";
            this.lbl_randevu2.Size = new System.Drawing.Size(192, 20);
            this.lbl_randevu2.TabIndex = 44;
            this.lbl_randevu2.Text = "Randevunuz Oluşturuldu";
            this.lbl_randevu2.Visible = false;
            // 
            // btn_oluştur2
            // 
            this.btn_oluştur2.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_oluştur2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_oluştur2.Location = new System.Drawing.Point(60, 423);
            this.btn_oluştur2.Name = "btn_oluştur2";
            this.btn_oluştur2.Size = new System.Drawing.Size(131, 41);
            this.btn_oluştur2.TabIndex = 43;
            this.btn_oluştur2.Text = "Randevu Oluştur";
            this.btn_oluştur2.UseVisualStyleBackColor = false;
            this.btn_oluştur2.Click += new System.EventHandler(this.btn_oluştur1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(6, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 42;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(417, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(60, 96);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(172, 22);
            this.txt_isim.TabIndex = 40;
            // 
            // txt_mesaj
            // 
            this.txt_mesaj.Location = new System.Drawing.Point(60, 157);
            this.txt_mesaj.Name = "txt_mesaj";
            this.txt_mesaj.Size = new System.Drawing.Size(172, 22);
            this.txt_mesaj.TabIndex = 39;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 38;
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
            this.cb_bolum.Location = new System.Drawing.Point(60, 296);
            this.cb_bolum.Name = "cb_bolum";
            this.cb_bolum.Size = new System.Drawing.Size(172, 24);
            this.cb_bolum.TabIndex = 37;
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
            this.cb_saat.Location = new System.Drawing.Point(60, 379);
            this.cb_saat.Name = "cb_saat";
            this.cb_saat.Size = new System.Drawing.Size(172, 24);
            this.cb_saat.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Lütfen Saat Seçiniz.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Hangi Bölümden Randevu Almak İstiyorsunuz.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mail Adresi Giriniz.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Telefon Numarası Giriniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(228, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Egzotik Hayvanınız İçin Randevu Oluşturma";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(897, 576);
            this.Controls.Add(this.lbl_randevu2);
            this.Controls.Add(this.btn_oluştur2);
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
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_randevu2;
        private System.Windows.Forms.Button btn_oluştur2;
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
    }
}