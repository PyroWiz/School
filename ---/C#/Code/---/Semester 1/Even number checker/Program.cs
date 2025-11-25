namespace Even_number_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            while (c == 0)
            {
                Console.WriteLine("Enter a 3 digit number");
                int x = int.Parse(Console.ReadLine());
                if (x < 1000 && x > 99)
                {
                    if ((x % 10) % 2 != 0)
                    {
                        Console.WriteLine("even");
                    }

                    else if (((x / 10) % 10) % 7 == 0)
                    {
                        Console.WriteLine("seven");
                    }

                    else
                    {
                        Console.WriteLine("bye");
                    }
                }
                else
                {
                    Console.WriteLine("not a 3 digit number");
                }
                c=int.Parse(Console.ReadLine());
            }
        }
    }
}




