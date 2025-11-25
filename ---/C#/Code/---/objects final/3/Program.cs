using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car one = new Car("subaru","wan",3.2000,3);
            Console.WriteLine(one.ToString());
        }
    }
}
