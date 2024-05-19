using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesap_Click(object sender, EventArgs e)
        {
            int satir = Convert.ToInt16(txtsatır.Text), sütun = Convert.ToInt16(txtsütun.Text);
            lblciz.Text = "";
            for (int a = 0; a < satir; a++)
            {
                for (int b = 0; b < sütun; b++)
                {
                    lblciz.Text += "* ";
                }
                lblciz.Text += "\n";
            }
        }
    }
}
