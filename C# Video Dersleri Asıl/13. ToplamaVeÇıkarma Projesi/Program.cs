using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ToplamaVeÇıkarma_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 5;
            int sayi2 = 12;
            int sayi5 = 10;

            int sayi3 = sayi1 + sayi2 + sayi5;
            int sayi4 = sayi2 - sayi1;
            int sonuc = sayi5 - sayi3;

            Console.WriteLine(sayi3);
            Console.WriteLine(sayi4);
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
