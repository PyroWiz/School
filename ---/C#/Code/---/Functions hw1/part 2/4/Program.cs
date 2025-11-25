using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a two digit number");
            int num = int.Parse(Console.ReadLine());
            Duo(num);
        }

        static void Duo(int num)
        {
            if (10 <= num && num <= 99)
            {
                Console.WriteLine((num / 10) + (num % 10));
            }
            else
                Console.WriteLine("Not a two digit number");
        }
    }
}
