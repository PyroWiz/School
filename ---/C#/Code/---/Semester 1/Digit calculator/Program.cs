namespace Digit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int x = int.Parse(Console.ReadLine());
            int sum = 0;

            while (x > 0)
            {
                sum += (x % 10);
                x /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
