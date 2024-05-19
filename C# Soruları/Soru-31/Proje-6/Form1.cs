using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            dogru = 0;
            yanlis=0;
            lblyanlis.Text = yanlis.ToString();
            lbldogru.Text = dogru.ToString();
            for (int i = 0; i <=10; i++)
            {
                lb1.Items.Add(rnd.Next(10, 50));
                lb2.Items.Add(rnd.Next(10, 50));
            }
        }

        int sayi1, sayi2, dogru, yanlis,sonuc;

        private void btnhesap_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt16(txtsayi1.Text);
            sayi2 = Convert.ToInt16(txtsayi2.Text);
            sonuc = sayi1 + sayi2;
            if (sonuc.ToString() == txtsonuc.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
            }
            txtsayi1.Text = "";
            txtsayi2.Text = "";
            txtsonuc.Text = "";
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsayi1.Text = lb1.SelectedItem.ToString();
        }

        private void lb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsayi2.Text = lb2.SelectedItem.ToString();
        }
    }
}
