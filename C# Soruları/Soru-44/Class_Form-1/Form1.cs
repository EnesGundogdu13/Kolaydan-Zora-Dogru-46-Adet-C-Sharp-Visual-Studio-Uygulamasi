using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Form_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesap_Click(object sender, EventArgs e)
        {
            double sayi1 = double.Parse(txtsayi1.Text);
            double sayi2 = double.Parse(txtsayi2.Text);
            Daire d1 = new Daire(sayi1);
            Daire d2 = new Daire(sayi2);
            lbld1alan.Text = d1.alanhesapla().ToString();
            lbld1cevre.Text = d1.cevrehesapla().ToString();
            lbld2alan.Text = d2.alanhesapla().ToString();
            lbld2cevre.Text = d2.cevrehesapla().ToString();
        }
    }
}
