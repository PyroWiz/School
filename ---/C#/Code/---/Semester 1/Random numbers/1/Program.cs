namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int count = 0, roll1, roll2,loop=0;

            for (int i = 0; i < 360; i++)
            {
                roll1 = rnd.Next(2, 7);
                roll2 = rnd.Next(2, 7);
                if (roll1 == 6 && roll2 == 6) { count++; }
                loop++;
            }
            if (count >= 2) Console.WriteLine($"won");
            else Console.WriteLine("lost");

        }
    }
}
