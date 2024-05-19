using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double birimfiyat, adet, kdv, toplamtutar;
            birimfiyat = Convert.ToDouble(txtbirimfiyat.Text);
            adet = Convert.ToDouble(txtadet.Text);
            kdv = Convert.ToDouble(txtkdv.Text);
            toplamtutar = (birimfiyat * adet) + ((birimfiyat * adet) * kdv / 100);
            lblsonuc.Text = toplamtutar.ToString();
        }
    }
}
