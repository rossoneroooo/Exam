using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var houseArea = double.Parse(Console.ReadLine());
            var numberWindows = double.Parse(Console.ReadLine());
            var stiroporSqM = double.Parse(Console.ReadLine());
            var StiroporPrice = double.Parse(Console.ReadLine());

            var houseAreaWithoutWindows = houseArea - numberWindows * 2.4;
            var adding = houseAreaWithoutWindows * 0.1 + houseAreaWithoutWindows;
            var neededPalets = Math.Ceiling(adding / stiroporSqM);
            var result1 = neededPalets * StiroporPrice;
            //Console.WriteLine(result1);

            if (result1<budget)
            {
                Console.WriteLine("Spent: {0:0.00}", result1);
                Console.WriteLine("Left: {0:0.00}", budget-result1);
            }
            else
            {
                Console.WriteLine("Need more: {0:0.00}", Math.Abs(result1-budget));
            }
        }
    }
}
