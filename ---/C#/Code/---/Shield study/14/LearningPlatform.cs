using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class LearningPlatform
    {
        string platformname; Course[] available; Student[] registered;

        public LearningPlatform(string name)
        {
            SetName(name);
            CourseAdder();
        }
        public void Menu()
        {
            Console.WriteLine("enter option\n" +
                "\n1) register a student");
        }
        public void CourseAdder()
        {
            Console.WriteLine("add courses to the system, how many courses in this program?");
            int num = int.Parse(Console.ReadLine());
            Course[] arr = new Course[num];
            Console.WriteLine("add all the courses details:");

            for (int i = 0; i < num; i++)
            {
                Console.Clear();
                Console.WriteLine($"course no'{i + 1}\n");

                Console.Write("id: "); int id = int.Parse(Console.ReadLine());
                Console.Write("duration in weeks: "); int time = int.Parse(Console.ReadLine());
                Console.Write("name: "); string name = Console.ReadLine();
                Console.Write("difficulty lvl: "); int diff = int.Parse(Console.ReadLine());
            }

        }
        #region setget
        public void SetName(string name)
        { this.platformname = name; }

        public string GetName()
        {
            return platformname;
        }

        #endregion
    }
}
