using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine().ToLower();
            var km = double.Parse(Console.ReadLine());
            var sallary = 0.0;
            var taxes = 0.0;
            if (km <= 5000)
            {
                if (season == "summer")
                {
                    sallary = km * 0.9 * 4;
                    taxes = sallary * 0.1;
                    Console.WriteLine("{0:0.00}", sallary - taxes);
                }
                else if (season == "winter")
                {
                    sallary = km * 1.05 * 4;
                    taxes = sallary * 0.1;
                    Console.WriteLine("{0:0.00}", sallary - taxes);
                }
                else if (season == "autumn" || season == "spring")
                {
                    sallary = km * 0.75 * 4;
                    taxes = sallary * 0.1;
                    Console.WriteLine("{0:0.00}", sallary - taxes);
                }
            }
            else if (km > 5000 && km <= 10000)
            {
                if (season == "summer")
                {
                    sallary = km * 1.1 * 4;
                    taxes = sallary * 0.1;
                    Console.WriteLine("{0:0.00}", sallary - taxes);
                }
                else if (season == "winter")
                {
                    sallary = km * 1.25 * 4;
                    taxes = sallary * 0.1;
                    Console.WriteLine("{0:0.00}", sallary - taxes);
                }
                else if (season == "autumn" || season == "spring")
                {
                    sallary = km * 0.95 * 4;
                    taxes = sallary * 0.1;
                    Console.WriteLine("{0:0.00}", sallary - taxes);
                }
            }
            else if (km > 10000 && km <= 20000)
            {

                sallary = km * 1.45 * 4;
                taxes = sallary * 0.1;
                Console.WriteLine("{0:0.00}", sallary - taxes);

            }
        }
    }
}
