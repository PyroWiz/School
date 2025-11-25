using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Binary(555));
        }

        public static string Binary(int input)
        {
            if (!(input >= 0)) return "only positive numbers";

            string binary = "";

            while (input > 0)
            {
                int remainder = input % 2;
                binary = remainder + binary;
                input /= 2;
            }
            return binary;
        }
    }
}
