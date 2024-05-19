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

        private void btnhesap_Click(object sender, EventArgs e)
        {
            double yazili1, yazili2, perf1, perf2, Ortalama;
            yazili1 = Convert.ToDouble(txtyazili1.Text);
            yazili2 = Convert.ToDouble(txtyazili2.Text);
            perf1 = Convert.ToDouble(txtperf1.Text);
            perf2 = Convert.ToDouble(txtperf2.Text);
            Ortalama = (yazili1 + yazili2 + perf1 + perf2) /4;
            lblortalama.Text = Ortalama.ToString();

        }
    }
}
