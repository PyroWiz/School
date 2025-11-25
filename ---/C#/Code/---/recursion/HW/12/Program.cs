using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two numbers");
            int group = 4;
            int of = 2;
            Console.WriteLine(Calcl(group, of));
        }

        static int Calcl(int group, int of)
        {
            if (of == 0 || of == group)
                return 1;

            return Calcl(group - 1, of) + Calcl(group - 1, of - 1);
        }
    }
}
