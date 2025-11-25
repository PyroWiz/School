using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigger_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 2, 9, 3, 6 };
            int[] ara = new int[] { 0, 0, 0 };
            int[] arb = new int[] { 0, 0, 0 };
            Divide(arr, ara, arb);

            foreach (int i in arr)
                Console.WriteLine(i);
        }

        public static bool IsBig(int[] ara, int[] arb)
        {
            for (int i = 0; i < ara.Length; i++)
            {
                if (ara[i] <= arb[i]) return false;
            }

            return true;
        }

        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i -1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void Divide(int[] arr, int[] a, int[] b)
        {
            BubbleSort(arr);

            for (int i = 0, k = 0; i < arr.Length / 2; i += 2, k++)
            {
                b[k] = arr[i];
                a[k] = arr[i + 1];
            }
        }

        public static void DivideBet(int[] arr, int[] a, int[] b)
        {
            for (int i = 0, k = 0; k < arr.Length / 2; i += 2, k++)
            {
                a[k] = Math.Max(arr[i], arr[i + 1]);
                b[k] = Math.Min(arr[i], arr[i + 1]);
            }
        }

    }
}
