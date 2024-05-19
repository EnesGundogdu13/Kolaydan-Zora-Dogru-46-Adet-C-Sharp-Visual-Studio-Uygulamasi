using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            int dogrusayisi, yanlissayisi, bossayisi;
            double netsayisi;
            dogrusayisi = Convert.ToInt32(txtdogru.Text);
            yanlissayisi = Convert.ToInt32(txtyanlıs.Text);
            bossayisi = 40 - (dogrusayisi + yanlissayisi);
            lblbossayisi.Text = bossayisi.ToString();
            netsayisi = (Convert.ToDouble(dogrusayisi) - (Convert.ToDouble(yanlissayisi) / 4));
            lblnetsayisi.Text = netsayisi.ToString();
        }
    }
}
