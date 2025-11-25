using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mol(1, 1);
        }

        static int Mol(int x, int y)
        {
            if (y > 10) return 0;
            if (x > 10)
            {
                y++; x = 1; Console.WriteLine();
            }
            if (y <= 10) Console.Write(x * y + "\t");
            x++;
            return Mol(x, y);
        }
    }
}
