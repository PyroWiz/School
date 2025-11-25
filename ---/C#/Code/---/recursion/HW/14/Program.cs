using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bottle('@', 5);
        }

        static void bottle(char tav, int max)
        {
            upper(tav, max, 0);
            lower(tav, 3, max, max / 2 - 1);
        }
        static void upper(char tav, int max, int spaces)
        {
            if (max < 1) return;
            print(' ', spaces);
            print(tav, max);
            Console.WriteLine();
            upper(tav, max - 2, spaces + 1);
        }
        static void lower(char tav, int start, int end, int spaces)
        {
            if (start > end) return;
            print(' ', spaces);
            print(tav, start);
            Console.WriteLine();
            lower(tav, start + 2, end, spaces - 1);
        }
        static void print(char tav, int max)
        {
            if (max == 0) return;
            Console.Write(tav);
            print(tav, max - 1);
        }

    }
}
