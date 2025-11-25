using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            int num = int.Parse(Console.ReadLine());
            Abs(num);
        }

        static void Abs(int num)
        {
            if (num < 0)
                num *= -1;

            Console.WriteLine($"Abs value: {num}");

        }
    }
}
