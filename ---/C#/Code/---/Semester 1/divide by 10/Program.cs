namespace divide_by_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num1=int.Parse(Console.ReadLine());
            int num2 = 0;

            while (num1/10 > 0)
            {
                num2 = (num2 * 10) + (num1 % 10);
                num1/=10;
                num2 += num1;
            }

            Console.WriteLine(num2);
        }
    }
}
