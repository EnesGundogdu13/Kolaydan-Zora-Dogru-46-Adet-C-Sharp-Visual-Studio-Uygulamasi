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

        string[] isimler = new string[3];
        int[,] notlar = new int[3,4];
        int index = 0;

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (index == 3)
            {
                MessageBox.Show("Öğrenci kapasitesi doldu!");
            }
            else
            {
                isimler[index] = txtadsoyad.Text;
                notlar[index, 0] = int.Parse(txtnot1.Text);
                notlar[index, 1] = int.Parse(txtnot2.Text);
                notlar[index, 2] = int.Parse(txtnot3.Text);
                notlar[index, 3] = int.Parse(txtnot4.Text);
                index++;
                txtadsoyad.Text = "";
                txtnot1.Text = "";
                txtnot2.Text = "";
                txtnot3.Text = "";
                txtnot4.Text = "";
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            double toplam;
            for (int x = 0; x < 3; x++)
            {
                toplam = 0;
                for (int y = 0; y < 4; y++)
                {
                    toplam += notlar[x, y];
                }
                lbnotlar.Items.Add(isimler[x] + "-->" + toplam / 4);
            }
        }
    }
}
