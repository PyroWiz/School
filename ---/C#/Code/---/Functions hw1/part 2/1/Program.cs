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
            Console.WriteLine("enter two numbers");
            double one = double.Parse(Console.ReadLine());
            double two = double.Parse(Console.ReadLine());
            Exe(one,two);
        }
        static void Exe(double one, double two)
        {
            Console.WriteLine($"\nDivide: {one/two:f3}\nWhole: {(int)(one/two)}\nRemainder: {one%two}");
        }
    }
}
