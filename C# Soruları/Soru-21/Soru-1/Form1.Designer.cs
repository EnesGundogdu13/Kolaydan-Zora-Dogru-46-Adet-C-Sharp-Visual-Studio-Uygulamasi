namespace Soru_1
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
            this.txtboy = new System.Windows.Forms.TextBox();
            this.btnhesap = new System.Windows.Forms.Button();
            this.txtkilo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsonuc1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboy
            // 
            this.txtboy.Location = new System.Drawing.Point(206, 65);
            this.txtboy.Name = "txtboy";
            this.txtboy.Size = new System.Drawing.Size(100, 20);
            this.txtboy.TabIndex = 0;
            // 
            // btnhesap
            // 
            this.btnhesap.Location = new System.Drawing.Point(206, 141);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(100, 23);
            this.btnhesap.TabIndex = 1;
            this.btnhesap.Text = "Hesaplayın";
            this.btnhesap.UseVisualStyleBackColor = true;
            this.btnhesap.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtkilo
            // 
            this.txtkilo.Location = new System.Drawing.Point(206, 102);
            this.txtkilo.Name = "txtkilo";
            this.txtkilo.Size = new System.Drawing.Size(100, 20);
            this.txtkilo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Boy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kilo:";
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(203, 205);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(33, 13);
            this.lblsonuc.TabIndex = 5;
            this.lblsonuc.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sonuç:";
            // 
            // lblsonuc1
            // 
            this.lblsonuc1.AutoSize = true;
            this.lblsonuc1.Location = new System.Drawing.Point(203, 232);
            this.lblsonuc1.Name = "lblsonuc1";
            this.lblsonuc1.Size = new System.Drawing.Size(33, 13);
            this.lblsonuc1.TabIndex = 7;
            this.lblsonuc1.Text = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 336);
            this.Controls.Add(this.lblsonuc1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkilo);
            this.Controls.Add(this.btnhesap);
            this.Controls.Add(this.txtboy);
            this.Name = "Form1";
            this.Text = "VKİ Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboy;
        private System.Windows.Forms.Button btnhesap;
        private System.Windows.Forms.TextBox txtkilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsonuc1;
    }
}

