using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public static bool IsPerfectK(int[] arr, int k)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length && i < k; i++)
            {
                sum += arr[i];
            }

            if (sum % k == 0) return true;
            else return false;
        }

        public static bool IsSuperPerfect(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (!IsPerfectK(arr, i)) return false;
            }
            return true;
        }
    }
}
