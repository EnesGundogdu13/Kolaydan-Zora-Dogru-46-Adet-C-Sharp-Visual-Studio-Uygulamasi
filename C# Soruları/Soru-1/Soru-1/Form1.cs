﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt16(txtsayi1.Text);
            sayi2 = Convert.ToInt16(txtsayi2.Text);
            toplam = sayi1 + sayi2;
            lblsonuc.Text =  toplam.ToString();
        }
    }
}
