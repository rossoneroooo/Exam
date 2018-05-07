using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lozeArea = double.Parse(Console.ReadLine());
            var kgFromSqM = double.Parse(Console.ReadLine());
            var brak = double.Parse(Console.ReadLine());

            var grozde = lozeArea * kgFromSqM;
            var brakLeft = grozde - brak;
            var zaRakia = brakLeft * 0.45;
            var liters = zaRakia / 7.5;
            var income = liters * 9.8;
            var forSale = brakLeft * 0.55;
            var result2 = forSale * 1.5;
            Console.WriteLine("{0:0.00}", income);
            Console.WriteLine("{0:0.00}", result2);
        }
    }
}
