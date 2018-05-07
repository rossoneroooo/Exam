using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write("+");
            Console.Write(new string('~', ((3*n+1) - (n * 2 + 1) - 2)));
            Console.Write("+");
            Console.WriteLine(new string('.', n*2+1));
        }
    }
}
