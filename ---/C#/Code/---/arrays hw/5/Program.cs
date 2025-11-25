using System;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array lenght");
            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)Math.Pow(i,2);
            }

            foreach (int i in array)
                Console.WriteLine(i);
        }
    }
}
