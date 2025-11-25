using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            char p = '1';

            while (p != '!')
            {
                Console.WriteLine("\nEnter +,-,/ or * for operations between two numbers, ! to stop the program");
                double one = double.Parse(Console.ReadLine());
                p = char.Parse(Console.ReadLine()); if (p == '!') break;
                double two = double.Parse(Console.ReadLine());

                switch (p)
                {
                    case '+':
                        Console.WriteLine(Plus(one, two));
                        break;
                    case '-':
                        Console.WriteLine(Minus(one, two));
                        break;
                    case '*':
                        Console.WriteLine(Multi(one, two));
                        break;
                    case '/':
                        Console.WriteLine(Divide(one, two));
                        break;
                }
            }
        }

        static double Plus(double one, double two)
        {
            return (one + two);
        }
        static double Minus(double one, double two)
        {
            return (one - two);
        }
        static double Multi(double one, double two)
        {
            return (one * two);
        }
        static double Divide(double one, double two)
        {
            return (one / two);
        }


    }
}
