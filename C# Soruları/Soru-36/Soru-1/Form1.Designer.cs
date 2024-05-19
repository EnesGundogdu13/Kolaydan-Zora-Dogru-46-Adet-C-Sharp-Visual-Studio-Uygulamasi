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
            this.lbmusteri = new System.Windows.Forms.ListBox();
            this.ifbtnara = new System.Windows.Forms.Button();
            this.txtara = new System.Windows.Forms.TextBox();
            this.forbtnara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbmusteri
            // 
            this.lbmusteri.FormattingEnabled = true;
            this.lbmusteri.Location = new System.Drawing.Point(40, 28);
            this.lbmusteri.Name = "lbmusteri";
            this.lbmusteri.Size = new System.Drawing.Size(120, 147);
            this.lbmusteri.TabIndex = 0;
            // 
            // ifbtnara
            // 
            this.ifbtnara.Location = new System.Drawing.Point(40, 231);
            this.ifbtnara.Name = "ifbtnara";
            this.ifbtnara.Size = new System.Drawing.Size(120, 23);
            this.ifbtnara.TabIndex = 1;
            this.ifbtnara.Text = "İf ile ara";
            this.ifbtnara.UseVisualStyleBackColor = true;
            this.ifbtnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(40, 193);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(120, 20);
            this.txtara.TabIndex = 2;
            // 
            // forbtnara
            // 
            this.forbtnara.Location = new System.Drawing.Point(40, 262);
            this.forbtnara.Name = "forbtnara";
            this.forbtnara.Size = new System.Drawing.Size(120, 23);
            this.forbtnara.TabIndex = 3;
            this.forbtnara.Text = "For ile ara";
            this.forbtnara.UseVisualStyleBackColor = true;
            this.forbtnara.Click += new System.EventHandler(this.forbtnara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 297);
            this.Controls.Add(this.forbtnara);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.ifbtnara);
            this.Controls.Add(this.lbmusteri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbmusteri;
        private System.Windows.Forms.Button ifbtnara;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Button forbtnara;
    }
}

