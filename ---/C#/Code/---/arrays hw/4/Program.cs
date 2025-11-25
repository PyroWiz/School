using System;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[12];

            Console.WriteLine("enter 10 numbers");
            for (int i = 0; i < arr.Length - 2; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] == 8 && arr[11] == 0) { arr[10] = i; arr[11]++; }
            }

            Console.WriteLine($"place of the first eight: {arr[10]}");
        }
    }
}
