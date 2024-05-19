using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                txtbilgi.Text = "";
                txtbilgi.Text += txtadsoyad.Text + "\r\n";
                txtbilgi.Text += txttelefon.Text + "\r\n";
                txtbilgi.Text += txtadres.Text + "\r\n";
                decimal hesap = 0;

                if (ncorba.Value > 0)
                {
                    hesap += ncorba.Value * 12;
                    txtbilgi.Text += "Çorba: " + ncorba.Value * 12 + "\r\n";
                }
                if (nsalata.Value > 0)
                {
                    hesap += nsalata.Value * 10;
                    txtbilgi.Text += "Salata: " + nsalata.Value * 10 + "\r\n";
                }
                if (nyemek.Value > 0)
                {
                    hesap += nyemek.Value * 18;
                    txtbilgi.Text += "Anayemek: " + nyemek.Value * 18 + "\r\n";
                }
                if (ntatli.Value > 0)
                {
                    hesap += ntatli.Value * 10;
                    txtbilgi.Text += "Tatlı: " + ntatli.Value * 10 + "\r\n";
                }
                txtbilgi.Text += "Toplam: " + hesap;
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("sasa");
        }
    }
}
