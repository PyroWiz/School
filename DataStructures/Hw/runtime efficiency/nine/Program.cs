using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] arr2 = new int[6] { 1, 3, 4, 5, 5, 6 };


            for (int i = 0, j = 0; i < arr.Length && i < arr2.Length;)
            {
                if (arr[i] == arr2[j])
                {
                    Console.WriteLine(arr[i]);
                    i++;
                    j++;    
                }
                if (arr[i] < arr2[j]) i++;

                if (arr[i] > arr2[j]) j++;
            }
        }
    }
}
