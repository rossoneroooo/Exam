using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());
            int numCombinations = 0;
            int sumOfNumbers = 0;
            bool checkControlNum = false;
            for (int combination1 = 1; combination1 <= firstNum; combination1++)
            {
                for (int combination2 = secondNum; combination2 >= 1; combination2--)
                {
                    numCombinations++;
                    sumOfNumbers += combination1 * 2 + combination2 * 3;
                    if (sumOfNumbers >= controlNum)
                    {
                        checkControlNum = true;
                        break;
                    }
                }
                if (checkControlNum) break;
            }

            Console.WriteLine("{0} moves", numCombinations);

            if (checkControlNum)
            {
                Console.WriteLine("Score: {0} >= {1}", sumOfNumbers, controlNum);
            }
        }
    }
}
