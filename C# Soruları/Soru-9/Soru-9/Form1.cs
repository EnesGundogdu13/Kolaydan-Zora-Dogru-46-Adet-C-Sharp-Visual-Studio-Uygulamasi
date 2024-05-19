using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesap_Click(object sender, EventArgs e)
        {
            int kisakenar, uzunkenar, alan, cevre;
            kisakenar = Convert.ToInt16(txtkisakenar.Text);
            uzunkenar = Convert.ToInt16(txtuzunkenar.Text);
            alan = kisakenar * uzunkenar;
            cevre = 2 * (kisakenar + uzunkenar);
            lblalan.Text = alan.ToString();
            lblcevre.Text = cevre.ToString();
        }
    }
}
