using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Operatorler_Projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 23;
            sayi++;

            int sayi2 = 52;
            sayi2 += 8;

            if (sayi == 24)
            {
                Console.WriteLine("sayi artırılmıs");
            }
            else 
            {
                Console.WriteLine(sayi);
            }
            

            Console.WriteLine(sayi2);
            Console.ReadLine();
        }
    }
}
