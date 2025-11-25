using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Pos(arr, 0, 0);
        }

        static int Pos(int[] arr, int count, int indx)
        {
            if (indx > arr.Length - 1) { Console.WriteLine(count); return 0; }
            else if (arr[indx] % 2 == 0)
                count++;

            indx++;
            return Pos(arr, count, indx);
        }
    }
}
