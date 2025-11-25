using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two numbers");
            int one = 60;
            int two = 73;
            Console.WriteLine(GCD(one, two));
        }

        static int GCD(int big, int small)
        {
            if (big < small)
            {
                int temp = big;
                big = small;
                small = temp;
            }

            if (small == 0) return big;

            return GCD(small, big % small);
        }

    }
}
