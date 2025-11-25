namespace after_decimal_counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number=0;
            int counter = 0;
            Console.WriteLine("enter a decimal number");
            number = double.Parse(Console.ReadLine());

            while (number % 1 != 0)
            {
                number *= 10;
                counter++;
            } 

            Console.WriteLine($"number of digits after decimal point:{counter}");

        }
    }
}
