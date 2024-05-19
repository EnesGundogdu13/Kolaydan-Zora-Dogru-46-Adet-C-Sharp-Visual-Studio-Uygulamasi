using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] isimler = new string[5];
        int index = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < isimler.Length; i++)
                {
                    lblist.Items.Add(isimler[i]);
                }
            }
            catch
            {

            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (index < 5)
            {
                isimler[index] = txtdizi.Text;
                index++;
                txtdizi.Text = "";
            }
            else
            {
                MessageBox.Show("Dizi sınırı aşıldı, daha fazla isim ekleyemezsiniz!");
            }
        }
    }
}
