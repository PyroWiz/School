using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main()
        {
            int[] digits = { 1, 2, 3 };
            Permute(digits, 0);
        }
        static void Permute(int[] arr, int l)
        {
            if (l == arr.Length - 1)
            {
                Console.WriteLine(string.Join("", arr));
                return;
            }

            for (int i = l; i < arr.Length; i++)
            {
                // swap arr[l] and arr[i]
                int tmp = arr[l];
                arr[l] = arr[i];
                arr[i] = tmp;

                // recurse on the next position
                Permute(arr, l + 1);

                // backtrack (swap back)
                tmp = arr[l];
                arr[l] = arr[i];
                arr[i] = tmp;
            }
        }
    }

}
