namespace for1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 10 decimal numbers");
            double number = 0;
            for (int loop = 0; loop < 10; loop++) 
            {
                number = double.Parse(Console.ReadLine());

                if (Math.Floor(number) == number)
                    Console.WriteLine("whole number");
                else
                    Console.WriteLine("not a whole number");
                if (number < 0)
                    Console.WriteLine("negative number");
                else
                    Console.WriteLine("positive number");
            }
        }
    }
}
