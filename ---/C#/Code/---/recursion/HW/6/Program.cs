using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "abba";
            Console.WriteLine(Pali(name, name.Length - 1, true, 0));
        }

        static bool Pali(string name, int index, bool check, int step)
        {
            if (index < name.Length / 2)
            {
                return check;
            }

            if (name[index] == name[step])
                check = true;
            else
            {
                check = false;
                return check;
            }

            return Pali(name, index - 1, check, step + 1);
        }
    }
}
