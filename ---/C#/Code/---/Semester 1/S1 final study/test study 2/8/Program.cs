namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0, mlt = 0;
            Console.WriteLine("Want to order drinks? (yes/stop)-case sensitive!");
            for (bool menu = true; menu == true;)
            {
                double ml = 0;
                menu = (Console.ReadLine() == ("yes") ? true : false);
                if (menu == false) break;
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Choose your drink customer {i + 1}:\n1-Arak\n2-Asai\n3-Whiski\n4-Water");
                    int c = int.Parse(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            Console.WriteLine("Ordered arak");
                            mlt += 7;
                            ml += 7;
                            total += 3.5;
                            break;
                        case 2:
                            Console.WriteLine("Ordered Asai");
                            mlt += 7.5;
                            ml += 7.5;
                            total += 4.5;
                            break;
                        case 3:
                            Console.WriteLine("Ordered Whiski");
                            mlt += 7.7;
                            ml += 7.7;
                            total += 5;
                            break;
                        case 4:
                            Console.WriteLine("Ordered Water");
                            mlt += 7.75;
                            ml += 7.75;
                            break;
                    }
                    Console.Clear();
                }
                Console.WriteLine($"Total ml consumed this round: {ml}");
                Console.WriteLine("Another round? (yes/stop)-case sensitive!");
            }
            Console.WriteLine($"Total: {total:f2}$,total ml consumed: {mlt:f2}");
        }
    }
}
