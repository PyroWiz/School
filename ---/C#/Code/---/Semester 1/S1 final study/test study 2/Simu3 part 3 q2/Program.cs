namespace Simu3_part_3_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter month number (1-12)");
            int month = int.Parse(Console.ReadLine());

            int projects = 0;
            double totalrev = 0;

            if (month % 2 == 0)
            {
                projects = month - 2;
            }
            else
            {
                projects = month / 3;
            }

            for (int i = 1; i <= projects; i++)
            {
                int projectrev = 0;
                Console.WriteLine("Design or Development? (Case sensitive!)");
                string type = (Console.ReadLine());

                char cha = ' ';

                if (type == "Design")
                {
                    Console.WriteLine("enter your name letter by letter and ! to stop");
                    do
                    {
                        cha = char.Parse(Console.ReadLine());
                        if (cha != '!') projectrev += (int)(cha);
                    } while (cha != '!');
                    projectrev += 1000;
                    projectrev /= 2;
                }
                else
                {
                    Console.WriteLine("enter your name letter by letter and ! to stop");
                    do
                    {
                        cha = char.Parse(Console.ReadLine());
                        if (cha != '!') projectrev += (int)Math.Pow(cha, 3);
                    } while (cha != '!');
                    projectrev += 6000;
                    projectrev /= 2;
                }

                totalrev += projectrev * 1.17;
            }
            Console.WriteLine($"rev this month: {totalrev:f2}");

        }
    }
}
