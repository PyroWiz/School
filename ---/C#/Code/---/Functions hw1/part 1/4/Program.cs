using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter big letter");
            char a = char.Parse(Console.ReadLine());
            Console.WriteLine(Capp(a));
        }

        static char Capp(char a)
        {
            return ((char)(a+32));
        }
    }
}
