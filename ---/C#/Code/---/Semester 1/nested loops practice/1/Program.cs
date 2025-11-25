namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int shortest = 0, longest = 0, num_long=0, num_short = 0, current_best=0;

            for (int players =12;players >0;players--)
            {
                Console.WriteLine("welcome,what is your player number?");
                int player_num = int.Parse(Console.ReadLine());
                current_best = 0;
                for (int i = 1; i <= 6; i++)
                {
                    Console.WriteLine($"how much was your {i}'s jump?");
                     int jump = int.Parse(Console.ReadLine());
                       if (longest<jump) { longest = jump; num_long = player_num; }
                       if (player_num == 1 || shortest >jump) { shortest = jump; num_short = player_num; }
                       if (current_best < jump) { current_best = jump; }
                }
                Console.WriteLine($"your best jump is:{current_best}");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine($"player {num_long} made the highest jump: {longest}\n" +
                $"player {num_short} made the shortest jump: {num_long}");
        }
    }
}
