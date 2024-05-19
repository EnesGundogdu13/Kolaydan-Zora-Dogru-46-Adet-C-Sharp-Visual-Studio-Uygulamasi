using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte yazili1, yazili2, perf1, perf2;
            Double ortalama;
            yazili1 = Convert.ToByte(txtyazili1.Text);
            yazili2 = Convert.ToByte(txtyazili2.Text);
            perf1 = Convert.ToByte(txtperf1.Text);
            perf2 = Convert.ToByte(txtperf2.Text);
            ortalama = (yazili1 + yazili2 + perf1 + perf2) /4;
            if (ortalama>=50)
            {
                MessageBox.Show("Geçti");
            }
            else
            {
                MessageBox.Show("Kaldı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Çıkmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
