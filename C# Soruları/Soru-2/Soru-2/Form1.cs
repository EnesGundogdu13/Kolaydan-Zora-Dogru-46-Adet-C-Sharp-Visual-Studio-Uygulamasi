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

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sonuc;
            sayi1 = Convert.ToInt16(txtsayi.Text);
            sonuc = sayi1 * sayi1;
            lblsonuc.Text = sonuc.ToString();
        }
    }
}
