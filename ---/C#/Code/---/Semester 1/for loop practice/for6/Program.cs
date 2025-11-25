namespace for6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int dig1, dig2, dig3 = 0;
            for (int i = 100; i <= 500; i++)
            {

                dig1 = i / 100;
                dig2 = (i / 10)%10;
                dig3 = i % 10;

                if (Math.Pow(dig1, 3) + Math.Pow(dig2, 3) + Math.Pow(dig3, 3) == i)
                    Console.WriteLine(i);
                x++;
            }
        }
    }
}
