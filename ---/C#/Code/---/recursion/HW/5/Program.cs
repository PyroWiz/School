using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(multiply(3, 3));
        }
        public static int multiply(int x, int y)
        {
            if (x == 1)
                return y;
            else
            {
                return multiply(x - 1, y) + y;
            }
        }
    }
}
