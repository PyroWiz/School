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
            Console.WriteLine("enter 3 numbers");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine(Avg(num1, num2, num3));


        }
        static double Avg(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }

    }
}
