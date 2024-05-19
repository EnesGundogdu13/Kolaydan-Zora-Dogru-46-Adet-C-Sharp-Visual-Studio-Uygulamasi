using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, birler, onlar, yuzler;
            sayi = Convert.ToInt16(txtsayi.Text);
            birler = sayi % 10;
            onlar = (sayi /10)%10;
            yuzler = sayi / 100;
            string ifade = "";

            if (yuzler == 9) ifade = ifade + "Dokuz Yüz ";
            else if (yuzler == 8) ifade = ifade + "Sekiz Yüz ";
            else if (yuzler == 7) ifade = ifade + "Yedi Yüz ";
            else if (yuzler == 6) ifade = ifade + "Altı Yüz ";
            else if (yuzler == 5) ifade = ifade + "Beş Yüz ";
            else if (yuzler == 4) ifade = ifade + "Dört Yüz ";
            else if (yuzler == 3) ifade = ifade + "Üç Yüz ";
            else if (yuzler == 2) ifade = ifade + "İki Yüz ";
            else if (yuzler == 1) ifade = ifade + "Yüz ";

            if (onlar == 9) ifade = ifade + "Doksan ";
            else if (onlar == 8) ifade = ifade + "Seksen ";
            else if (onlar == 7) ifade = ifade + "Yetmiş ";
            else if (onlar == 6) ifade = ifade + "Altmış ";
            else if (onlar == 5) ifade = ifade + "Elli ";
            else if (onlar == 4) ifade = ifade + "Kırk ";
            else if (onlar == 3) ifade = ifade + "Otuz ";
            else if (onlar == 2) ifade = ifade + "Yirmi ";
            else if (onlar == 1) ifade = ifade + "On ";

            if (birler == 9) ifade = ifade + "Dokuz";
            else if (birler == 8) ifade = ifade + "Sekiz";
            else if (birler == 7) ifade = ifade + "Yedi";
            else if (birler == 6) ifade = ifade + "Altı";
            else if (birler == 5) ifade = ifade + "Beş";
            else if (birler == 4) ifade = ifade + "Dört";
            else if (birler == 3) ifade = ifade + "Üç";
            else if (birler == 2) ifade = ifade + "İki";
            else if (birler == 1) ifade = ifade + "Bir";
            lblsonuc.Text = ifade;
        }
    }
}
