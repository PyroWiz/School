using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Student
    {
        public string name;
        public string id;
        public double avg;

        public void Print()
        {
            Console.WriteLine($"Name: {name}\nID: {id}\naverage: {avg}");
        }

        public void CheckAvg()
        {
            if (avg >= 90)
                Console.WriteLine("Honorary student");
            else
                Console.WriteLine("Normal student");
        }
    }
}
