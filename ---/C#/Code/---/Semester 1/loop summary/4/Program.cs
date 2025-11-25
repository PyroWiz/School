namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter base size,must be even number");
            int based = int.Parse(Console.ReadLine());

            for (int loop = 0; loop < 3; loop++)
            {
                int space = 0;
                for (int i = 0; i < based / 2; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(' ');
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }

                for (int i = based / 2; i > 0; i--)
                {
                    for (int j = i - 1; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");

                    for (int k = 0; k < space; k++)
                    {
                        Console.Write(" ");
                    }
                    space += 2;
                    if (space == 0) space = 2;

                    Console.Write("*");

                    Console.WriteLine();


                    if (i == 2) break;
                }
                for (int a = 0; a < based; a++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            for (int a = 0; a < based; a++)
            {
                for (int b = 0; b < (based - 2) / 2; b++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
