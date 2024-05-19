using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_41
{
    class Program
    {
        static void UcgenHesaplama(int kenar1, int kenar2, int kenar3)
        {
            if (kenar1==kenar2&&kenar1==kenar3)
            {
                Console.Write("Eşkenar Üçgen");
            }
            else if (kenar1!=kenar2&&kenar1!=kenar3)
            {
                Console.Write("Çeşitkenar Üçgen");
            }
            else 
            {
                Console.Write("İkizkenar Üçgen");
            }
          

            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.Kenarı Giriniz:");
            int kenar1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2.Kenarı Giriniz:");
            int kenar2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("3.Kenarı Giriniz:");
            int kenar3 = Convert.ToInt16(Console.ReadLine());
            UcgenHesaplama(kenar1, kenar2, kenar3);
            Console.ReadKey();
        }
    }
}