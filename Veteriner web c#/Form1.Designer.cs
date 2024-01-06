namespace görselprogramlama_projeödevi_c_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_hekim = new System.Windows.Forms.Button();
            this.btn_hizmet = new System.Windows.Forms.Button();
            this.btn_sosyalmedya = new System.Windows.Forms.Button();
            this.btn_randevual2 = new System.Windows.Forms.Button();
            this.btn_randevual1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(977, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(47, 567);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 50);
            this.button6.TabIndex = 22;
            this.button6.Text = "Randevularım";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_hekim
            // 
            this.btn_hekim.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_hekim.Location = new System.Drawing.Point(857, 90);
            this.btn_hekim.Name = "btn_hekim";
            this.btn_hekim.Size = new System.Drawing.Size(175, 37);
            this.btn_hekim.TabIndex = 21;
            this.btn_hekim.Text = "Hekimlerimiz";
            this.btn_hekim.UseVisualStyleBackColor = false;
            this.btn_hekim.Click += new System.EventHandler(this.btn_hekim_Click);
            // 
            // btn_hizmet
            // 
            this.btn_hizmet.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_hizmet.Location = new System.Drawing.Point(652, 91);
            this.btn_hizmet.Name = "btn_hizmet";
            this.btn_hizmet.Size = new System.Drawing.Size(189, 40);
            this.btn_hizmet.TabIndex = 20;
            this.btn_hizmet.Text = "Hizmetlerimiz ";
            this.btn_hizmet.UseVisualStyleBackColor = false;
            this.btn_hizmet.Click += new System.EventHandler(this.btn_hizmet_Click);
            // 
            // btn_sosyalmedya
            // 
            this.btn_sosyalmedya.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_sosyalmedya.Location = new System.Drawing.Point(462, 90);
            this.btn_sosyalmedya.Name = "btn_sosyalmedya";
            this.btn_sosyalmedya.Size = new System.Drawing.Size(184, 40);
            this.btn_sosyalmedya.TabIndex = 19;
            this.btn_sosyalmedya.Text = "Sosyal Medya Bağlantıları";
            this.btn_sosyalmedya.UseVisualStyleBackColor = false;
            this.btn_sosyalmedya.Click += new System.EventHandler(this.btn_sosyalmedya_Click);
            // 
            // btn_randevual2
            // 
            this.btn_randevual2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_randevual2.Location = new System.Drawing.Point(251, 91);
            this.btn_randevual2.Name = "btn_randevual2";
            this.btn_randevual2.Size = new System.Drawing.Size(205, 36);
            this.btn_randevual2.TabIndex = 18;
            this.btn_randevual2.Text = "Egzotik Hayvan (Randevu Al)";
            this.btn_randevual2.UseVisualStyleBackColor = false;
            this.btn_randevual2.Click += new System.EventHandler(this.btn_randevual2_Click);
            // 
            // btn_randevual1
            // 
            this.btn_randevual1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_randevual1.Location = new System.Drawing.Point(47, 91);
            this.btn_randevual1.Name = "btn_randevual1";
            this.btn_randevual1.Size = new System.Drawing.Size(198, 36);
            this.btn_randevual1.TabIndex = 17;
            this.btn_randevual1.Text = "Evcil Hayvan(Randevu Al)";
            this.btn_randevual1.UseVisualStyleBackColor = false;
            this.btn_randevual1.Click += new System.EventHandler(this.btn_randevual1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(342, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "PETVET KLİNİĞİNE HOŞGELDİNİZ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1079, 631);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_hekim);
            this.Controls.Add(this.btn_hizmet);
            this.Controls.Add(this.btn_sosyalmedya);
            this.Controls.Add(this.btn_randevual2);
            this.Controls.Add(this.btn_randevual1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_hekim;
        private System.Windows.Forms.Button btn_hizmet;
        private System.Windows.Forms.Button btn_sosyalmedya;
        private System.Windows.Forms.Button btn_randevual2;
        private System.Windows.Forms.Button btn_randevual1;
        private System.Windows.Forms.Label label1;
    }
}

