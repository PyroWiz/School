namespace example_test_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (bool check = true; check == true;)
            {
                Console.WriteLine("enter a number, enter a 4 digit number to stop");
                int num = int.Parse(Console.ReadLine());
                if (num >= 1000 && num <= 10000) check = false;
                while (num > 0)
                {
                    if (num % 10 == 6) count++;
                    num /= 10;
                }
            }
            Console.WriteLine($"number of times a number with a 6 was entered: {count}");
        }
    }
}
