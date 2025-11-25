using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two whole numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Multiple(a, b));
        }
        static int Multiple(int a, int b)
        {
            int temp = 0;
            for (int i = 1; i <= b; i++)
            {
                temp += a;
            }
            return temp;
        }
    }
}
