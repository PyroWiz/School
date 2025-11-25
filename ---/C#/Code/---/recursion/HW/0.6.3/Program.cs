using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            int sum = Ra(n, 0, 1);
            Console.WriteLine();
            Console.WriteLine($"sum: {sum}");
        }

        static int Ra(int limit, int num, int diff)
        {
            if (num > limit) return 0;
            Console.Write(num + " , ");
            return num + Ra(limit, num + diff, diff + 1);
        }
    }
}
