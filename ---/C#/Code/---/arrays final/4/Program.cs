using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int pass = 11;

            Console.WriteLine(getPass(arr, pass));
        }

        static bool getPass(int[] arr, int pass)
        {
            int temp = 0;
            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] == pass) { Console.WriteLine("pass already used"); return false; }

            }

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = pass;

            Console.WriteLine(arr[0]);
            return true;
        }
    }
}
