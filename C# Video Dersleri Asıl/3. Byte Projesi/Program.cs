using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Byte_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte birinci = 23;
            byte ikinci = 73;
            byte ucuncu = 255; // 0 dan 255e
            byte maxDeger = byte.MaxValue;
            byte minDeger = byte.MinValue;

            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            Console.WriteLine(ucuncu);
            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
            Console.ReadLine();
        }
    }
}
