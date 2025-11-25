using System.Diagnostics.Metrics;

namespace _5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 5,digits=1;
            while (rows > 0)
            {
                int number = 5;
                int counter = digits;
                while (counter > 0)
                {
                    Console.Write(number);
                    number--;
                    counter--;
                }
                digits++ ;
                rows--;
                Console.WriteLine();
            }
        
        }
    }
}
