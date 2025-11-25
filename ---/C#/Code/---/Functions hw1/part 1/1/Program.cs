using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Add(a));
        }

        static int Add(int a)
        {
            return a = (a / 10) + (a % 10); ;
        }
    }
}
