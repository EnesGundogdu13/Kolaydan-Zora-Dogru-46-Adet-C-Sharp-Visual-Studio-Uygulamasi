namespace Soru_4
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
            this.txtyazili1 = new System.Windows.Forms.TextBox();
            this.btnhesap = new System.Windows.Forms.Button();
            this.txtperf2 = new System.Windows.Forms.TextBox();
            this.txtperf1 = new System.Windows.Forms.TextBox();
            this.txtyazili2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblortalama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtyazili1
            // 
            this.txtyazili1.Location = new System.Drawing.Point(320, 92);
            this.txtyazili1.Name = "txtyazili1";
            this.txtyazili1.Size = new System.Drawing.Size(100, 20);
            this.txtyazili1.TabIndex = 0;
            // 
            // btnhesap
            // 
            this.btnhesap.Location = new System.Drawing.Point(320, 215);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(100, 23);
            this.btnhesap.TabIndex = 1;
            this.btnhesap.Text = "Hesaplayın!";
            this.btnhesap.UseVisualStyleBackColor = true;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // txtperf2
            // 
            this.txtperf2.Location = new System.Drawing.Point(320, 170);
            this.txtperf2.Name = "txtperf2";
            this.txtperf2.Size = new System.Drawing.Size(100, 20);
            this.txtperf2.TabIndex = 2;
            // 
            // txtperf1
            // 
            this.txtperf1.Location = new System.Drawing.Point(320, 144);
            this.txtperf1.Name = "txtperf1";
            this.txtperf1.Size = new System.Drawing.Size(100, 20);
            this.txtperf1.TabIndex = 3;
            // 
            // txtyazili2
            // 
            this.txtyazili2.Location = new System.Drawing.Point(320, 118);
            this.txtyazili2.Name = "txtyazili2";
            this.txtyazili2.Size = new System.Drawing.Size(100, 20);
            this.txtyazili2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "1. Yazılı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "2. Yazılı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "1. Performans:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "2. Performans";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ortalama:";
            // 
            // lblortalama
            // 
            this.lblortalama.AutoSize = true;
            this.lblortalama.Location = new System.Drawing.Point(317, 275);
            this.lblortalama.Name = "lblortalama";
            this.lblortalama.Size = new System.Drawing.Size(33, 13);
            this.lblortalama.TabIndex = 10;
            this.lblortalama.Text = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblortalama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtyazili2);
            this.Controls.Add(this.txtperf1);
            this.Controls.Add(this.txtperf2);
            this.Controls.Add(this.btnhesap);
            this.Controls.Add(this.txtyazili1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtyazili1;
        private System.Windows.Forms.Button btnhesap;
        private System.Windows.Forms.TextBox txtperf2;
        private System.Windows.Forms.TextBox txtperf1;
        private System.Windows.Forms.TextBox txtyazili2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblortalama;
    }
}

