using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtxedit.Cut();
        }

        private void kopyalaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            rtxedit.Copy();
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtxedit.Paste();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtxedit.Text=="")
            {
                MessageBox.Show("Kaydedilecek bir metin yok!");
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Dosyası | *.txt | Tüm Dosyalar | *.*"; DialogResult cevap = sfd.ShowDialog();
                if (cevap == DialogResult.OK)
                {
                    rtxedit.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }
        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Dosyaları|*.txt";
            DialogResult cevap = ofd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                rtxedit.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        private void renkDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                rtxedit.SelectionColor = cd.Color;
            }
        }
        private void fontDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                rtxedit.Font = fd.Font;
            }
        }
    }
}
