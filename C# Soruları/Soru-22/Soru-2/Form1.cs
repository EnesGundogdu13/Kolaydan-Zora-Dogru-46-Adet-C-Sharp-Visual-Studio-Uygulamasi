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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            char harf = Convert.ToChar(e.KeyCode);
            lblharf.Text = harf.ToString();
            switch(harf)
            {
                case 'A':
                    pbhayvan.Image = ilhayvanlar.Images[0];
                    lblhismi.Text = "Ayı";
                    break;
                case 'B':
                    pbhayvan.Image= ilhayvanlar.Images[1];
                    lblhismi.Text = "Balık";
                    break;
                case 'C':
                    pbhayvan.Image = ilhayvanlar.Images[2];
                    lblhismi.Text = "Ceylan";
                    break;
                case 'D':
                    pbhayvan.Image = ilhayvanlar.Images[3];
                    lblhismi.Text = "Deve";
                    break;
                case 'E':
                    pbhayvan.Image = ilhayvanlar.Images[4];
                    lblhismi.Text = "Eşek";
                    break;
                case 'F':
                    pbhayvan.Image = ilhayvanlar.Images[5];
                    lblhismi.Text = "Fare";
                    break;
                case 'G':
                    pbhayvan.Image = ilhayvanlar.Images[6];
                    lblhismi.Text = "Goril";
                    break;
                default:
                    pbhayvan.Image = ilhayvanlar.Images[7];
                    lblhismi.Text = "None";
                    break;
            }
        }
    }
}
