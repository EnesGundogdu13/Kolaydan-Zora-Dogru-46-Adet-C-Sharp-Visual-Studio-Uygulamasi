namespace Soru_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.txtdersnotu = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnenyuksek = new System.Windows.Forms.Button();
            this.btnendusuk = new System.Windows.Forms.Button();
            this.btnortalama = new System.Windows.Forms.Button();
            this.txtenyuksek = new System.Windows.Forms.TextBox();
            this.txtendusuk = new System.Windows.Forms.TextBox();
            this.txtortalama = new System.Windows.Forms.TextBox();
            this.lbliste = new System.Windows.Forms.ListBox();
            this.btnlistele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlistesil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(150, 25);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtadsoyad.TabIndex = 0;
            // 
            // txtdersnotu
            // 
            this.txtdersnotu.Location = new System.Drawing.Point(150, 63);
            this.txtdersnotu.Name = "txtdersnotu";
            this.txtdersnotu.Size = new System.Drawing.Size(100, 20);
            this.txtdersnotu.TabIndex = 1;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(150, 100);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnenyuksek
            // 
            this.btnenyuksek.Location = new System.Drawing.Point(150, 167);
            this.btnenyuksek.Name = "btnenyuksek";
            this.btnenyuksek.Size = new System.Drawing.Size(75, 23);
            this.btnenyuksek.TabIndex = 3;
            this.btnenyuksek.Text = "En Yüksek";
            this.btnenyuksek.UseVisualStyleBackColor = true;
            this.btnenyuksek.Click += new System.EventHandler(this.btnenyuksek_Click);
            // 
            // btnendusuk
            // 
            this.btnendusuk.Location = new System.Drawing.Point(150, 204);
            this.btnendusuk.Name = "btnendusuk";
            this.btnendusuk.Size = new System.Drawing.Size(75, 23);
            this.btnendusuk.TabIndex = 4;
            this.btnendusuk.Text = "En Düşük";
            this.btnendusuk.UseVisualStyleBackColor = true;
            this.btnendusuk.Click += new System.EventHandler(this.btnendusuk_Click);
            // 
            // btnortalama
            // 
            this.btnortalama.Location = new System.Drawing.Point(150, 243);
            this.btnortalama.Name = "btnortalama";
            this.btnortalama.Size = new System.Drawing.Size(75, 23);
            this.btnortalama.TabIndex = 5;
            this.btnortalama.Text = "Ortalama";
            this.btnortalama.UseVisualStyleBackColor = true;
            this.btnortalama.Click += new System.EventHandler(this.btnortalama_Click);
            // 
            // txtenyuksek
            // 
            this.txtenyuksek.Location = new System.Drawing.Point(231, 170);
            this.txtenyuksek.Name = "txtenyuksek";
            this.txtenyuksek.Size = new System.Drawing.Size(100, 20);
            this.txtenyuksek.TabIndex = 6;
            // 
            // txtendusuk
            // 
            this.txtendusuk.Location = new System.Drawing.Point(231, 207);
            this.txtendusuk.Name = "txtendusuk";
            this.txtendusuk.Size = new System.Drawing.Size(100, 20);
            this.txtendusuk.TabIndex = 7;
            // 
            // txtortalama
            // 
            this.txtortalama.Location = new System.Drawing.Point(231, 246);
            this.txtortalama.Name = "txtortalama";
            this.txtortalama.Size = new System.Drawing.Size(100, 20);
            this.txtortalama.TabIndex = 8;
            // 
            // lbliste
            // 
            this.lbliste.FormattingEnabled = true;
            this.lbliste.Location = new System.Drawing.Point(423, 25);
            this.lbliste.Name = "lbliste";
            this.lbliste.Size = new System.Drawing.Size(120, 121);
            this.lbliste.TabIndex = 9;
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(423, 156);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(45, 23);
            this.btnlistele.TabIndex = 10;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ders Notu:";
            // 
            // txtlistesil
            // 
            this.txtlistesil.Location = new System.Drawing.Point(487, 156);
            this.txtlistesil.Name = "txtlistesil";
            this.txtlistesil.Size = new System.Drawing.Size(56, 23);
            this.txtlistesil.TabIndex = 13;
            this.txtlistesil.Text = "listesil";
            this.txtlistesil.UseVisualStyleBackColor = true;
            this.txtlistesil.Click += new System.EventHandler(this.txtlistesil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 342);
            this.Controls.Add(this.txtlistesil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.lbliste);
            this.Controls.Add(this.txtortalama);
            this.Controls.Add(this.txtendusuk);
            this.Controls.Add(this.txtenyuksek);
            this.Controls.Add(this.btnortalama);
            this.Controls.Add(this.btnendusuk);
            this.Controls.Add(this.btnenyuksek);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtdersnotu);
            this.Controls.Add(this.txtadsoyad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.TextBox txtdersnotu;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnenyuksek;
        private System.Windows.Forms.Button btnendusuk;
        private System.Windows.Forms.Button btnortalama;
        private System.Windows.Forms.TextBox txtenyuksek;
        private System.Windows.Forms.TextBox txtendusuk;
        private System.Windows.Forms.TextBox txtortalama;
        private System.Windows.Forms.ListBox lbliste;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtlistesil;
    }
}

