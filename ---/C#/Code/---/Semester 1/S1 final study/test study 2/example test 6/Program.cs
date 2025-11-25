namespace example_test_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome, enter number of players");
            int players = int.Parse(Console.ReadLine());

            if (players >= 5)
            {
                for (int i = 1; i <= players; i++)
                {
                    Console.WriteLine($"player number {i}, enter your name");
                    {
                        string name = Console.ReadLine();

                        int biggest = 0;
                        for (int j = 0; j < 3; j++)
                        {
                            int winnings = 0;
                            Random rnd = new Random();
                            int current = rnd.Next(1, 9999);

                            if (current >= 999 && current <= 100)
                            {
                                bool dig = true;
                                int temp = current;
                                for (int x = 0; x < 3; x++)
                                {
                                    int last = temp % 10;
                                    temp /= 10;
                                    dig = (last == temp % 10) ? true : false;
                                    if (dig == false) break;
                                }
                                if (dig == true) { winnings = 100; }

                            }
                            else if (current >= 10 && current <= 99)
                            {
                                winnings = ((current % 10 == 5) || (current / 10 == 5)) ? 250 : 0;
                            }
                            else if (current % 10 > 1) winnings = 500;
                            else winnings = 1;

                            if (winnings > biggest) biggest = winnings;
                        }

                        Console.WriteLine($"{name} you won {biggest}$!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            else
            {
                Console.WriteLine("not enough players");
            }
        }
    }
}
