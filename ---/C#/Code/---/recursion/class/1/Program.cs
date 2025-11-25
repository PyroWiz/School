using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter whole number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(n));
        }

        static int Sum(int n)
        {
            if (n == 1) return 1;
            return n + Sum(n - 1);
        }
    }
}
