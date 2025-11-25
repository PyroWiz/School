using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat =
            {
                {31,  8, 10,  12},
                { 4, 12, 10,  27},
                {11,  6,  4,  14},
                {19,  1,  4, 100},
                { 12,  2, 15,  15},
                { 7 , 1 ,7  , 7   }
            };

            int[] arr = { 4, 12, 15, 100 };

            Console.WriteLine(IsPair(mat, arr));
        }
        static bool IsExtreme(int[,] mat, int col, int value)
        {
            int small = mat[0, col], big = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                if (mat[i, col] > big) big = mat[i, col];

                if (mat[i, col] < small) small = mat[i, col];
            }

            if (value == small) return true;
            if (value == big) return true;

            return false;
        }

        static bool IsPair(int[,] mat, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsExtreme(mat, i, arr[i]) == false) return false;
            }
            return true;
        }
    }
}
