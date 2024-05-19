namespace Soru_9
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtuzunkenar = new System.Windows.Forms.TextBox();
            this.txtkisakenar = new System.Windows.Forms.TextBox();
            this.btnhesap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblalan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcevre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtuzunkenar
            // 
            this.txtuzunkenar.Location = new System.Drawing.Point(293, 104);
            this.txtuzunkenar.Name = "txtuzunkenar";
            this.txtuzunkenar.Size = new System.Drawing.Size(100, 20);
            this.txtuzunkenar.TabIndex = 1;
            // 
            // txtkisakenar
            // 
            this.txtkisakenar.Location = new System.Drawing.Point(293, 61);
            this.txtkisakenar.Name = "txtkisakenar";
            this.txtkisakenar.Size = new System.Drawing.Size(100, 20);
            this.txtkisakenar.TabIndex = 2;
            // 
            // btnhesap
            // 
            this.btnhesap.Location = new System.Drawing.Point(293, 153);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(100, 23);
            this.btnhesap.TabIndex = 3;
            this.btnhesap.Text = "Hesaplayın!";
            this.btnhesap.UseVisualStyleBackColor = true;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kısa Kenar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uzun Kenar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alan:";
            // 
            // lblalan
            // 
            this.lblalan.AutoSize = true;
            this.lblalan.Location = new System.Drawing.Point(290, 203);
            this.lblalan.Name = "lblalan";
            this.lblalan.Size = new System.Drawing.Size(33, 13);
            this.lblalan.TabIndex = 7;
            this.lblalan.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Çevre:";
            // 
            // lblcevre
            // 
            this.lblcevre.AutoSize = true;
            this.lblcevre.Location = new System.Drawing.Point(290, 241);
            this.lblcevre.Name = "lblcevre";
            this.lblcevre.Size = new System.Drawing.Size(33, 13);
            this.lblcevre.TabIndex = 9;
            this.lblcevre.Text = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcevre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblalan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhesap);
            this.Controls.Add(this.txtkisakenar);
            this.Controls.Add(this.txtuzunkenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtuzunkenar;
        private System.Windows.Forms.TextBox txtkisakenar;
        private System.Windows.Forms.Button btnhesap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblalan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblcevre;
    }
}

