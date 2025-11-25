using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = {
                { 1, 1, 2, 1, 1 },
                { 2, 2, 2, 1, 2 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 2, 1, 1 },
                { 1, 1, 2, 1, 1 } };
            Slit1(arr);
            Console.WriteLine();
            Slit2(arr);
            Console.WriteLine();

            Console.WriteLine(Checker(arr));
        }

        static void Slit1(int[,] arr)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i, i]);
            }
        }

        static void Slit2(int[,] arr)
        {
            for (int pos1 = 0, pos2 = 4; pos2 >= 0; pos2--, pos1++)
            {
                Console.WriteLine(arr[pos1, pos2]);
            }
        }

        static bool Checker(int[,] arr)
        {
            int c = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                c = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 == 0)
                    {
                        c++;
                    }
                }
                if (c >= arr.GetLength(0)) return true;
            }
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                c = 0;
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[j, i] % 2 == 0)
                    {
                        c++;
                    }
                }
                if (c >= arr.GetLength(0)) return true;
            }
            return false;
        }
    }
}
