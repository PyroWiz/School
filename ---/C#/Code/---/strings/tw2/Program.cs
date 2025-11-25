using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a sentence");
            string s = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && count == 0)
                {
                    Console.WriteLine(s[i - 1]);
                }
                if (s[i] == ' ') count++;
            }
            Console.WriteLine(++count);
        }
    }
}
