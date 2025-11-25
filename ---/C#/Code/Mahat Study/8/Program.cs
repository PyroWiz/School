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
            int[] arr = new int[] { 1, 2, 4 ,2};
            Console.WriteLine(IsEvenPalindrom(arr));
        }

        public static bool IsPalindrom(int[] arr)
        {
            int[] flip = new int[arr.Length];
            for (int i = arr.Length - 1, j = 0; i >= 0; i--, j++)
            {
                flip[j] = arr[i];
            }

            for (int i = 0; i < flip.Length; i++)
            {
                if (flip[i] != arr[i]) return false;
            }

            return true;
        }

        public static bool IsEvenPalindrom(int[] arr)
        {
            int length = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) length++;
            }
            int[] even = new int[length];

            for (int i = 0, pos = 0;  i < arr.Length && pos < even.Length; i++)
            {

                if (arr[i] % 2 == 0)
                {
                    even[pos] = arr[i];
                    pos++;
                }
            }

            return IsPalindrom(even);
        }
    }
}
