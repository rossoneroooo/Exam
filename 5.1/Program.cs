using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write("+");
            Console.Write(new string('~', ((3 * n + 1) - (n * 2 + 1) - 2)));
            Console.Write("+");
            Console.WriteLine(new string('.', n * 2 + 1));

            for (int i = 0; i < n * 2 + 1; i++)
            {
                Console.Write("|");
                Console.Write(new string('.', i));
                Console.Write("\\");
                Console.Write(new string('~', (3 * n + 1) - (n * 2 + 3)));
                Console.Write("\\");
                Console.WriteLine(new string('.', (3 * n + 1) - i - 3 - ((3 * n + 1) - (n * 2 + 3))));
            }
            for (int z = 0; z < n * 2 + 1; z++)
            {
                Console.Write(new string('.', z));
                Console.Write("\\");
                Console.Write(new string('.', (n * 2 - z)));
                Console.Write("|");
                Console.Write(new string('~', ((3 * n + 1) - (n * 2 + 1) - 2)));
                Console.WriteLine("|");
            }
            Console.Write(new string('.', n*2+1));
            Console.Write("+");
            Console.Write(new string('~', ((3 * n + 1) - (n * 2 + 3))));
            Console.WriteLine("+");

        }
    }
}
