namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double print = 0;
            int count=0;
            Random rnd = new Random();
            while ((int)print != 7)
            {
                print = (rnd.NextDouble() * (10 - 0) + 0);
                Console.WriteLine($"{print:f3} ");
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
