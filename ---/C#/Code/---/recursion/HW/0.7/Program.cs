using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4 };
            Console.WriteLine("big: " + Big(arr, 0, 0));
            Console.WriteLine("small: " + Small(arr, 0, arr[0]));
            Console.WriteLine("sum: " + Sum(arr, 0, 0));
            Console.WriteLine("multi: " + Multi(arr, 1, arr[0]));
            Console.WriteLine($"avg: {Avg(arr, 0, 0):f3}");
        }

        static int Big(int[] arr, int step, int biggest)
        {
            if (step > arr.Length - 1) return biggest;
            if (biggest < arr[step]) biggest = arr[step];
            return Big(arr, step + 1, biggest);
        }

        static int Small(int[] arr, int step, int small)
        {
            if (step > arr.Length - 1) return small;
            if (small > arr[step]) small = arr[step];
            return Small(arr, step + 1, small);
        }

        static int Sum(int[] arr, int step, int sum)
        {
            if (step > arr.Length - 1) return sum;
            return Sum(arr, step + 1, sum += arr[step]);
        }

        static int Multi(int[] arr, int step, int multi)
        {
            if (step > arr.Length - 1) return multi;
            return Multi(arr, step + 1, multi *= arr[step]);
        }

        static double Avg(int[] arr, int step, int avg)
        {
            if (step > arr.Length - 1) return ((double)(avg / (double)arr.Length));
            return Avg(arr, step + 1, avg += arr[step]);
        }
    }
}
