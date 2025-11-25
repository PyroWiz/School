namespace for12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 999; i++)
            {
                if ((i %10)!=((i/10)%10) && (i/100) != (i%10) && ((i / 10) % 10)!=i/100)
                    Console.WriteLine(i);
            }
        }
    }
}
