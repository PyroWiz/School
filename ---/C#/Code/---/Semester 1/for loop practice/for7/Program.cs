namespace for7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int number = int.Parse(Console.ReadLine());
            int max = number;

            for (;max>0;max--)
            {
                if (number % max == 0)
                    Console.WriteLine(max);
            }

        }
    }
}
