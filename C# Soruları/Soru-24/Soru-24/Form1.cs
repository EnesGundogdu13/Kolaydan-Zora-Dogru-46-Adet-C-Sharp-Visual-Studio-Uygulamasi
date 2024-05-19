using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesap_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(txtsayi1.Text);
            int toplam = 1;
            for (int i = 1; i <= sayi; i++)
            {
                toplam *= i;
            }
            lblsonuc.Text = sayi + "! " + toplam.ToString();
        }
    }
}
