namespace example_test_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 15:
                    Console.WriteLine("enter another number");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"4th root of the number: {Math.Sqrt(Math.Sqrt(num2))}");
                    break;
                case 30:
                    Console.WriteLine("have a nice day");
                    break;
                default:
                    Console.WriteLine($"3*{num}={3 * num}");
                    break;
            }
        }
    }
}
