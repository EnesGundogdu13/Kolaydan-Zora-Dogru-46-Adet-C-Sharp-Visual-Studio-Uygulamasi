using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_10
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
            sayi = Convert.ToInt16(txtsayi.Text);
            if (sayi<=0)
            {
                MessageBox.Show("Girdiğiniz Sayı Negatiftir.");
            }
            else if (sayi>0)
            {
                MessageBox.Show("Girdiğiniz Sayı Pozitiftir.");
            }
            else
            {
                MessageBox.Show("Girdiğiniz Sayı 0'dır.");
            }
        }
    }
}
