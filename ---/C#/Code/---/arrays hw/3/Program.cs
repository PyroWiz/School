using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 6 numbers: ");

            int[] arr = new int[6];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    Console.Write(arr[i] + ",");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    Console.WriteLine("index num " + i);
            }


        }
    }
}
