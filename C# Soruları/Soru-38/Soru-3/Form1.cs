using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] isimler = new string[5];
        int[] notlar = new int[5];
        int index = 0;

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (index<isimler.Length)
            {
                isimler[index] = txtadsoyad.Text;
                notlar[index] = int.Parse(txtdersnotu.Text);
                index++;
                txtadsoyad.Text = "";
                txtdersnotu.Text = "";
            }
            else
            {
                MessageBox.Show("Öğrenci kapasitesi aşıldı!");
                txtadsoyad.Text = "";
                txtdersnotu.Text = "";
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i] != null)
                {
                    lbliste.Items.Add(isimler[i] + "-->" + notlar[i]);
                }
            }
        }

        private void txtlistesil_Click(object sender, EventArgs e)
        {
            lbliste.Items.Clear();
            txtenyuksek.Enabled = true;
            txtendusuk.Enabled = true;
            txtortalama.Enabled = true;
        }

        private void btnenyuksek_Click(object sender, EventArgs e)
        {
                int enyuksek = notlar[0];
                for (int i = 0; i < notlar.Length; i++)
                {
                    if (notlar[i] > enyuksek)
                    {
                        enyuksek = notlar[i];

                    }
                    txtenyuksek.Text = enyuksek.ToString();
                    txtenyuksek.Enabled = false;
                }
        }

        private void btnendusuk_Click(object sender, EventArgs e)
        {
            int endusuk = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i]< endusuk)
                {
                    endusuk = notlar[i];
                }
                txtendusuk.Text = endusuk.ToString();
                txtendusuk.Enabled = false;
            }
        }

        private void btnortalama_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            Double ortalama = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }
            ortalama = toplam / notlar.Length;
            txtortalama.Text = ortalama.ToString();
            txtortalama.Enabled = false;
        }
    }
}
