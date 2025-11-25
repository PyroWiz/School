namespace example_test_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalbeads = 0, longest = 0,longestbeads=0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter how many red beads in this necklace");
                int red = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter how many red beads in this necklace");
                int yellow = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter how many red beads in this necklace");
                int green = int.Parse(Console.ReadLine());

                string type = " ";
                int beads = red + yellow + green;

                int one = 0;
                if (red == 0) one += 1;
                if (yellow == 0) one += 1;
                if (green == 0) one += 1;

                if (one == 2) type = "Unified";
                else if (red == yellow && yellow == green) type = "Perfect";
                else if (one == 1) type = "Boring";
                else type = "Normal";

                Console.WriteLine($"Type of necklace: {type}, number of beads: {beads}");
                totalbeads += beads;
                if (beads > longestbeads)
                {
                    longest = i;
                    longestbeads = beads;
                }
            }

            Console.WriteLine($"End of workday!: stats: \nlongest necklace is number {longest} with a total of {longestbeads} beads!");
        }
    }
}
