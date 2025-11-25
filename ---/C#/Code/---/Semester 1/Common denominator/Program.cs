namespace Common_denominator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers seperated by a space");
            string[] numbers = Console.ReadLine().Split(' ');

            int x=int.Parse(numbers[0]);
            int y=int.Parse(numbers[1]);

            Console.WriteLine($"The common denominator of {x} and {y} is 1 because they are both whole numbers and not fractions");

        }
    }
}
