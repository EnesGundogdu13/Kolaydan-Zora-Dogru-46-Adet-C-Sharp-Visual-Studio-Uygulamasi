namespace Soru_25
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
            this.txttaban = new System.Windows.Forms.TextBox();
            this.txtust = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblalt = new System.Windows.Forms.Label();
            this.btnhesap = new System.Windows.Forms.Button();
            this.lblust = new System.Windows.Forms.Label();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txttaban
            // 
            this.txttaban.Location = new System.Drawing.Point(265, 78);
            this.txttaban.Name = "txttaban";
            this.txttaban.Size = new System.Drawing.Size(100, 20);
            this.txttaban.TabIndex = 0;
            // 
            // txtust
            // 
            this.txtust.Location = new System.Drawing.Point(265, 114);
            this.txtust.Name = "txtust";
            this.txtust.Size = new System.Drawing.Size(100, 20);
            this.txtust.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Taban:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Üst:";
            // 
            // lblalt
            // 
            this.lblalt.AutoSize = true;
            this.lblalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblalt.Location = new System.Drawing.Point(212, 200);
            this.lblalt.Name = "lblalt";
            this.lblalt.Size = new System.Drawing.Size(21, 24);
            this.lblalt.TabIndex = 5;
            this.lblalt.Text = "0";
            // 
            // btnhesap
            // 
            this.btnhesap.Location = new System.Drawing.Point(265, 151);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(100, 23);
            this.btnhesap.TabIndex = 6;
            this.btnhesap.Text = "Hesaplayın!";
            this.btnhesap.UseVisualStyleBackColor = true;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // lblust
            // 
            this.lblust.AutoSize = true;
            this.lblust.Location = new System.Drawing.Point(220, 187);
            this.lblust.Name = "lblust";
            this.lblust.Size = new System.Drawing.Size(13, 13);
            this.lblust.TabIndex = 7;
            this.lblust.Text = "0";
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc.Location = new System.Drawing.Point(262, 200);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(21, 24);
            this.lblsonuc.TabIndex = 8;
            this.lblsonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 410);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.lblust);
            this.Controls.Add(this.btnhesap);
            this.Controls.Add(this.lblalt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtust);
            this.Controls.Add(this.txttaban);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttaban;
        private System.Windows.Forms.TextBox txtust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblalt;
        private System.Windows.Forms.Button btnhesap;
        private System.Windows.Forms.Label lblust;
        private System.Windows.Forms.Label lblsonuc;
    }
}

