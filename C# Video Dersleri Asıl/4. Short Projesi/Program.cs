using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Short_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short maxDeger = short.MaxValue;  //-32768 le 32767 arası değerler
            short minDeger = short.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
            Console.ReadLine();
        }
    }
}
