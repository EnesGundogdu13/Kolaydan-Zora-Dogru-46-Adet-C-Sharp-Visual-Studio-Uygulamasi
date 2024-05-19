namespace Soru_2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbhayvan = new System.Windows.Forms.PictureBox();
            this.lblhismi = new System.Windows.Forms.Label();
            this.ilhayvanlar = new System.Windows.Forms.ImageList(this.components);
            this.lblharf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbhayvan)).BeginInit();
            this.SuspendLayout();
            // 
            // pbhayvan
            // 
            this.pbhayvan.Location = new System.Drawing.Point(176, 45);
            this.pbhayvan.Name = "pbhayvan";
            this.pbhayvan.Size = new System.Drawing.Size(128, 158);
            this.pbhayvan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbhayvan.TabIndex = 0;
            this.pbhayvan.TabStop = false;
            // 
            // lblhismi
            // 
            this.lblhismi.AutoSize = true;
            this.lblhismi.Location = new System.Drawing.Point(221, 233);
            this.lblhismi.Name = "lblhismi";
            this.lblhismi.Size = new System.Drawing.Size(33, 13);
            this.lblhismi.TabIndex = 1;
            this.lblhismi.Text = "None";
            // 
            // ilhayvanlar
            // 
            this.ilhayvanlar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilhayvanlar.ImageStream")));
            this.ilhayvanlar.TransparentColor = System.Drawing.Color.Transparent;
            this.ilhayvanlar.Images.SetKeyName(0, "AYI.jpg");
            this.ilhayvanlar.Images.SetKeyName(1, "BALIK.jpg");
            this.ilhayvanlar.Images.SetKeyName(2, "CEYLAN.jpg");
            this.ilhayvanlar.Images.SetKeyName(3, "Deve.png");
            this.ilhayvanlar.Images.SetKeyName(4, "eşek.png");
            this.ilhayvanlar.Images.SetKeyName(5, "fare.png");
            this.ilhayvanlar.Images.SetKeyName(6, "goril.png");
            this.ilhayvanlar.Images.SetKeyName(7, "none.PNG");
            // 
            // lblharf
            // 
            this.lblharf.AutoSize = true;
            this.lblharf.Location = new System.Drawing.Point(365, 267);
            this.lblharf.Name = "lblharf";
            this.lblharf.Size = new System.Drawing.Size(35, 13);
            this.lblharf.TabIndex = 2;
            this.lblharf.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 330);
            this.Controls.Add(this.lblharf);
            this.Controls.Add(this.lblhismi);
            this.Controls.Add(this.pbhayvan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbhayvan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbhayvan;
        private System.Windows.Forms.Label lblhismi;
        private System.Windows.Forms.ImageList ilhayvanlar;
        private System.Windows.Forms.Label lblharf;
    }
}

