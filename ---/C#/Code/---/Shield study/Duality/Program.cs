using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2 };
            int[] arr2 = new int[] { 36, 4 };
            Console.WriteLine(ArrayCompare(arr1, arr2));
        }

        public static int Duality(int num)
        {
            int naw = 0;
            while (num > 0)
            {
                if ((num % 10) % 2 == 0) naw += num % 10;
                num /= 10;
            }
            return naw;
        }
        public static bool ArrayDuality(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Duality(arr[i]) == Duality(arr[j])) return false;
                }
            }
            return true;
        }
        public static bool ArrayCompare(int[] arr1, int[] arr2)
        {
            if (!(ArrayDuality(arr1) && ArrayDuality(arr2))) return false;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (Duality(arr1[i]) == Duality(arr2[j])) return false;
                }
            }
            return true;
        }
    }
}
