using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Console_1
{
    class Dikdortgen
    {
        int a, b;
        public Dikdortgen(int a , int b)
        {
            this.a = a;
            this.b = b;
        }
        public int alan()
        {
            Console.WriteLine("Çevre Hesaplanıyor...");
            return a * b;
        }
        public int cevre()
        {
            Console.WriteLine("Çevre Hesaplanıyor...");
            return 2 * (a + b);
        }
    }
}
