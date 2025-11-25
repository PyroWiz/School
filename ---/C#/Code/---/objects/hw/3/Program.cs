using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.SetId(12345678);
            p1.SetName("awawa");
            p1.SetHeight(1.65);
            p1.SetWeight(55.5);
            p1.SetEyes('G');
            p1.SetHair('d');

            Person p2 = new Person();
            p2.SetId(87654321);
            p2.SetName("bababa");
            p2.SetHeight(1.82);
            p2.SetWeight(75.3);
            p2.SetEyes('b');
            p2.SetHair('b');

            Console.WriteLine($"Person 1: ID={p1.GetId()}, Name={p1.GetName()}, Height={p1.Height()}, Weight={p1.Weight()}, Eyes={p1.Eyes()}, Hair={p1.Hair()}");
            Console.WriteLine($"Person 2: ID={p2.GetId()}, Name={p2.GetName()}, Height={p2.Height()}, Weight={p2.Weight()}, Eyes={p2.Eyes()}, Hair={p2.Hair()}");
        }
    }
}

