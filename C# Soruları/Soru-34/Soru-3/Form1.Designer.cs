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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblist = new System.Windows.Forms.ListBox();
            this.btnhsec = new System.Windows.Forms.Button();
            this.btnhsil = new System.Windows.Forms.Button();
            this.btnaktar = new System.Windows.Forms.Button();
            this.btnlbsil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "AnaKart",
            "İşlemci",
            "Ram",
            "Ekran Kartı"});
            this.checkedListBox1.Location = new System.Drawing.Point(47, 35);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 139);
            this.checkedListBox1.TabIndex = 0;
            // 
            // lblist
            // 
            this.lblist.FormattingEnabled = true;
            this.lblist.Location = new System.Drawing.Point(295, 35);
            this.lblist.Name = "lblist";
            this.lblist.Size = new System.Drawing.Size(120, 147);
            this.lblist.TabIndex = 1;
            // 
            // btnhsec
            // 
            this.btnhsec.Location = new System.Drawing.Point(47, 180);
            this.btnhsec.Name = "btnhsec";
            this.btnhsec.Size = new System.Drawing.Size(120, 23);
            this.btnhsec.TabIndex = 2;
            this.btnhsec.Text = "Hepsini Seç";
            this.btnhsec.UseVisualStyleBackColor = true;
            this.btnhsec.Click += new System.EventHandler(this.btnhsec_Click);
            // 
            // btnhsil
            // 
            this.btnhsil.Location = new System.Drawing.Point(47, 209);
            this.btnhsil.Name = "btnhsil";
            this.btnhsil.Size = new System.Drawing.Size(120, 25);
            this.btnhsil.TabIndex = 3;
            this.btnhsil.Text = "Hepsini Kaldır";
            this.btnhsil.UseVisualStyleBackColor = true;
            this.btnhsil.Click += new System.EventHandler(this.btnhsil_Click);
            // 
            // btnaktar
            // 
            this.btnaktar.Location = new System.Drawing.Point(191, 91);
            this.btnaktar.Name = "btnaktar";
            this.btnaktar.Size = new System.Drawing.Size(75, 23);
            this.btnaktar.TabIndex = 4;
            this.btnaktar.Text = ">>Aktar>>";
            this.btnaktar.UseVisualStyleBackColor = true;
            this.btnaktar.Click += new System.EventHandler(this.btnaktar_Click);
            // 
            // btnlbsil
            // 
            this.btnlbsil.Location = new System.Drawing.Point(295, 209);
            this.btnlbsil.Name = "btnlbsil";
            this.btnlbsil.Size = new System.Drawing.Size(120, 23);
            this.btnlbsil.TabIndex = 5;
            this.btnlbsil.Text = "Listeyi Sil";
            this.btnlbsil.UseVisualStyleBackColor = true;
            this.btnlbsil.Click += new System.EventHandler(this.btnlbsil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 360);
            this.Controls.Add(this.btnlbsil);
            this.Controls.Add(this.btnaktar);
            this.Controls.Add(this.btnhsil);
            this.Controls.Add(this.btnhsec);
            this.Controls.Add(this.lblist);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "CheckedListBox Kullanımı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox lblist;
        private System.Windows.Forms.Button btnhsec;
        private System.Windows.Forms.Button btnhsil;
        private System.Windows.Forms.Button btnaktar;
        private System.Windows.Forms.Button btnlbsil;
    }
}

