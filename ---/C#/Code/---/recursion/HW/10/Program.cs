using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number base 10");
            int x = 4235;
            Console.WriteLine(Eight(x, ""));
        }

        static string Eight(int x, string y)
        {
            if (x < 1) return y;
            y = (x % 8).ToString() + y;
            return Eight(x / 8, y);
        }
    }
}
