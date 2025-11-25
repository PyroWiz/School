using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a char");
            char a = char.Parse(Console.ReadLine());
            Tav(a);
        }
        static void Tav(char a)
        {
            if ((65 <= a && a <= 90) || (97 <= a && a <= 122))
                Console.WriteLine("its a letter");
            else
                Console.WriteLine("its not a letter");
            Console.WriteLine((int)(a));
        }
    }
}
