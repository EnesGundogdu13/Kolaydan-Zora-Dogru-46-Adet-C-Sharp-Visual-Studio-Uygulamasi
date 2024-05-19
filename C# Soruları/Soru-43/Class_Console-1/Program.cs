using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Console_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayıyı girin!");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. sayıyı girin!");
            int sayi2 = int.Parse(Console.ReadLine());
            Dikdortgen d = new Dikdortgen(sayi1, sayi2);
            Console.WriteLine("dikdörtgenin alanı: " + d.alan() + "\n");
            Console.WriteLine("dikdörtgenin çevresi: " + d.cevre() + "\n");
            Console.ReadKey();
        }
    }
}
