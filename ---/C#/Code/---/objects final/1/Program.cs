using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aircraft[] one = new Aircraft[4];
            for (int i = 0; i < 4; i++)
            {
                one[i] = new Aircraft(0);
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(one[i].ToString());
            }
        }
    }
}
