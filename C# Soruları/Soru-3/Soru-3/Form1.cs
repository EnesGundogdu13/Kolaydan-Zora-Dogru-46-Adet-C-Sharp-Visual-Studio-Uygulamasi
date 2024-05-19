using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntoplama_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplama;
            sayi1 = Convert.ToInt16(txtsayi1.Text);
            sayi2 = Convert.ToInt16(txtsayi2.Text);
            toplama = sayi1 + sayi2;
            lblsonuc.Text = toplama.ToString();
        }

        private void btncikarma_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, cikarma;
            sayi1 = Convert.ToInt16(txtsayi1.Text);
            sayi2 = Convert.ToInt16(txtsayi2.Text);
            cikarma = sayi1 - sayi2;
            lblsonuc.Text = cikarma.ToString();
        }

        private void btncarpma_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, carpma;
            sayi1 = Convert.ToInt16(txtsayi1.Text);
            sayi2 = Convert.ToInt16(txtsayi2.Text);
            carpma = sayi1 * sayi2;
            lblsonuc.Text = carpma.ToString();
        }

        private void btnbolme_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, bolme;
            sayi1 = Convert.ToInt16(txtsayi1.Text);
            sayi2 = Convert.ToInt16(txtsayi2.Text);
            bolme = sayi1 / sayi2;
            lblsonuc.Text = bolme.ToString();
        }
    }
}
