using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();

            s1.name = "ido";
            s1.id = "206857963";
            s1.avg = 95;

            Console.WriteLine($"\nFirst student: \n");
            s1.Print();
            s1.CheckAvg();

            Console.WriteLine("enter second student info");
            Console.Write("name: "); s2.name = Console.ReadLine();
            Console.Write("id: "); s2.id = Console.ReadLine();
            Console.Write("avg: "); s2.avg = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nSecond student: \n");
            s2.Print();
            s2.CheckAvg();

            string temp = s1.name;
            s1.name = s2.name;
            s2.name = temp;

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\nAfter swap: \n");
            s1.Print();
            Console.WriteLine();
            s2.Print();

        }
    }
}
