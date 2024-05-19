namespace Soru_20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbFerrari = new System.Windows.Forms.PictureBox();
            this.pblamborghini = new System.Windows.Forms.PictureBox();
            this.pbmclaren = new System.Windows.Forms.PictureBox();
            this.btnbaslat = new System.Windows.Forms.Button();
            this.rbFerrari = new System.Windows.Forms.RadioButton();
            this.rblamborghini = new System.Windows.Forms.RadioButton();
            this.rbmclaren = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFerrari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblamborghini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmclaren)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbFerrari
            // 
            this.pbFerrari.Image = ((System.Drawing.Image)(resources.GetObject("pbFerrari.Image")));
            this.pbFerrari.Location = new System.Drawing.Point(688, 171);
            this.pbFerrari.Name = "pbFerrari";
            this.pbFerrari.Size = new System.Drawing.Size(100, 50);
            this.pbFerrari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFerrari.TabIndex = 0;
            this.pbFerrari.TabStop = false;
            // 
            // pblamborghini
            // 
            this.pblamborghini.Image = ((System.Drawing.Image)(resources.GetObject("pblamborghini.Image")));
            this.pblamborghini.Location = new System.Drawing.Point(688, 227);
            this.pblamborghini.Name = "pblamborghini";
            this.pblamborghini.Size = new System.Drawing.Size(100, 50);
            this.pblamborghini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblamborghini.TabIndex = 1;
            this.pblamborghini.TabStop = false;
            // 
            // pbmclaren
            // 
            this.pbmclaren.Image = ((System.Drawing.Image)(resources.GetObject("pbmclaren.Image")));
            this.pbmclaren.Location = new System.Drawing.Point(688, 283);
            this.pbmclaren.Name = "pbmclaren";
            this.pbmclaren.Size = new System.Drawing.Size(100, 62);
            this.pbmclaren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmclaren.TabIndex = 2;
            this.pbmclaren.TabStop = false;
            // 
            // btnbaslat
            // 
            this.btnbaslat.Location = new System.Drawing.Point(345, 12);
            this.btnbaslat.Name = "btnbaslat";
            this.btnbaslat.Size = new System.Drawing.Size(75, 23);
            this.btnbaslat.TabIndex = 3;
            this.btnbaslat.Text = "Başlat";
            this.btnbaslat.UseVisualStyleBackColor = true;
            this.btnbaslat.Click += new System.EventHandler(this.btnbaslat_Click);
            // 
            // rbFerrari
            // 
            this.rbFerrari.AutoSize = true;
            this.rbFerrari.Location = new System.Drawing.Point(570, 35);
            this.rbFerrari.Name = "rbFerrari";
            this.rbFerrari.Size = new System.Drawing.Size(54, 17);
            this.rbFerrari.TabIndex = 4;
            this.rbFerrari.TabStop = true;
            this.rbFerrari.Text = "Ferrari";
            this.rbFerrari.UseVisualStyleBackColor = true;
            // 
            // rblamborghini
            // 
            this.rblamborghini.AutoSize = true;
            this.rblamborghini.Location = new System.Drawing.Point(630, 35);
            this.rblamborghini.Name = "rblamborghini";
            this.rblamborghini.Size = new System.Drawing.Size(82, 17);
            this.rblamborghini.TabIndex = 5;
            this.rblamborghini.TabStop = true;
            this.rblamborghini.Text = "Lamborghini";
            this.rblamborghini.UseVisualStyleBackColor = true;
            // 
            // rbmclaren
            // 
            this.rbmclaren.AutoSize = true;
            this.rbmclaren.Location = new System.Drawing.Point(718, 35);
            this.rbmclaren.Name = "rbmclaren";
            this.rbmclaren.Size = new System.Drawing.Size(67, 17);
            this.rbmclaren.TabIndex = 6;
            this.rbmclaren.TabStop = true;
            this.rbmclaren.Text = "McLaren";
            this.rbmclaren.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sizce yarışı kim kazanacak ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbmclaren);
            this.Controls.Add(this.rblamborghini);
            this.Controls.Add(this.rbFerrari);
            this.Controls.Add(this.btnbaslat);
            this.Controls.Add(this.pbmclaren);
            this.Controls.Add(this.pblamborghini);
            this.Controls.Add(this.pbFerrari);
            this.Name = "Form1";
            this.Text = "Araba Yarışı";
            ((System.ComponentModel.ISupportInitialize)(this.pbFerrari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblamborghini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmclaren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbFerrari;
        private System.Windows.Forms.PictureBox pblamborghini;
        private System.Windows.Forms.PictureBox pbmclaren;
        private System.Windows.Forms.Button btnbaslat;
        private System.Windows.Forms.RadioButton rbFerrari;
        private System.Windows.Forms.RadioButton rblamborghini;
        private System.Windows.Forms.RadioButton rbmclaren;
        private System.Windows.Forms.Label label1;
    }
}

