using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("awa", 123123123, 40);
            Student s2 = new Student("ido", 206857963, 95);
            Student s3 = new Student(s2);

            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2.ToString());
            Console.WriteLine(s3.ToString());
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s3.Equals(s2));
            Console.WriteLine(Student.counter);
        }
    }
}

