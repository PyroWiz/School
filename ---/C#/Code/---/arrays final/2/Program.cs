using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[12] { 7, 3, 8, -6, 0, 3, 3, 9, -1, 0, 11, 2 };

            int check = 0;

            if (arr.Length % 3 == 0) check++;

                int third = arr.Length / 3;
            int tcheck = 0;

            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < third; j++)
                {
                    sum += arr[j];
                }
                if (sum % 3 == 0) tcheck++;
            }
            if (tcheck == 3) check++;

            tcheck = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 3) tcheck++;
            }

            if (tcheck == 3) check++;

            if (check >= 3) Console.WriteLine("the array is a triangle");
            else Console.WriteLine("array isnt a triangle");
        }
    }
}
