namespace Soru_4
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
            this.txtnot4 = new System.Windows.Forms.TextBox();
            this.txtnot1 = new System.Windows.Forms.TextBox();
            this.txtnot2 = new System.Windows.Forms.TextBox();
            this.txtnot3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.lbnotlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(147, 23);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtadsoyad.TabIndex = 0;
            // 
            // txtnot4
            // 
            this.txtnot4.Location = new System.Drawing.Point(237, 88);
            this.txtnot4.Name = "txtnot4";
            this.txtnot4.Size = new System.Drawing.Size(45, 20);
            this.txtnot4.TabIndex = 4;
            // 
            // txtnot1
            // 
            this.txtnot1.Location = new System.Drawing.Point(84, 87);
            this.txtnot1.Name = "txtnot1";
            this.txtnot1.Size = new System.Drawing.Size(45, 20);
            this.txtnot1.TabIndex = 1;
            // 
            // txtnot2
            // 
            this.txtnot2.Location = new System.Drawing.Point(135, 87);
            this.txtnot2.Name = "txtnot2";
            this.txtnot2.Size = new System.Drawing.Size(45, 20);
            this.txtnot2.TabIndex = 2;
            // 
            // txtnot3
            // 
            this.txtnot3.Location = new System.Drawing.Point(186, 87);
            this.txtnot3.Name = "txtnot3";
            this.txtnot3.Size = new System.Drawing.Size(45, 20);
            this.txtnot3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "1. Yazılı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adı Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "2. Yazılı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "3. Yazılı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "4. Yazılı";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(327, 84);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 5;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(618, 85);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(75, 23);
            this.btnlistele.TabIndex = 6;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // lbnotlar
            // 
            this.lbnotlar.FormattingEnabled = true;
            this.lbnotlar.Location = new System.Drawing.Point(446, 26);
            this.lbnotlar.Name = "lbnotlar";
            this.lbnotlar.Size = new System.Drawing.Size(120, 160);
            this.lbnotlar.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 302);
            this.Controls.Add(this.lbnotlar);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnot3);
            this.Controls.Add(this.txtnot2);
            this.Controls.Add(this.txtnot1);
            this.Controls.Add(this.txtnot4);
            this.Controls.Add(this.txtadsoyad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.TextBox txtnot4;
        private System.Windows.Forms.TextBox txtnot1;
        private System.Windows.Forms.TextBox txtnot2;
        private System.Windows.Forms.TextBox txtnot3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.ListBox lbnotlar;
    }
}

