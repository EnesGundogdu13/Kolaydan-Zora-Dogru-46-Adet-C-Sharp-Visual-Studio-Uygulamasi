namespace İlkSonsayı
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtilk = new System.Windows.Forms.TextBox();
            this.txtson = new System.Windows.Forms.TextBox();
            this.lbtek = new System.Windows.Forms.ListBox();
            this.lbcift = new System.Windows.Forms.ListBox();
            this.lb3 = new System.Windows.Forms.ListBox();
            this.lb5 = new System.Windows.Forms.ListBox();
            this.btndoldur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlk Sayı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Son Sayı:";
            // 
            // txtilk
            // 
            this.txtilk.Location = new System.Drawing.Point(155, 35);
            this.txtilk.Name = "txtilk";
            this.txtilk.Size = new System.Drawing.Size(63, 20);
            this.txtilk.TabIndex = 2;
            // 
            // txtson
            // 
            this.txtson.Location = new System.Drawing.Point(155, 74);
            this.txtson.Name = "txtson";
            this.txtson.Size = new System.Drawing.Size(63, 20);
            this.txtson.TabIndex = 3;
            // 
            // lbtek
            // 
            this.lbtek.FormattingEnabled = true;
            this.lbtek.Location = new System.Drawing.Point(262, 35);
            this.lbtek.Name = "lbtek";
            this.lbtek.Size = new System.Drawing.Size(45, 186);
            this.lbtek.TabIndex = 5;
            // 
            // lbcift
            // 
            this.lbcift.FormattingEnabled = true;
            this.lbcift.Location = new System.Drawing.Point(326, 35);
            this.lbcift.Name = "lbcift";
            this.lbcift.Size = new System.Drawing.Size(43, 186);
            this.lbcift.TabIndex = 6;
            // 
            // lb3
            // 
            this.lb3.FormattingEnabled = true;
            this.lb3.Location = new System.Drawing.Point(389, 35);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(45, 186);
            this.lb3.TabIndex = 7;
            // 
            // lb5
            // 
            this.lb5.FormattingEnabled = true;
            this.lb5.Location = new System.Drawing.Point(450, 35);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(43, 186);
            this.lb5.TabIndex = 8;
            // 
            // btndoldur
            // 
            this.btndoldur.Location = new System.Drawing.Point(155, 116);
            this.btndoldur.Name = "btndoldur";
            this.btndoldur.Size = new System.Drawing.Size(63, 23);
            this.btndoldur.TabIndex = 9;
            this.btndoldur.Text = "Doldur";
            this.btndoldur.UseVisualStyleBackColor = true;
            this.btndoldur.Click += new System.EventHandler(this.btndoldur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Çift";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "3\'er";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "5\'er";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 341);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btndoldur);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lbcift);
            this.Controls.Add(this.lbtek);
            this.Controls.Add(this.txtson);
            this.Controls.Add(this.txtilk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtilk;
        private System.Windows.Forms.TextBox txtson;
        private System.Windows.Forms.ListBox lbtek;
        private System.Windows.Forms.ListBox lbcift;
        private System.Windows.Forms.ListBox lb3;
        private System.Windows.Forms.ListBox lb5;
        private System.Windows.Forms.Button btndoldur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

