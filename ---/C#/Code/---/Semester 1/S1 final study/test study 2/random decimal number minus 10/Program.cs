namespace random_decimal_number_minus_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int x = (int)Math.Abs((rnd.NextDouble() * (0 - 10) + 10) - 10);
            Console.WriteLine(x);

        }
    }
}
