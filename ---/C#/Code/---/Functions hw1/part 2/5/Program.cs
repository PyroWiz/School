using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int num = int.Parse(Console.ReadLine());
            Seq(num);
        }

        static void Seq(int num)
        {
            for (int i = 1; i < num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
