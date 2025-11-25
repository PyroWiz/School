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
            Person one = new Person("ido");
            Person two = new Person(one);

            Console.WriteLine(one.ToString());
            Console.WriteLine(two.ToString());
        }
    }
}
