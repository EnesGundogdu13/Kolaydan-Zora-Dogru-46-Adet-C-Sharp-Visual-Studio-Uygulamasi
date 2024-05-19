using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesap_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt16(txtsayi1.Text);
            int sayi2 = Convert.ToInt16(txtsayi2.Text);
            int toplam = 0;
            if (sayi2 > sayi1)
            {
                for (int i = sayi1; i <= sayi2; i++)
                {
                    toplam += i;
                }
                lblsonuc.Text = sayi1 + " ve " + sayi2 + " Arasındaki sayıların toplamı " + toplam.ToString();
            }
            else if (sayi1 > sayi2)
            {
                for (int i = sayi2; i <= sayi1; i++)
                {
                    toplam += i;
                }
                lblsonuc.Text = sayi2 + " ve " + sayi1 + " Arasındaki sayıların toplamı " + toplam.ToString();
            }
            else
            {
                MessageBox.Show("Girilen Sayılar Birbirine Eşit!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
