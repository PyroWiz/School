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
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Print(a));
        }

        static int Print(int a)
        {
            int sum = 0;
            for (int i = 1; i < a; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
