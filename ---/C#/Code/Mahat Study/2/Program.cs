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
            int c = 0;
            while (true)
            {
                Console.WriteLine("enter string");
                string s = Console.ReadLine();
                if (s.Length % 2 != 0) break;
                if (s.Contains('Z')) Console.WriteLine("does contain 'Z'");
                if (s[0] == s[s.Length - 1]) c++;
            }
            Console.WriteLine($"similar: {c}");
        }
    }
}
