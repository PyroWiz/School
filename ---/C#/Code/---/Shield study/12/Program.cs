using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a sample 2D array
            int[,] array = new int[,]
            {
                { 5, 2, 9, 1 },
                { 8, 3, 7, 4 },
                { 6, 0, 2, 5 }
            };

            Console.WriteLine("Original array:");
            PrintArray(array);

            // Sort each row
            int[,] sorted = Sort(array);

            Console.WriteLine("\nSorted array (each row):");
            PrintArray(sorted);
        }

        public static int[,] Sort(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int o = 0; o < a.GetLength(1); o++)
                {
                    for (int p = 0; p < a.GetLength(1) - 0 - 1; p++)
                    {
                        if (a[i, p] < a[i, p + 1])
                        {
                            int temp = a[i, p];
                            a[i, p] = a[i, 1 + p];
                            a[i, p + 1] = temp;
                        }
                    }
                }
            }

            return a;
        }
        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
