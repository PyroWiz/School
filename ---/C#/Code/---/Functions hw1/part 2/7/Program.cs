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
            Console.WriteLine("enter two numbers");
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            Power(one,two);
        }

        static void Power(int one, int two)
        {
            int temp = one;
            for (int i= 1;i<two;i++)
            {
                one *= temp;
            }
            Console.WriteLine(one);
        }
    }
}
