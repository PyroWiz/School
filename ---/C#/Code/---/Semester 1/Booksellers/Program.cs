using System.Transactions;

namespace Booksellers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int price = 15;
            Console.WriteLine("enter name of agent1");
            string agent1 = Console.ReadLine();
            Console.WriteLine("enter base salary of agent1");
            double salary1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"enter how much {agent1} sold");
            int sells1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter name of agent2");
            string agent2 = Console.ReadLine();
            Console.WriteLine("enter base salary of agent2");
            double salary2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"enter how much {agent2} sold");
            int sells2 = int.Parse(Console.ReadLine());

            double tax1 = (price * sells1) + (price * sells1 * 0.25);
            double tax2 = (price * sells2) + (price * sells2 * 0.25);

            Console.WriteLine($"{agent1} 1 made ${salary1 + tax1}");
            Console.WriteLine($"{agent2} 1 made ${salary2 + tax2}");






        }
    }
}
