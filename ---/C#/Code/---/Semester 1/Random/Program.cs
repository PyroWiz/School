using System.Security.Cryptography;

namespace randomnumbergenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex 1
            
            Console.WriteLine("Loading 1");
            Random x = new Random(); 
            int y = x.Next(-100,100);
            Console.WriteLine(Math.Abs(y));

            //ex2

            Console.WriteLine("Loading 2");
            Random z = new Random();
            double m = z.NextDouble()*200-100;
            Console.WriteLine($"{Math.Round(Math.Abs(m)):f2}");

        }
    }
}
