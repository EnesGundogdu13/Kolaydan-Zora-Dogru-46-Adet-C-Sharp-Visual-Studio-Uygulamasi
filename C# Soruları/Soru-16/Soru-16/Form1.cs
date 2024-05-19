using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesap_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt16(txtsayi1.Text);
            sayi2 = Convert.ToInt16(txtsayi2.Text);
            if (rbtoplama.Checked)
            {
                sonuc = sayi1 + sayi2;
                lblsonuc.Text = sonuc.ToString();
                MessageBox.Show(sonuc.ToString());
            }
            else if (rbcikarma.Checked)
            {
                sonuc = sayi1 - sayi2;
                lblsonuc.Text = sayi1 + "-" + sayi2 + "=" + sonuc.ToString();
            }
            else if (rbcarpma.Checked)
            {
                sonuc = sayi1 * sayi2;
                lblsonuc.Text = sayi1 + "*" + sayi2 + "=" + sonuc.ToString();
            }
            else if (rbbolme.Checked)
            {
                sonuc = sayi1 / sayi2;
                lblsonuc.Text = sayi1 + "/" + sayi2 + "=" + sonuc.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen bir işlem seçin","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rbtoplama.Checked = false;
            rbcikarma.Checked = false;
            rbcarpma.Checked = false;
            rbbolme.Checked=false;
        }
    }
}
