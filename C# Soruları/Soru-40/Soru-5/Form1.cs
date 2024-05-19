using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte[,] dizi = new byte[4, 4];
        int hak = 10;

        private void tikla(object sender, EventArgs e)
        {
            if (hak == 0)
            {
                DialogResult cevap = MessageBox.Show("Tekrar oynamak ister misiniz ?", "Hakkınız bitti, Kaybettiniz!", MessageBoxButtons.YesNo);
                if (cevap == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
            hak--;
            lblhak.Text = hak.ToString();
            PictureBox kutu = (PictureBox)sender;
            string secim = kutu.Name.ToString();
            byte durum = dizi[int.Parse(secim[1].ToString()), int.Parse(secim[2].ToString())];
            if (durum == 0)
            {
                kutu.BackColor = Color.Red;
            }
            else
            {
                kutu.BackColor = Color.Green;
                DialogResult cevap = MessageBox.Show("Tekrar oynamak ister misiniz ?", "Kazandınız!", MessageBoxButtons.YesNo);
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
            Random rastgele = new Random();
            int satirrastgele = rastgele.Next(0, 4);
            int sutunrastgele = rastgele.Next(0, 4);
            dizi[satirrastgele, sutunrastgele] = 1;
        }
    }
}
