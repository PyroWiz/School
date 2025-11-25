using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            Check(num);
        }

        static void Check(int num)
        {
            if (num % 2 == 0)
                Console.WriteLine("even number");

            else
                Console.WriteLine("odd number");
        }
    }
}
