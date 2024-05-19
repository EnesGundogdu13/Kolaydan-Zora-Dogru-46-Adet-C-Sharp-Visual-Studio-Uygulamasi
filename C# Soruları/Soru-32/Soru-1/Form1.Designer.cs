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
            this.lbtüm = new System.Windows.Forms.ListBox();
            this.lbic = new System.Windows.Forms.ListBox();
            this.lbdis = new System.Windows.Forms.ListBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_forekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbtüm
            // 
            this.lbtüm.FormattingEnabled = true;
            this.lbtüm.Location = new System.Drawing.Point(32, 52);
            this.lbtüm.Name = "lbtüm";
            this.lbtüm.Size = new System.Drawing.Size(108, 121);
            this.lbtüm.TabIndex = 0;
            // 
            // lbic
            // 
            this.lbic.FormattingEnabled = true;
            this.lbic.Location = new System.Drawing.Point(350, 52);
            this.lbic.Name = "lbic";
            this.lbic.Size = new System.Drawing.Size(120, 121);
            this.lbic.TabIndex = 1;
            // 
            // lbdis
            // 
            this.lbdis.FormattingEnabled = true;
            this.lbdis.Location = new System.Drawing.Point(184, 52);
            this.lbdis.Name = "lbdis";
            this.lbdis.Size = new System.Drawing.Size(120, 121);
            this.lbdis.TabIndex = 2;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(32, 200);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(108, 23);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "İf ile Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tüm Donanımlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dış donanımlar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "İç donanımlar";
            // 
            // btn_forekle
            // 
            this.btn_forekle.Location = new System.Drawing.Point(32, 252);
            this.btn_forekle.Name = "btn_forekle";
            this.btn_forekle.Size = new System.Drawing.Size(108, 23);
            this.btn_forekle.TabIndex = 7;
            this.btn_forekle.Text = "For İle Ekle";
            this.btn_forekle.UseVisualStyleBackColor = true;
            this.btn_forekle.Click += new System.EventHandler(this.btn_forekle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 355);
            this.Controls.Add(this.btn_forekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.lbdis);
            this.Controls.Add(this.lbic);
            this.Controls.Add(this.lbtüm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbtüm;
        private System.Windows.Forms.ListBox lbic;
        private System.Windows.Forms.ListBox lbdis;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_forekle;
    }
}

