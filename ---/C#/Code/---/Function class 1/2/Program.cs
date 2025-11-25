namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine($"{num = Plus(num):f3}");
        }

        static double Plus(double num)
        {
            return num += 0.5;
        }
    }
}
