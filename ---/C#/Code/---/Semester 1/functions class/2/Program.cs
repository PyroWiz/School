namespace _2
{
    internal class Program
    {
        static double AddHalf(int num)
        {
            double temp = num;
            return temp + 0.5;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            double added = (double)AddHalf(num);
            Console.WriteLine(added);
        }
    }
}
