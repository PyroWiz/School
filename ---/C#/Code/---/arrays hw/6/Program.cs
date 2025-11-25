using System;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            while (true)
            {
                Console.WriteLine("enter even number");
                length = int.Parse(Console.ReadLine());
                if (length % 2 == 0) break;
            }

            int[] array = new int[length];
            int br = length / 2 ;

            for (int i = 0; i < br; i++)
            { 
                array[i] = 0;
            }
            for (int i = br; i < array.Length; i++)
            {
                array[i] = 1;
            }

            foreach (int i in array)
                Console.WriteLine(i);
        }
    }
}
