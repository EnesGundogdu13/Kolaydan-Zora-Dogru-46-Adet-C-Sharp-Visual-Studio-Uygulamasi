using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int salise = 0, saniye = 0, dakika = 0;

        private void btndurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnsifirla_Click(object sender, EventArgs e)
        {
            salise = 0;
            saniye = 0;
            dakika = 0;
            lblsalise.Text = salise.ToString();
            lblsaniye.Text = saniye.ToString();
            lbldakika.Text = dakika.ToString();
        }

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblsalise.Text = salise.ToString();
            lblsaniye.Text = saniye.ToString();
            lbldakika.Text = dakika.ToString();
            salise++;
            if (salise % 10 == 0)
            {
                lbl2nokta1.Visible = !lbl2nokta1.Visible;
                lbl2nokta2.Visible = !lbl2nokta2.Visible;
            }
            if (salise == 100)
            {
                salise = 0;
                saniye++;
                if (saniye == 60)
                {
                    saniye = 0;
                    dakika++;
                }
            }
        }
    }
}
