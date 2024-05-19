namespace Proje_4
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
            this.lblist = new System.Windows.Forms.ListBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.txtdeger = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsil = new System.Windows.Forms.TextBox();
            this.lblcount = new System.Windows.Forms.Label();
            this.btncount = new System.Windows.Forms.Button();
            this.txtara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblist
            // 
            this.lblist.FormattingEnabled = true;
            this.lblist.Location = new System.Drawing.Point(215, 12);
            this.lblist.Name = "lblist";
            this.lblist.Size = new System.Drawing.Size(120, 134);
            this.lblist.TabIndex = 0;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(12, 51);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(100, 23);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtdeger
            // 
            this.txtdeger.Location = new System.Drawing.Point(12, 25);
            this.txtdeger.Name = "txtdeger";
            this.txtdeger.Size = new System.Drawing.Size(100, 20);
            this.txtdeger.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eklenecekler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Silinecekler";
            // 
            // txtsil
            // 
            this.txtsil.Location = new System.Drawing.Point(12, 125);
            this.txtsil.Name = "txtsil";
            this.txtsil.Size = new System.Drawing.Size(100, 20);
            this.txtsil.TabIndex = 6;
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Location = new System.Drawing.Point(410, 61);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(13, 13);
            this.lblcount.TabIndex = 8;
            this.lblcount.Text = "0";
            // 
            // btncount
            // 
            this.btncount.Location = new System.Drawing.Point(413, 22);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(75, 23);
            this.btncount.TabIndex = 9;
            this.btncount.Text = "Count Gör";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(15, 219);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(100, 20);
            this.txtara.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Arama";
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(15, 257);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(100, 23);
            this.btnara.TabIndex = 13;
            this.btnara.Text = "Arayın";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.txtsil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdeger);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.lblist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lblist;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtdeger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsil;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button button1;
    }
}

