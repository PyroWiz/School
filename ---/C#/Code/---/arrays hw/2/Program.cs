using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] array = new char[8];
            Console.WriteLine("enter 8 chars");


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = char.Parse(Console.ReadLine());
            }

            foreach (char c in array)
            {
                if ((c >= 'a' & c <= 'z') || (c >= 'A' && c <= 'Z'))
                    Console.Write(c + " ");
            }
        }
    }
}
