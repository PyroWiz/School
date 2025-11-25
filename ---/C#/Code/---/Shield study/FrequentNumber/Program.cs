using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1,2,3,4,4 };
            int[] arr2 = new int[] { 2 };
            Console.WriteLine(Freq(arr1, arr2));
        }
        public static int Freq(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1.Length - i - 1; j++)
                {
                    if (arr1[j] > arr1[j + 1])
                    {
                        int temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                }
            }
            int highestbar = 0;
            int highest = 0;
            int counter = 0;
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                bool check = true;
                if (arr1[i] == arr1[i + 1])
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr1[i] == arr2[j]) check = false;
                    }
                    if (!check) continue;
                    counter++;
                    if (counter > highestbar)
                    {
                        highest = arr1[i];
                        highestbar = counter;
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            return highest;
        }

    }

}
