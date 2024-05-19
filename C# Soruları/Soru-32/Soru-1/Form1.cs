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

        private void Form1_Load(object sender, EventArgs e)
        {
            lbtüm.Items.Add("Ram"); lbtüm.Items.Add("Hoparlör"); lbtüm.Items.Add("AnaKart"); lbtüm.Items.Add("Mikrafon"); lbtüm.Items.Add("Ekran Kartı"); lbtüm.Items.Add("İşlemci"); lbtüm.Items.Add("Monitör"); lbtüm.Items.Add("Bellek");
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
            string donanım = lbtüm.Items[lbtüm.SelectedIndex].ToString();
            if (donanım == "Ram")
            {
                lbic.Items.Add("Ram");
                lbtüm.Items.Remove("Ram");
            }
            else if (donanım == "Hoparlör")
            {
                lbdis.Items.Add("Hoparlör");
                lbtüm.Items.Remove("Hoparlör");
            }
            else if (donanım == "AnaKart")
            {
                lbic.Items.Add("AnaKart");
                lbtüm.Items.Remove("AnaKart");
            }
            else if (donanım == "Mikrafon")
            {
                lbdis.Items.Add("Mikrafon");
                lbtüm.Items.Remove("Mikrafon");
            }
            else if (donanım == "Ekran Kartı")
            {
                lbic.Items.Add("Ekran Kartı");
                lbtüm.Items.Remove("Ekran Kartı");
            }
            else if (donanım == "İşlemci")
            {
                lbic.Items.Add("İşlemci");
                lbtüm.Items.Remove("İşlemci");
            }
            else if (donanım == "Monitör")
            {
                lbdis.Items.Add("Monitör");
                lbtüm.Items.Remove("Monitör");
            }
            else if (donanım == "Bellek")
            {
                lbic.Items.Add("Bellek");
                lbtüm.Items.Remove("Bellek");
            }
            }
            catch
            {
                MessageBox.Show("Lütfen bir seçim yapınız!");
            }

        }

        private void btn_forekle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbtüm.Items.Count; i++)
            {
                if (lbtüm.Items[i].ToString() == "Hoparlör" || lbtüm.Items[i].ToString() == "Mikrafon"|| lbtüm.Items[i].ToString() == "Monitör")
                {
                    lbdis.Items.Add(lbtüm.Items[i]);
                }
                else
                {
                    lbic.Items.Add(lbtüm.Items[i]);
                }
            } 
        }
    }
}
