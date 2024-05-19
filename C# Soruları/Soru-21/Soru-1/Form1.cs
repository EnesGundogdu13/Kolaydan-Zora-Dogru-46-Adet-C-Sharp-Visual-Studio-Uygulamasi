using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo, vki;
            boy = Convert.ToDouble(txtboy.Text)/100;
            kilo = Convert.ToDouble(txtkilo.Text);
            vki = kilo / (boy * boy);
            lblsonuc.Text = vki.ToString();
            if (vki<18.4)
            {
                lblsonuc.Text = "Zayıf";
            }
            else if (vki<24.9)
            {
                lblsonuc.Text = "Normal";
            }
            else if (vki<29.9)
            {
                lblsonuc.Text = "Fazla Kilolu";
            }
            else if (vki<34.9)
            {
                lblsonuc.Text = "Şişman (Obez) - I. Sınıf";
            }
            else if (vki<44.9)
            {
                lblsonuc.Text = "Şişman (Obez) - II. Sınıf";
            }
            else if (vki>=45)
            {
                lblsonuc.Text = "Şişman (Obez) - III. Sınıf";

            }
            lblsonuc1.Text = vki.ToString();

        }
    }
}
