using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "####$$$$$";
            Console.WriteLine(Check(s));
        }

        static bool Check(string s)
        {
            foreach (char c in s)
            {
                if (!(c == '$' || c == '#')) return false;
            }
            return true;
        }

    }
}
