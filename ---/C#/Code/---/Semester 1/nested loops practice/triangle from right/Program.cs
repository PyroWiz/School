namespace triangle_from_right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter base of triangle");
            int basis = int.Parse(Console.ReadLine());
            int loop = 1;
            int spaces=basis-loop;

            while (loop <=basis)
            {
                for (int i = 1; i <= spaces; i++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j<=loop; j++)
                {
                    Console.Write('x');
                }

                Console.WriteLine();
                spaces--;
                loop++;
            }

        }
    }
}
