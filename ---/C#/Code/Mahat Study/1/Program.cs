using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 20 numbers");
            int doubles = 0, positive = 0;
            for (int i = 0; i < 20; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0) positive++;
                int dig = 0;
                while (num > 0)
                {
                    dig++;
                    num /= 10;
                }
                if (dig == 2) doubles++;
            }

            Console.WriteLine($"double digits: {doubles}, positives: {positive}");
        }

    }

}
