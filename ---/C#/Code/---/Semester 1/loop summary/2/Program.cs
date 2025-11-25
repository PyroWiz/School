namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number and number of reps");
            int number=int.Parse(Console.ReadLine());
            int reps=int.Parse(Console.ReadLine());

            long newnum = 0;

            for (int i = 0; i < reps;)
            {
                newnum += number;
                i++;
                if (i == reps) break;
                newnum *= 1000;
            }
            Console.WriteLine(newnum);
        }
    }
}
