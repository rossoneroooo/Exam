using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());
            var electricityBill = 0.0;
            var electricityPreviousMonth = 0.0;
            var electricity = 0.0;

            for (int i = 1; i <= months; i++)
            {
                electricityBill = double.Parse(Console.ReadLine());
                electricity+=electricityBill;
                
            }
            Console.WriteLine("Electricity: {0:0.00} lv", electricity);
            Console.WriteLine("Water: {0:0.00} lv", months*20);
            Console.WriteLine("Internet: {0:0.00} lv", months * 15);
            Console.WriteLine("Other: {0:0.00} lv", (electricity+months*35)+ ((electricity + months * 35)*0.2));
            Console.WriteLine("Average: {0:0.00} lv", (electricity+ months*35+ (electricity + months * 35) + ((electricity + months * 35) * 0.2))/months);
        }
    }
}
