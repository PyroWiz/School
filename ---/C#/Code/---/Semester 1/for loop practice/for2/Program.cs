namespace for2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 5 grades");
            int grade = 0;

            for (int loop=0; loop < 5;loop++)
            {
                grade = int.Parse(Console.ReadLine());
                if (grade >= 80)
                    Console.WriteLine("very nice!");
                else if (grade >= 60)
                    Console.WriteLine("positive");
                else
                    Console.WriteLine("need improvment");
            }
        }
    }
}
