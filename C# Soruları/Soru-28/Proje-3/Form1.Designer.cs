﻿namespace Proje_3
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
            this.txtsütun = new System.Windows.Forms.TextBox();
            this.txtsatır = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblciz = new System.Windows.Forms.Label();
            this.btnhesap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsütun
            // 
            this.txtsütun.Location = new System.Drawing.Point(101, 68);
            this.txtsütun.Name = "txtsütun";
            this.txtsütun.Size = new System.Drawing.Size(67, 20);
            this.txtsütun.TabIndex = 0;
            // 
            // txtsatır
            // 
            this.txtsatır.Location = new System.Drawing.Point(101, 32);
            this.txtsatır.Name = "txtsatır";
            this.txtsatır.Size = new System.Drawing.Size(67, 20);
            this.txtsatır.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sütun:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Satır:";
            // 
            // lblciz
            // 
            this.lblciz.AutoSize = true;
            this.lblciz.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblciz.Location = new System.Drawing.Point(224, 15);
            this.lblciz.Name = "lblciz";
            this.lblciz.Size = new System.Drawing.Size(30, 38);
            this.lblciz.TabIndex = 5;
            this.lblciz.Text = "*";
            // 
            // btnhesap
            // 
            this.btnhesap.Location = new System.Drawing.Point(101, 118);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(67, 23);
            this.btnhesap.TabIndex = 6;
            this.btnhesap.Text = "Hesaplayın";
            this.btnhesap.UseVisualStyleBackColor = true;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 316);
            this.Controls.Add(this.btnhesap);
            this.Controls.Add(this.lblciz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsatır);
            this.Controls.Add(this.txtsütun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsütun;
        private System.Windows.Forms.TextBox txtsatır;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblciz;
        private System.Windows.Forms.Button btnhesap;
    }
}

