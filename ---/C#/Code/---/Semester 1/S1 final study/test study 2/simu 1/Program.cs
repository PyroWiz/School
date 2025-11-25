namespace simu_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 1; i <= 5; i++)
            {
                int num = rnd.Next(100, 100000);
                int temp = num, dig = 0;
                Console.WriteLine($"number {i}: {num}");
                while (temp > 0)
                {
                    temp /= 10;
                    dig++;
                }
                Console.WriteLine($"number of digits in number {i}: {dig}");
                temp = 0;
                while (num > 0)
                {
                    temp += num % 10;
                    num /= 10;
                    if (num > 0) { temp *= 10; }
                }
                Console.WriteLine($"number {i} inverted: {temp}");
            }
        }
    }
}
