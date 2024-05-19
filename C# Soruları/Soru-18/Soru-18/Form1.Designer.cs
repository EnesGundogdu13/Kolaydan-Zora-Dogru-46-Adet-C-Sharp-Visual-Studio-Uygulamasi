namespace Soru_18
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
            this.txttahmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltahmin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblipucu = new System.Windows.Forms.Label();
            this.btnhesap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttahmin
            // 
            this.txttahmin.Location = new System.Drawing.Point(299, 69);
            this.txttahmin.Name = "txttahmin";
            this.txttahmin.Size = new System.Drawing.Size(100, 20);
            this.txttahmin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tahmininiz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yanlış Tahmin Sayısı:";
            // 
            // lbltahmin
            // 
            this.lbltahmin.AutoSize = true;
            this.lbltahmin.Location = new System.Drawing.Point(364, 178);
            this.lbltahmin.Name = "lbltahmin";
            this.lbltahmin.Size = new System.Drawing.Size(33, 13);
            this.lbltahmin.TabIndex = 4;
            this.lbltahmin.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "İpucu:";
            // 
            // lblipucu
            // 
            this.lblipucu.AutoSize = true;
            this.lblipucu.Location = new System.Drawing.Point(364, 214);
            this.lblipucu.Name = "lblipucu";
            this.lblipucu.Size = new System.Drawing.Size(33, 13);
            this.lblipucu.TabIndex = 6;
            this.lblipucu.Text = "None";
            // 
            // btnhesap
            // 
            this.btnhesap.Location = new System.Drawing.Point(299, 123);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(100, 23);
            this.btnhesap.TabIndex = 7;
            this.btnhesap.Text = "tıklayın!";
            this.btnhesap.UseVisualStyleBackColor = true;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnhesap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhesap);
            this.Controls.Add(this.lblipucu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbltahmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttahmin);
            this.Name = "Form1";
            this.Text = "0-100 arası oluşturulan sayıyı tahmin etme oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttahmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltahmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblipucu;
        private System.Windows.Forms.Button btnhesap;
    }
}

