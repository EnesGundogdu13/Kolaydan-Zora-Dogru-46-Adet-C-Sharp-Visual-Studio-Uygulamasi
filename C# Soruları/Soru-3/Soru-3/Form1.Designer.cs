namespace Soru_3
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
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.btntoplama = new System.Windows.Forms.Button();
            this.btncikarma = new System.Windows.Forms.Button();
            this.btncarpma = new System.Windows.Forms.Button();
            this.btnbolme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(275, 41);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(100, 20);
            this.txtsayi1.TabIndex = 0;
            // 
            // txtsayi2
            // 
            this.txtsayi2.Location = new System.Drawing.Point(275, 85);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(100, 20);
            this.txtsayi2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sonuç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "1. Sayı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "1. Sayı:";
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(272, 261);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(33, 13);
            this.lblsonuc.TabIndex = 6;
            this.lblsonuc.Text = "None";
            // 
            // btntoplama
            // 
            this.btntoplama.Location = new System.Drawing.Point(275, 123);
            this.btntoplama.Name = "btntoplama";
            this.btntoplama.Size = new System.Drawing.Size(100, 23);
            this.btntoplama.TabIndex = 7;
            this.btntoplama.Text = "Toplama";
            this.btntoplama.UseVisualStyleBackColor = true;
            this.btntoplama.Click += new System.EventHandler(this.btntoplama_Click);
            // 
            // btncikarma
            // 
            this.btncikarma.Location = new System.Drawing.Point(275, 152);
            this.btncikarma.Name = "btncikarma";
            this.btncikarma.Size = new System.Drawing.Size(100, 23);
            this.btncikarma.TabIndex = 8;
            this.btncikarma.Text = "Çıkarma";
            this.btncikarma.UseVisualStyleBackColor = true;
            this.btncikarma.Click += new System.EventHandler(this.btncikarma_Click);
            // 
            // btncarpma
            // 
            this.btncarpma.Location = new System.Drawing.Point(275, 181);
            this.btncarpma.Name = "btncarpma";
            this.btncarpma.Size = new System.Drawing.Size(100, 23);
            this.btncarpma.TabIndex = 9;
            this.btncarpma.Text = "Çarpma";
            this.btncarpma.UseVisualStyleBackColor = true;
            this.btncarpma.Click += new System.EventHandler(this.btncarpma_Click);
            // 
            // btnbolme
            // 
            this.btnbolme.Location = new System.Drawing.Point(275, 210);
            this.btnbolme.Name = "btnbolme";
            this.btnbolme.Size = new System.Drawing.Size(100, 23);
            this.btnbolme.TabIndex = 10;
            this.btnbolme.Text = "Bölme";
            this.btnbolme.UseVisualStyleBackColor = true;
            this.btnbolme.Click += new System.EventHandler(this.btnbolme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbolme);
            this.Controls.Add(this.btncarpma);
            this.Controls.Add(this.btncikarma);
            this.Controls.Add(this.btntoplama);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.txtsayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.TextBox txtsayi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Button btntoplama;
        private System.Windows.Forms.Button btncikarma;
        private System.Windows.Forms.Button btncarpma;
        private System.Windows.Forms.Button btnbolme;
    }
}

