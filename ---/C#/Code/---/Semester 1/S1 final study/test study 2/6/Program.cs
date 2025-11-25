namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = 0; Random rnd = new Random();
            for (bool check = true; check == true;)
            {
                Console.WriteLine("enter a decimal number between 1-5 (including)");
                num = double.Parse(Console.ReadLine());
                if (num >= 1 && num <= 5)
                {
                    check = false;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int i = 0; i <= 100; i++)
                    {
                        Console.Clear();
                        Console.Write($"{i}%");
                        Thread.Sleep(3);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("wrong input");
                    Console.ResetColor();
                }

            } //get num

            int wholenum = (int)num;

            if (wholenum == 1)
            {
                double temp = rnd.NextDouble() * (200 - 100) + 100;
                Console.WriteLine($"random number between 100-200: {temp:f3}, added to num: {num + temp:f3}");
            }

            else if (wholenum == 2)
            {
                int temp = rnd.Next(5, 13); //doesnt include the max
                Console.WriteLine($"temp in power of num: {Math.Pow(temp, num):f3}");
            }

            else if (wholenum == 3)
            {
                double temp = rnd.NextDouble() * (9 - 3) + 3;
                Console.WriteLine($"{num}-{temp:f3}={Math.Abs(num - temp):f3}");
            }

            else
            {
                double temp = rnd.NextDouble() * (5 - 1) + 1;
                Console.WriteLine($"{num}*{temp:f3}={num * temp:f3}");
            }
        }
    }
}
