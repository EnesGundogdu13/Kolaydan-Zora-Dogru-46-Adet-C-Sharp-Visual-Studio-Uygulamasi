using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesap_Click(object sender, EventArgs e)
        {
            int sayi;
            int toplam = 0;
            sayi = Convert.ToInt16(txtsayi1.Text);
            for (int i = 1; i <= sayi / 2; i++)
            {
                if (sayi%i==0)
                {
                    toplam += i;
                }
                if (sayi == toplam)
                {
                    lblsonuc.Text = sayi.ToString() + " Mükemmel bir sayıdır";
                }
                else
                {
                    lblsonuc.Text = sayi.ToString() + " Mükemmel bir sayı değildir";
                }
            }
        }
    }
}
