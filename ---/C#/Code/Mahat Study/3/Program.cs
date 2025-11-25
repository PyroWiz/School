using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] slots = new int[100];
            int[] occ = new int[100];

            for (int i = 0; i < 40; i++)
            {
                int num = rnd.Next(10, 100);
                slots[num] = num;
                occ[num]++;
            }

            int highest = 0, hnum = 0;

            for (int i = 10; i < 100; i++)
            {
                if (occ[i] > highest) { highest = occ[i]; hnum = slots[i]; }
                if (slots[i] == 0) Console.WriteLine($"number {i} has not been generated");
            }

            Console.WriteLine($"\nthe num that was generated the most was {hnum}, {highest} times");
        }
    }
}
