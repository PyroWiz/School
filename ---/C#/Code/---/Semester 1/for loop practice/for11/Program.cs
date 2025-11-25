namespace for11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int number = int.Parse(Console.ReadLine());
            int j=0,i=0;

            for ( i=0; i < number; i++)
            {
                if (Math.Pow(i, 2) + Math.Pow(j, 2) == number)
                    Console.WriteLine($"{i} {j}");

                for ( j=0; j < number; j++)
                {
                    if (Math.Pow(i, 2) + Math.Pow(j, 2) == number)
                        Console.WriteLine($"{i} {j}");
                }
            }
        }
    }
}
