using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.İnt_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // byte 1 byte yer kaplar
            // short 2 byte yer kaplar
            // int 4 byte yer kaplar

            int maxDeger = int.MaxValue;
            int minDeger = int.MinValue;

            int a = 16;
            int b = 13;

            int c = a+b;

            Console.WriteLine(c);

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
            Console.ReadLine();
        }
    }
}
