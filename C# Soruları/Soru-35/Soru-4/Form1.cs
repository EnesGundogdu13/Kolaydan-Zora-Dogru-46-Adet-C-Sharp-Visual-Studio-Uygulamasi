using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btneslestir_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rndhakem = rnd.Next(0, lbhakemler.Items.Count);
            int rndmac = rnd.Next(0, lbmaclar.Items.Count);
            string hakem = lbhakemler.Items[rndhakem].ToString();
            string mac = lbmaclar.Items[rndmac].ToString();
            lbhakemler.Items.RemoveAt(rndhakem);
            lbmaclar.Items.RemoveAt(rndmac);
            lbatamalar.Items.Add(mac + "-->" + hakem);
            if (lbmaclar.Items.Count == 0)
            {
                btneslestir.Enabled = false;
                btnhhesapla.Enabled = false;
            }
        }

        private void btnhhesapla_Click(object sender, EventArgs e)
        {
            int macsayisi = lbmaclar.Items.Count;
            for (int i = 0; i < macsayisi; i++)
            {
                btneslestir_Click(sender, e);
            }
            btnhhesapla.Enabled = false;
        }
    }
}
