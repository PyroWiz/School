using System;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter 8 numbers");

            int[] array = new int[8];
            bool a = false;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (i >= 2) if (array[i] == (array[i - 1] + array[i - 2])) a = true;

            }

            if (a)
                Console.WriteLine("there is");
            else
                Console.WriteLine("there isnt");
        }
    }
}
