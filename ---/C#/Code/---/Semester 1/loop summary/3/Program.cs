namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int core=int.Parse(Console.ReadLine());
            int tempcore = 1;
            core+= 1;
            for (int rows = core*2-1; rows > 0; rows--)
            {
                for (int spaces=core-tempcore;spaces>0;spaces--)
                {
                    Console.Write(" ");
                }
                for (int digits=1;digits<tempcore;digits++)
                {
                    Console.Write(digits);
                }
                for (int digits = tempcore-2; digits >0; digits--)
                {
                    Console.Write(digits);
                }
                Console.WriteLine();
                if (rows >core)tempcore++;
                if (rows <= core) tempcore--;
            }
        }
    }
}
