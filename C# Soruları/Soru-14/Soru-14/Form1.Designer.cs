namespace Soru_14
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
            this.txtnot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhesap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnot
            // 
            this.txtnot.Location = new System.Drawing.Point(283, 62);
            this.txtnot.Name = "txtnot";
            this.txtnot.Size = new System.Drawing.Size(100, 20);
            this.txtnot.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Not giriniz:";
            // 
            // btnhesap
            // 
            this.btnhesap.Location = new System.Drawing.Point(283, 122);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(100, 23);
            this.btnhesap.TabIndex = 2;
            this.btnhesap.Text = "Hesaplayın";
            this.btnhesap.UseVisualStyleBackColor = true;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sonuç:";
            // 
            // lblnot
            // 
            this.lblnot.AutoSize = true;
            this.lblnot.Location = new System.Drawing.Point(280, 172);
            this.lblnot.Name = "lblnot";
            this.lblnot.Size = new System.Drawing.Size(33, 13);
            this.lblnot.TabIndex = 4;
            this.lblnot.Text = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnhesap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhesap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnot;
    }
}

