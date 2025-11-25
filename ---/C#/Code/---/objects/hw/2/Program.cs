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
            Plant one = new Plant();
            Plant two = new Plant();
            Plant three = new Plant();

            one.SetName("adwasdwasd");
            one.SetColor("red");
            one.SetSize('a');
            one.SetWater(4);

            Console.WriteLine(one.GetWater()); // etc 
        }
    }
}
