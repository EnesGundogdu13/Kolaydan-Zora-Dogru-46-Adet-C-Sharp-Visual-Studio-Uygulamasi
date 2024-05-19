using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Form_1
{
    class Daire
    {
        private double r;
        public Daire(double r)
        {
            this.r = r;
        }
        public double alanhesapla()
        {
            return 3.14 * r * r;
        }
        public double cevrehesapla()
        {
            return 2 * 3.14 * r;
        }
    }
}
