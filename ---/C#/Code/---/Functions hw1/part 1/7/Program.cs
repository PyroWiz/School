using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter whole number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Plus(a));
        }

        static int Plus(int a)
        {
            int temp = 0;

            while (a >0)
            {
                temp += a % 10;
                a /= 10;
            }
            return temp;
        }
    }
}
