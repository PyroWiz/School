namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter uneven number");
            int realbasis = int.Parse(Console.ReadLine());
            int basis = realbasis;
            basis = basis * 2 + 1;
            bool number = true;

            for (int i = 0; i < realbasis+1;i++)
            {
                for (int j = 0; j < basis; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                if (i == realbasis)
                    break;
                for (int j = 0; j < basis; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    if (j % 2 == 1)
                    {
                        if (number == true)
                        {
                            Console.Write("0");
                            number = false;
                            continue;
                        }

                        if (number == false)
                        {
                            Console.Write("1");
                            number = true;
                            continue;
                        }

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
