using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnhesap_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = int.Parse(txtsayi1.Text), sayi2 = int.Parse(txtsayi2.Text),sonuc;
                sonuc = sayi1 + sayi2;
                lblNone.Text = sonuc.ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen sayı girişi yapın!");   
            }
        }
    }
}
