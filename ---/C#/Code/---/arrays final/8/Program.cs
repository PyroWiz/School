using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = {
            { 1, 1, 1, 1, 1 },
            { 1, 2, 2, 2, 2 },
            { 1, 2, 3, 3, 3 },
            { 1, 2, 3, 4, 4 },
            { 1, 2, 3, 4, 5 }};

            Console.WriteLine(IsCorner(arr));
        }

        static bool IsCorner(int[,] arr)
        {
            int zero = arr.GetLength(0), one = arr.GetLength(1);
            if (zero != one && zero == 1) return false;

            for (int main = 0; main < zero; main++)
            {
                int rows = main;
                int columns = main;
                for (; rows < zero; rows++)
                {
                    if (arr[rows, columns] != main + 1) return false;
                }
                rows = main;
                columns = main;
                for (; columns < one; columns++)
                {
                    if (arr[rows, columns] != main + 1) return false;
                }
            }
            return true;
        }
    }
}
