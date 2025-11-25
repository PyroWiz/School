namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade = 0;
            do
            {
                Console.WriteLine("Enter a grade between 0 - 100");
                grade = int.Parse(Console.ReadLine());
            } while (grade < 0 || grade > 100);

            if (grade <= 40) Console.WriteLine("Failed");
            else if (grade <= 55) Console.WriteLine("Didnt pass");
            else if (grade <= 74) Console.WriteLine("Passed");
            else if (grade <= 85) Console.WriteLine("Good");
            else if (grade <= 94) Console.WriteLine("Very good");
            else if (grade <= 100) Console.WriteLine("Perfect");

        }
    }
}
