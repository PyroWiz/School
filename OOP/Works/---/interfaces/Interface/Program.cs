using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCircle[] arr = new MyCircle[6];

            arr[0] = new MyCircle(10, 1, 2);
            arr[1] = new MyCylinder(10, 2, 1, 2);

            Console.WriteLine(arr[1]);


        }
    }
}
