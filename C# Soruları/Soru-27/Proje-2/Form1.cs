using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblsonuc.Text = "0 1 ";
            long sayi = Convert.ToInt64(txtsayi.Text);
            int onceki = 2,sonraki=3, toplam = 0;
            for (int i = 3; i < sayi; i++)
            {
                toplam = onceki + sonraki;
                lblsonuc.Text += onceki.ToString() + "  ";

                onceki = sonraki;
                sonraki = toplam;
            }

        }
    }
}
