namespace görselprogramlama_projeödevi_c_
{
    partial class Form7
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
            this.btn_geridon = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_geridon
            // 
            this.btn_geridon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_geridon.Location = new System.Drawing.Point(7, 450);
            this.btn_geridon.Name = "btn_geridon";
            this.btn_geridon.Size = new System.Drawing.Size(105, 32);
            this.btn_geridon.TabIndex = 34;
            this.btn_geridon.Text = "Geri Dön";
            this.btn_geridon.UseVisualStyleBackColor = false;
            this.btn_geridon.Click += new System.EventHandler(this.btn_geridon_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Honeydew;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Siyolojik İnceleme",
            "İdrar Testleri",
            "Kan Gazları Analizi",
            "Dışkı Muayenesi ve Testleri",
            "Kuduz Titrasyon Testi",
            "Mantar Ekimi",
            "Patolojik İnceleme",
            "Serum Biyokimyası",
            "Tam Kan Sayımı(hemogram)",
            "Kanama Ve Pıhtılaşma süresi tayini",
            "Serolojik ve Diagnostik Kit Testleri",
            "Hormon Analizleri",
            "Kültür-Antibiyogram",
            "Bireysel Alerji Testi(Kandan Elisa ile)Ve alaerji aşısı hazırlanması",
            "Deri Kazıntısı İncelenmesi Hatalık Spesifik Speed Testler (FIP,FIV,FeLV,Gebelik T" +
                "esti,vs)"});
            this.listBox1.Location = new System.Drawing.Point(73, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(550, 356);
            this.listBox1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(201, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Laboratuvar Hizmetleri";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(760, 507);
            this.Controls.Add(this.btn_geridon);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_geridon;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}