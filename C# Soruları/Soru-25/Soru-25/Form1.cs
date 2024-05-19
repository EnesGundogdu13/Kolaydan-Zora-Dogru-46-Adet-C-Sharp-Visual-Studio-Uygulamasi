using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesap_Click(object sender, EventArgs e)
        {
            int ust = Convert.ToInt16(txtust.Text);
            int taban = Convert.ToInt16(txttaban.Text);
            int sonuc = 1;
            for (int i = 1; i <= ust; i++)
            {
                sonuc *= taban;
            }
            lblalt.Text = taban.ToString() + " =";
            lblust.Text = ust.ToString();
            lblsonuc.Text = sonuc.ToString();
        }
    }
}
