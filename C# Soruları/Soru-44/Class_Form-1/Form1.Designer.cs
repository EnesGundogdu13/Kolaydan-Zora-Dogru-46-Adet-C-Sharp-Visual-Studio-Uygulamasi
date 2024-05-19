namespace Class_Form_1
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
            this.lbld1alan = new System.Windows.Forms.Label();
            this.lbld1cevre = new System.Windows.Forms.Label();
            this.lbld2alan = new System.Windows.Forms.Label();
            this.lbld2cevre = new System.Windows.Forms.Label();
            this.btnhesap = new System.Windows.Forms.Button();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbld1alan
            // 
            this.lbld1alan.AutoSize = true;
            this.lbld1alan.Location = new System.Drawing.Point(302, 20);
            this.lbld1alan.Name = "lbld1alan";
            this.lbld1alan.Size = new System.Drawing.Size(35, 13);
            this.lbld1alan.TabIndex = 0;
            this.lbld1alan.Text = "label1";
            // 
            // lbld1cevre
            // 
            this.lbld1cevre.AutoSize = true;
            this.lbld1cevre.Location = new System.Drawing.Point(358, 20);
            this.lbld1cevre.Name = "lbld1cevre";
            this.lbld1cevre.Size = new System.Drawing.Size(35, 13);
            this.lbld1cevre.TabIndex = 1;
            this.lbld1cevre.Text = "label2";
            // 
            // lbld2alan
            // 
            this.lbld2alan.AutoSize = true;
            this.lbld2alan.Location = new System.Drawing.Point(302, 53);
            this.lbld2alan.Name = "lbld2alan";
            this.lbld2alan.Size = new System.Drawing.Size(35, 13);
            this.lbld2alan.TabIndex = 2;
            this.lbld2alan.Text = "label3";
            // 
            // lbld2cevre
            // 
            this.lbld2cevre.AutoSize = true;
            this.lbld2cevre.Location = new System.Drawing.Point(358, 49);
            this.lbld2cevre.Name = "lbld2cevre";
            this.lbld2cevre.Size = new System.Drawing.Size(35, 13);
            this.lbld2cevre.TabIndex = 3;
            this.lbld2cevre.Text = "label4";
            // 
            // btnhesap
            // 
            this.btnhesap.Location = new System.Drawing.Point(176, 89);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(100, 23);
            this.btnhesap.TabIndex = 4;
            this.btnhesap.Text = "Hesapla";
            this.btnhesap.UseVisualStyleBackColor = true;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(176, 13);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(100, 20);
            this.txtsayi1.TabIndex = 5;
            // 
            // txtsayi2
            // 
            this.txtsayi2.Location = new System.Drawing.Point(176, 46);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(100, 20);
            this.txtsayi2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 317);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.txtsayi1);
            this.Controls.Add(this.btnhesap);
            this.Controls.Add(this.lbld2cevre);
            this.Controls.Add(this.lbld2alan);
            this.Controls.Add(this.lbld1cevre);
            this.Controls.Add(this.lbld1alan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbld1alan;
        private System.Windows.Forms.Label lbld1cevre;
        private System.Windows.Forms.Label lbld2alan;
        private System.Windows.Forms.Label lbld2cevre;
        private System.Windows.Forms.Button btnhesap;
        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.TextBox txtsayi2;
    }
}

