using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 3, 3 ,3};

            Console.WriteLine(Sum(arr, 0, 0));
        }


        public static int Sum(int[] arr, int sum, int point)
        {
            if (point > arr.Length - 1) return sum;
            return Sum(arr, sum + arr[point], ++point);
        }
    }
}
