using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());
           int count = 0;
            int score = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int z = m; z >= 1; z--)
                {
                    count++;
                    score += i * 2 + z * 3;
                    if (score >= control)
                    {
                        Console.WriteLine("{0} moves", count);
                        Console.WriteLine("Score: {0} >= {1}", score, control); return;
                    }
                  
                }
            }
            Console.WriteLine("{0} moves", count);
        }
    }
}
