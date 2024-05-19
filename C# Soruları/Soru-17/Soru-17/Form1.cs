using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sicaklik;
            sicaklik = Convert.ToInt16(txtsicaklik.Text);
            if (sicaklik<0)
            {
                MessageBox.Show("Buz");
            }
            else if (sicaklik<100)
            {
                MessageBox.Show("Sıvı");
            }
            else
            {
                MessageBox.Show("Gaz");
            }
        }
    }
}
