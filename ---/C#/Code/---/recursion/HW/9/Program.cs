using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enters digits to make a number, non digit to stop 0-9");
            int x = Digi("");
            Console.WriteLine(x);
        }

        static int Digi(string b)
        {
            char a = char.Parse(Console.ReadLine());
            if (a >= '0' && a <= '9')
            {
                b += a;
            }
            else
                return int.Parse(b);

            return Digi(b);
        }
    }
}
