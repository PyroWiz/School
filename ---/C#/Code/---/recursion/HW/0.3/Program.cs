using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two numbers");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(Po(x, y));
        }

        static int Po(int x, int y)
        {
            if (y == 0) return 1;
            return x * Po(x, y - 1);
        }
    }
}
