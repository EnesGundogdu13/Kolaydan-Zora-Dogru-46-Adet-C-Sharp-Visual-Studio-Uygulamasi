namespace Soru_16
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
            this.rbtoplama = new System.Windows.Forms.RadioButton();
            this.rbcikarma = new System.Windows.Forms.RadioButton();
            this.rbcarpma = new System.Windows.Forms.RadioButton();
            this.rbbolme = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.btnhesap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtoplama
            // 
            this.rbtoplama.AutoSize = true;
            this.rbtoplama.Location = new System.Drawing.Point(26, 19);
            this.rbtoplama.Name = "rbtoplama";
            this.rbtoplama.Size = new System.Drawing.Size(66, 17);
            this.rbtoplama.TabIndex = 0;
            this.rbtoplama.TabStop = true;
            this.rbtoplama.Text = "Toplama";
            this.rbtoplama.UseVisualStyleBackColor = true;
            // 
            // rbcikarma
            // 
            this.rbcikarma.AutoSize = true;
            this.rbcikarma.Location = new System.Drawing.Point(26, 42);
            this.rbcikarma.Name = "rbcikarma";
            this.rbcikarma.Size = new System.Drawing.Size(63, 17);
            this.rbcikarma.TabIndex = 1;
            this.rbcikarma.TabStop = true;
            this.rbcikarma.Text = "Çıkarma";
            this.rbcikarma.UseVisualStyleBackColor = true;
            // 
            // rbcarpma
            // 
            this.rbcarpma.AutoSize = true;
            this.rbcarpma.Location = new System.Drawing.Point(26, 65);
            this.rbcarpma.Name = "rbcarpma";
            this.rbcarpma.Size = new System.Drawing.Size(61, 17);
            this.rbcarpma.TabIndex = 2;
            this.rbcarpma.TabStop = true;
            this.rbcarpma.Text = "Çarpma";
            this.rbcarpma.UseVisualStyleBackColor = true;
            // 
            // rbbolme
            // 
            this.rbbolme.AutoSize = true;
            this.rbbolme.Location = new System.Drawing.Point(26, 88);
            this.rbbolme.Name = "rbbolme";
            this.rbbolme.Size = new System.Drawing.Size(54, 17);
            this.rbbolme.TabIndex = 3;
            this.rbbolme.TabStop = true;
            this.rbbolme.Text = "Bölme";
            this.rbbolme.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rbtoplama);
            this.groupBox1.Controls.Add(this.rbbolme);
            this.groupBox1.Controls.Add(this.rbcikarma);
            this.groupBox1.Controls.Add(this.rbcarpma);
            this.groupBox1.Location = new System.Drawing.Point(438, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(321, 56);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(100, 20);
            this.txtsayi1.TabIndex = 5;
            // 
            // btnhesap
            // 
            this.btnhesap.Location = new System.Drawing.Point(321, 121);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(100, 43);
            this.btnhesap.TabIndex = 6;
            this.btnhesap.Text = "Hesaplamak için tıklayın!";
            this.btnhesap.UseVisualStyleBackColor = true;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sayı Giriniz:";
            // 
            // txtsayi2
            // 
            this.txtsayi2.Location = new System.Drawing.Point(321, 82);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(100, 20);
            this.txtsayi2.TabIndex = 8;
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(240, 144);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(33, 13);
            this.lblsonuc.TabIndex = 9;
            this.lblsonuc.Text = "None";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sıfırla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhesap);
            this.Controls.Add(this.txtsayi1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtoplama;
        private System.Windows.Forms.RadioButton rbcikarma;
        private System.Windows.Forms.RadioButton rbcarpma;
        private System.Windows.Forms.RadioButton rbbolme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.Button btnhesap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsayi2;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Button button1;
    }
}

