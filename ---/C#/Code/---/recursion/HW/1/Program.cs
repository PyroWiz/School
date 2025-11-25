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
            Console.WriteLine("enter two numbers for div");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Div(x, y, 0);
        }

        static int Div(int x, int y, int loop)
        {
            if (x < y)
            {
                Console.WriteLine(loop);
                Console.WriteLine(x);
                return 0;
            }

            x -= y;
            loop++;
            return Div(x, y, loop);
        }
    }
}
