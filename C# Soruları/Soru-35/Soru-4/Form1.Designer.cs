namespace Soru_4
{
    partial class Form1
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
            this.lbhakemler = new System.Windows.Forms.ListBox();
            this.lbatamalar = new System.Windows.Forms.ListBox();
            this.btneslestir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbmaclar = new System.Windows.Forms.ListBox();
            this.btnhhesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbhakemler
            // 
            this.lbhakemler.FormattingEnabled = true;
            this.lbhakemler.Items.AddRange(new object[] {
            "Cüneyt Çakır",
            "Halis Özkahya",
            "Fırat Aydınus",
            "Hüseyin Göçek",
            "Yunus Yıldırım",
            "Bülent Yıldırım",
            "Fethi Serkan Koçak",
            "Özgüç Türkalp",
            "Mustafa Kamil Abitoğlu",
            "Kutluhan Bilgiç",
            "Mesut Çank",
            "Kuddusi Müftüoğlu"});
            this.lbhakemler.Location = new System.Drawing.Point(202, 36);
            this.lbhakemler.Name = "lbhakemler";
            this.lbhakemler.Size = new System.Drawing.Size(153, 199);
            this.lbhakemler.TabIndex = 1;
            // 
            // lbatamalar
            // 
            this.lbatamalar.FormattingEnabled = true;
            this.lbatamalar.Location = new System.Drawing.Point(390, 36);
            this.lbatamalar.Name = "lbatamalar";
            this.lbatamalar.Size = new System.Drawing.Size(187, 160);
            this.lbatamalar.TabIndex = 2;
            // 
            // btneslestir
            // 
            this.btneslestir.Location = new System.Drawing.Point(390, 212);
            this.btneslestir.Name = "btneslestir";
            this.btneslestir.Size = new System.Drawing.Size(187, 23);
            this.btneslestir.TabIndex = 3;
            this.btneslestir.Text = "Eşleştir";
            this.btneslestir.UseVisualStyleBackColor = true;
            this.btneslestir.Click += new System.EventHandler(this.btneslestir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Maçlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hakemler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Atamalar";
            // 
            // lbmaclar
            // 
            this.lbmaclar.FormattingEnabled = true;
            this.lbmaclar.Items.AddRange(new object[] {
            "Antalya - Buca",
            "Kasımpaşa - Konya",
            "Beşiktaş - Galatasaray",
            "Manisa - Eskişehir",
            "Fenerbahçe - Büyükşehir bld",
            "Trabzon - Gaziantep"});
            this.lbmaclar.Location = new System.Drawing.Point(16, 36);
            this.lbmaclar.Name = "lbmaclar";
            this.lbmaclar.Size = new System.Drawing.Size(127, 199);
            this.lbmaclar.TabIndex = 7;
            // 
            // btnhhesapla
            // 
            this.btnhhesapla.Location = new System.Drawing.Point(390, 241);
            this.btnhhesapla.Name = "btnhhesapla";
            this.btnhhesapla.Size = new System.Drawing.Size(187, 23);
            this.btnhhesapla.TabIndex = 8;
            this.btnhhesapla.Text = "Hepsini eslestir";
            this.btnhhesapla.UseVisualStyleBackColor = true;
            this.btnhhesapla.Click += new System.EventHandler(this.btnhhesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 380);
            this.Controls.Add(this.btnhhesapla);
            this.Controls.Add(this.lbmaclar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneslestir);
            this.Controls.Add(this.lbatamalar);
            this.Controls.Add(this.lbhakemler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbhakemler;
        private System.Windows.Forms.ListBox lbatamalar;
        private System.Windows.Forms.Button btneslestir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbmaclar;
        private System.Windows.Forms.Button btnhhesapla;
    }
}

