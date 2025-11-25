using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            IntegersVector integers = new IntegersVector();
            //checking if array is empty:
            Console.WriteLine($"vector is empty: {integers.IsEmpty()}");
            //checking array size:
            Console.WriteLine($"number of values: {integers.Size()}");
            //creating random numbers and adding them to vector.
            for (int i = 0; i < 20; i++)
                integers.Add(rand.Next(100));
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            //showing the random numbers.
            Console.WriteLine("Vector values: ");
            for (int i = 0; i < integers.Size(); i++)
                Console.Write(integers.Get(i) + " ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            //checking if array is empty:
            Console.WriteLine($"vector is empty: {integers.IsEmpty()}");
            //checking array size:
            Console.WriteLine($"number of values: {integers.Size()}\n");
        }
    }
}
