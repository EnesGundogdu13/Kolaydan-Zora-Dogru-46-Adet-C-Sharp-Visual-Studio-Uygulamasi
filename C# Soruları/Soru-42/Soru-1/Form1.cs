using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesap_Click(object sender, EventArgs e)
        {
           int tutar = int.Parse(txtfiyat.Text);
            if (rb1.Checked == true)
            {
                lblsonuc.Text = tutar.ToString();
            }
           if (rb2.Checked)
            {
                int a = (tutar / 100 * 3) + tutar;
               int b = a / 3;
                lblsonuc.Text = "3 x" +b  + " = " + a.ToString();
            }
            if (rb3.Checked)
            {
                int a = (tutar / 100 * 6) + tutar;

                int b = a / 6;
                lblsonuc.Text = "6 x" + b + " = " + a.ToString();
            }
            if (rb4.Checked)
            {
                int a = (tutar / 100 * 12) + tutar;

                int b = a / 12;
                lblsonuc.Text = "12 x" + b + " = " + a.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen ödeme seçeneğinizi seçiniz!");
            }

        }
    }
}
