using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İlkSonsayı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btndoldur_Click(object sender, EventArgs e)
        {
            int ilk = Convert.ToInt16(txtilk.Text), son = Convert.ToInt16(txtson.Text);
            for (int i = ilk; i <= son; i++)
            {
                if (i%2==0)
                {
                    lbcift.Items.Add(i);
                }
                if (i%2==1)
                {
                    lbtek.Items.Add(i);
                }
                if (i%3==0)
                {
                    lb3.Items.Add(i);
                }
                if (i%5==0)
                {
                    lb5.Items.Add(i);
                }
            }
        }
        
    }
    
}
