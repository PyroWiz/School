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
            int[] arrayone = new int[8];

            for (int i = 1; i <= arrayone.Length; i++)
            {
                Console.WriteLine($"enter number {i}");
                arrayone[i - 1] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < arrayone.Length; i++)
            {
                Console.Write(arrayone[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arrayone.Length; i++)
            {
                if (arrayone[i] % 2 == 0) Console.Write(arrayone[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arrayone.Length; i++)
            {
                if (arrayone[i] >= 0) Console.Write(arrayone[i] + " ");
            }
            Console.WriteLine();
            for (int i = arrayone.Length; i > 0; i--)
            {
                Console.Write(arrayone[i - 1] + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"{arrayone[0] = 5} , {arrayone[arrayone.Length - 1] = 10}");


        }
    }
}
