using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            int sum = Ro(n);
            Console.WriteLine();
            Console.WriteLine($"sum: {sum}");
        }

        static int Ro(int n)
        {
            n -= 2;
            if (n < 1) return 0;
            Console.Write($"{n},");
            return n + Ro(n);
        }
    }
}
