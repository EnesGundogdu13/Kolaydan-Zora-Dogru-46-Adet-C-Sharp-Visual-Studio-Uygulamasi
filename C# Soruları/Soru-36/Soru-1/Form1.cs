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

        string musteri;

        private void btnara_Click(object sender, EventArgs e)
        {
            musteri = txtara.Text;
            if (lbmusteri.Items.IndexOf(musteri) == -1)
            {
                MessageBox.Show(musteri + " isimli bir müşteri bulunamadı!");
            }
            else
            {
                MessageBox.Show(musteri + " isimli müşteri bulundu!");
            }
        } // Sistemin İf-else ile yapımı

        private void Form1_Load(object sender, EventArgs e)
        {
            lbmusteri.Items.Add("Enes"); lbmusteri.Items.Add("Hüseyin"); lbmusteri.Items.Add("Yunus"); lbmusteri.Items.Add("Salih"); lbmusteri.Items.Add("Efe"); lbmusteri.Items.Add("Bilal"); lbmusteri.Items.Add("Berkay"); lbmusteri.Items.Add("Kerem"); lbmusteri.Items.Add("Kaan"); lbmusteri.Items.Add("Emirhan");
        }

        private void forbtnara_Click(object sender, EventArgs e)
        { // Sistemin for döngüsü ile yapımı
            musteri = Convert.ToString(txtara.Text);
            for (int i = 0; i <= lbmusteri.Items.Count; i++)
            {

                if (lbmusteri.Items.IndexOf(musteri) == -1)
                {
                    MessageBox.Show(musteri + " isimli bir müşteri bulunamadı!");
                    break;
                }
                else if (lbmusteri.Items.IndexOf(musteri) == i)
                {
                    MessageBox.Show(musteri + " isimli müşteri bulundu!");
                    break;
                }
            }
        }
    }
}
