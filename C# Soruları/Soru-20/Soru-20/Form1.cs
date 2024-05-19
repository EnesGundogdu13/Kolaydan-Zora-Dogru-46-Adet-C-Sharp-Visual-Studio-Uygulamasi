using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            if (rbFerrari.Checked || rblamborghini.Checked || rbmclaren.Checked)
            {
                timer1.Start();
                rbFerrari.Enabled = false;
                rblamborghini.Enabled = false;
                rbmclaren.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lütfen bir tahminde bulunun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        Random r = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hiz1 = r.Next(0, 15), hiz2 = r.Next(0, 15), hiz3 = r.Next(0, 15);
            pbFerrari.Left -= hiz1;
            pblamborghini.Left -= hiz2;
            pbmclaren.Left -= hiz3;
            if (pbFerrari.Left <= 0 && rbFerrari.Checked)
            {
                timer1.Stop();
                rbFerrari.Enabled = true;
                rblamborghini.Enabled = true;
                rbmclaren.Enabled = true;
                pbFerrari.Left = 688;
                pblamborghini.Left = 688;
                pbmclaren.Left = 688;
                MessageBox.Show("Yarışı Ferrari Kazandı, Tahmininiz Doğru!");

            }
            else if (pbFerrari.Left <= 0)
            {
                timer1.Stop();
                rbFerrari.Enabled = true;
                rblamborghini.Enabled = true;
                rbmclaren.Enabled = true;
                pbFerrari.Left = 688;
                pblamborghini.Left = 688;
                pbmclaren.Left = 688;
                MessageBox.Show("Yarışı Ferrari Kazandı, Tahmininiz Yanlış!");
            }

            if (pblamborghini.Left <= 0 && rblamborghini.Checked)
            {
                timer1.Stop();
                rbFerrari.Enabled = true;
                rblamborghini.Enabled = true;
                rbmclaren.Enabled = true;
                pbFerrari.Left = 688;
                pblamborghini.Left = 688;
                pbmclaren.Left = 688;
                MessageBox.Show("Yarışı Lamborghini Kazandı, Tahmininiz Doğru!");

            }
            else if (pblamborghini.Left <= 0)
            {
                timer1.Stop();
                rbFerrari.Enabled = true;
                rblamborghini.Enabled = true;
                rbmclaren.Enabled = true;
                pbFerrari.Left = 688;
                pblamborghini.Left = 688;
                pbmclaren.Left = 688;
                MessageBox.Show("Yarışı Lamborghini Kazandı, Tahmininiz Yanlış!");
            }

            if (pbmclaren.Left <= 0 && rbmclaren.Checked)
            {
                timer1.Stop();
                rbFerrari.Enabled = true;
                rblamborghini.Enabled = true;
                rbmclaren.Enabled = true;
                pbFerrari.Left = 688;
                pblamborghini.Left = 688;
                pbmclaren.Left = 688;
                MessageBox.Show("Yarışı McLaren Kazandı, Tahmininiz Doğru!");

            }
            else if (pbmclaren.Left <= 0)
            {
                timer1.Stop();
                rbFerrari.Enabled = true;
                rblamborghini.Enabled = true;
                rbmclaren.Enabled = true;
                pbFerrari.Left = 688;
                pblamborghini.Left = 688;
                pbmclaren.Left = 688;
                MessageBox.Show("Yarışı Mclaren Kazandı, Tahmininiz Yanlış!");
            }
        }
    }
}
