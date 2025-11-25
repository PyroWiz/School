using System.Numerics;

namespace a___b_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int total = 0;
            int loop = 0;

            do
            {
                Console.WriteLine("enter two numbers:");
                Console.Write("a:");
                a = int.Parse(Console.ReadLine());
                Console.Write("b:");
                b = int.Parse(Console.ReadLine());
                total += a + b;
                loop+=2;

            } while (total <= a && loop < b);

            Console.Write("loop ended,all numbers added together:");
            Console.WriteLine(total);
        }
    }
}
