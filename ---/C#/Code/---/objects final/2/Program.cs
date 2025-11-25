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
            Fibunachi one = new Fibunachi(20);

            Console.WriteLine(one.ToString());

            Console.WriteLine(one.GetTermNumber(10));
        }
    }
}
