namespace Soru_6
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
            this.txtdogru = new System.Windows.Forms.TextBox();
            this.txtyanlıs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblbossayisi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblnetsayisi = new System.Windows.Forms.Label();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdogru
            // 
            this.txtdogru.Location = new System.Drawing.Point(276, 74);
            this.txtdogru.Name = "txtdogru";
            this.txtdogru.Size = new System.Drawing.Size(100, 20);
            this.txtdogru.TabIndex = 0;
            // 
            // txtyanlıs
            // 
            this.txtyanlıs.Location = new System.Drawing.Point(276, 100);
            this.txtyanlıs.Name = "txtyanlıs";
            this.txtyanlıs.Size = new System.Drawing.Size(100, 20);
            this.txtyanlıs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doğru Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yanlış Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Boş Bırakılan Soru Sayısı:";
            // 
            // lblbossayisi
            // 
            this.lblbossayisi.AutoSize = true;
            this.lblbossayisi.Location = new System.Drawing.Point(341, 176);
            this.lblbossayisi.Name = "lblbossayisi";
            this.lblbossayisi.Size = new System.Drawing.Size(33, 13);
            this.lblbossayisi.TabIndex = 5;
            this.lblbossayisi.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Net Sayısı:";
            // 
            // lblnetsayisi
            // 
            this.lblnetsayisi.AutoSize = true;
            this.lblnetsayisi.Location = new System.Drawing.Point(341, 202);
            this.lblnetsayisi.Name = "lblnetsayisi";
            this.lblnetsayisi.Size = new System.Drawing.Size(33, 13);
            this.lblnetsayisi.TabIndex = 7;
            this.lblnetsayisi.Text = "None";
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(276, 143);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(98, 23);
            this.btnhesapla.TabIndex = 8;
            this.btnhesapla.Text = "Hesaplayın!";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.lblnetsayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblbossayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtyanlıs);
            this.Controls.Add(this.txtdogru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdogru;
        private System.Windows.Forms.TextBox txtyanlıs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblbossayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblnetsayisi;
        private System.Windows.Forms.Button btnhesapla;
    }
}

