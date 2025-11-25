namespace Simu3_part_3_q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int core = int.Parse(Console.ReadLine());


            for (int h = 0; h < core + 1; h++)
            {
                for (int s = core - h; s > 0; s--)
                {
                    Console.Write(" ");
                }
                Console.Write(1);
                for (int l = 1; l <= h; l++)
                {
                    Console.Write(l);
                }

                for (int r = h - 1; r >= 1; r--)
                {
                    Console.Write(r);
                }

                if (h > 0) Console.Write(1);

                Console.WriteLine();
            }

        }
    }
}
