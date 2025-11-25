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
            int[,] arr = new int[5, 5];
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("row " + (i + 1));
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int check = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % num == 0) check++;
                }
                if (check == arr.GetLength(1)) Console.WriteLine("all divided in row: " + (i + 1));
            }
        }
    }
}
