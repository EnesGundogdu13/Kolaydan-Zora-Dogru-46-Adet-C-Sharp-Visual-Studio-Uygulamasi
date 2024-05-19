namespace Soru_19
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
            this.lbldakika = new System.Windows.Forms.Label();
            this.lbl2nokta1 = new System.Windows.Forms.Label();
            this.lblsaniye = new System.Windows.Forms.Label();
            this.lbl2nokta2 = new System.Windows.Forms.Label();
            this.lblsalise = new System.Windows.Forms.Label();
            this.btnbaslat = new System.Windows.Forms.Button();
            this.btndurdur = new System.Windows.Forms.Button();
            this.btnsifirla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbldakika
            // 
            this.lbldakika.AutoSize = true;
            this.lbldakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.lbldakika.Location = new System.Drawing.Point(163, 119);
            this.lbldakika.Name = "lbldakika";
            this.lbldakika.Size = new System.Drawing.Size(62, 42);
            this.lbldakika.TabIndex = 0;
            this.lbldakika.Text = "00";
            // 
            // lbl2nokta1
            // 
            this.lbl2nokta1.AutoSize = true;
            this.lbl2nokta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.lbl2nokta1.Location = new System.Drawing.Point(231, 119);
            this.lbl2nokta1.Name = "lbl2nokta1";
            this.lbl2nokta1.Size = new System.Drawing.Size(29, 42);
            this.lbl2nokta1.TabIndex = 1;
            this.lbl2nokta1.Text = ":";
            // 
            // lblsaniye
            // 
            this.lblsaniye.AutoSize = true;
            this.lblsaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblsaniye.Location = new System.Drawing.Point(266, 119);
            this.lblsaniye.Name = "lblsaniye";
            this.lblsaniye.Size = new System.Drawing.Size(62, 42);
            this.lblsaniye.TabIndex = 2;
            this.lblsaniye.Text = "00";
            // 
            // lbl2nokta2
            // 
            this.lbl2nokta2.AutoSize = true;
            this.lbl2nokta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2nokta2.Location = new System.Drawing.Point(334, 119);
            this.lbl2nokta2.Name = "lbl2nokta2";
            this.lbl2nokta2.Size = new System.Drawing.Size(29, 42);
            this.lbl2nokta2.TabIndex = 3;
            this.lbl2nokta2.Text = ":";
            // 
            // lblsalise
            // 
            this.lblsalise.AutoSize = true;
            this.lblsalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsalise.Location = new System.Drawing.Point(369, 119);
            this.lblsalise.Name = "lblsalise";
            this.lblsalise.Size = new System.Drawing.Size(62, 42);
            this.lblsalise.TabIndex = 4;
            this.lblsalise.Text = "00";
            // 
            // btnbaslat
            // 
            this.btnbaslat.Location = new System.Drawing.Point(499, 89);
            this.btnbaslat.Name = "btnbaslat";
            this.btnbaslat.Size = new System.Drawing.Size(75, 23);
            this.btnbaslat.TabIndex = 5;
            this.btnbaslat.Text = "Başlat";
            this.btnbaslat.UseVisualStyleBackColor = true;
            this.btnbaslat.Click += new System.EventHandler(this.btnbaslat_Click);
            // 
            // btndurdur
            // 
            this.btndurdur.Location = new System.Drawing.Point(499, 138);
            this.btndurdur.Name = "btndurdur";
            this.btndurdur.Size = new System.Drawing.Size(75, 23);
            this.btndurdur.TabIndex = 6;
            this.btndurdur.Text = "Durdur";
            this.btndurdur.UseVisualStyleBackColor = true;
            this.btndurdur.Click += new System.EventHandler(this.btndurdur_Click);
            // 
            // btnsifirla
            // 
            this.btnsifirla.Location = new System.Drawing.Point(499, 187);
            this.btnsifirla.Name = "btnsifirla";
            this.btnsifirla.Size = new System.Drawing.Size(75, 23);
            this.btnsifirla.TabIndex = 7;
            this.btnsifirla.Text = "Sıfırla";
            this.btnsifirla.UseVisualStyleBackColor = true;
            this.btnsifirla.Click += new System.EventHandler(this.btnsifirla_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsifirla);
            this.Controls.Add(this.btndurdur);
            this.Controls.Add(this.btnbaslat);
            this.Controls.Add(this.lblsalise);
            this.Controls.Add(this.lbl2nokta2);
            this.Controls.Add(this.lblsaniye);
            this.Controls.Add(this.lbl2nokta1);
            this.Controls.Add(this.lbldakika);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldakika;
        private System.Windows.Forms.Label lbl2nokta1;
        private System.Windows.Forms.Label lblsaniye;
        private System.Windows.Forms.Label lbl2nokta2;
        private System.Windows.Forms.Label lblsalise;
        private System.Windows.Forms.Button btnbaslat;
        private System.Windows.Forms.Button btndurdur;
        private System.Windows.Forms.Button btnsifirla;
        private System.Windows.Forms.Timer timer1;
    }
}

