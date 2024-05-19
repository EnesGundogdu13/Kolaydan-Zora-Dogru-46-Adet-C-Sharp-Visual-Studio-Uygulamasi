using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi, sayac = 0;

        private void btnhesap_Click(object sender, EventArgs e)
        {
            int tahmin;
            sayac++;
            lbltahmin.Text = sayac.ToString();
            tahmin = Convert.ToInt16(txttahmin.Text);
            txttahmin.Text = "";
            if (tahmin > sayi)
            {
                lblipucu.Text = "Sayıyı Azaltın!";
                lblipucu.ForeColor = Color.Red;
            }
            else if (tahmin < sayi)
            {
                lblipucu.Text = "Sayıyı Yükseltin!";
                lblipucu.ForeColor = Color.Blue;
            }
            else
            {
                lblipucu.Text = "Tahmininiz Doğru!";
                lblipucu.ForeColor = Color.Green;
                DialogResult cevap = MessageBox.Show("Tekrar Oynamak İster Misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayi = rnd.Next(0, 100);
        }
    }
}
