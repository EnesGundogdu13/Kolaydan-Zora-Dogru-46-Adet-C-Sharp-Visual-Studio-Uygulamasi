using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesap_Click(object sender, EventArgs e)
        {
            double r, alan, cevre;
            r = Convert.ToDouble(txtyaricap.Text);
            alan = 3.14 * r * r;
            cevre = 2 * 3.14 * r;
            lblalan.Text = alan.ToString();
            lblcevre.Text = cevre.ToString();
        }
    }
}
