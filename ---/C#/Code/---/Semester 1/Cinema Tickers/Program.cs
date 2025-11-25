using System.ComponentModel.DataAnnotations;

namespace Cinema_Tickers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double max = 120 * 5 * 43.21;
            Console.WriteLine("enter how many tickets were sold yesterday");
            int sells = int.Parse(Console.ReadLine());
            double revenue = sells * 43.21;
            Console.WriteLine($"income is: ${revenue} and loss is: -${max-revenue}");
        }
    }
}
