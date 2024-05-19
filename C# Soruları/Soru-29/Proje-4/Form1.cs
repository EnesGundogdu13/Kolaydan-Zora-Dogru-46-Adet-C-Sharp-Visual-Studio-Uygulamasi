using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            lblist.Items.Add(txtdeger.Text);
            txtdeger.Text = "";

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            lblist.Items.Clear();
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            lblcount.Text = lblist.Items.Count.ToString();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            int deger = lblist.Items.IndexOf(txtara.Text);
            if (deger==-1)
            {
                MessageBox.Show("Bulunamadı!");
            }
            else
            {
                MessageBox.Show("Bulundu!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblist.Items.Remove(txtsil.Text);
            txtsil.Text = "";
        }
    }
}
