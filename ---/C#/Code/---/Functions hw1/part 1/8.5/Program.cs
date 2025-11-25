using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int big = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"enter number {i}: ");
                int a = int.Parse(Console.ReadLine());
                if (Plus(a) > big) { big = Plus(a); }
            }

            Console.WriteLine(big);
        }

        static int Plus(int a)
        {
            int temp = 0;

            while (a > 0)
            {
                if ((a % 10) % 2 == 0) { temp += a % 10; }
                a /= 10;
            }
            return temp;
        }
    }
}
