using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesap_Click(object sender, EventArgs e)
        {
            byte not;
            not = Convert.ToByte(txtnot.Text);
            txtnot.Text = "";
            if (not <= 25) lblnot.Text = "Sıfır";
            else if (not <= 50) lblnot.Text = "Başarısız";
            else if (not <= 60) lblnot.Text = "Geçer";
            else if (not <= 70) lblnot.Text = "Orta";
            else if (not <= 85) lblnot.Text = "İyi";
            else if (not <= 100) lblnot.Text = "Pek İyi";
            else
            {
                MessageBox.Show("Lütfen 0-100 arasında bir sayı giriniz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
