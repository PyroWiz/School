
using System.Diagnostics.CodeAnalysis;

namespace average_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter grade");
            int grade = int.Parse(Console.ReadLine());
            int count = 1;
            int sum = grade;
            while (grade >= 0)
            {
                grade = int.Parse(Console.ReadLine());
                if (grade >= 0)
                {
                    sum += grade;
                    count++;
                }
            }

            Console.WriteLine((double)sum / count);
            Console.WriteLine(count);
        }
    }
}
