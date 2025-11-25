namespace all_2_digit_numbers_that_are_divided_by_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            while (x < 100)
            {
                if ((x % 5) == 0)
                {
                    Console.WriteLine(x);
                }
                x++;
            }
        }
    }
}
