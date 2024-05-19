namespace Soru_8
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
            this.txtyaricap = new System.Windows.Forms.TextBox();
            this.btnhesap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcevre = new System.Windows.Forms.Label();
            this.lblalan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtyaricap
            // 
            this.txtyaricap.Location = new System.Drawing.Point(285, 103);
            this.txtyaricap.Name = "txtyaricap";
            this.txtyaricap.Size = new System.Drawing.Size(100, 20);
            this.txtyaricap.TabIndex = 0;
            // 
            // btnhesap
            // 
            this.btnhesap.Location = new System.Drawing.Point(285, 175);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(100, 23);
            this.btnhesap.TabIndex = 1;
            this.btnhesap.Text = "Hesaplayın";
            this.btnhesap.UseVisualStyleBackColor = true;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "YarıÇap:";
            // 
            // lblcevre
            // 
            this.lblcevre.AutoSize = true;
            this.lblcevre.Location = new System.Drawing.Point(350, 256);
            this.lblcevre.Name = "lblcevre";
            this.lblcevre.Size = new System.Drawing.Size(33, 13);
            this.lblcevre.TabIndex = 3;
            this.lblcevre.Text = "None";
            // 
            // lblalan
            // 
            this.lblalan.AutoSize = true;
            this.lblalan.Location = new System.Drawing.Point(350, 224);
            this.lblalan.Name = "lblalan";
            this.lblalan.Size = new System.Drawing.Size(33, 13);
            this.lblalan.TabIndex = 4;
            this.lblalan.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dairenin Alanı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dairenin Çevresi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblalan);
            this.Controls.Add(this.lblcevre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhesap);
            this.Controls.Add(this.txtyaricap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtyaricap;
        private System.Windows.Forms.Button btnhesap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcevre;
        private System.Windows.Forms.Label lblalan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

