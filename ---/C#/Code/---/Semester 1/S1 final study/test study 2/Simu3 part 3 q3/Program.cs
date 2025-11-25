namespace Simu3_part_3_q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double CLASSIC = 50.993, BRAZZ = 90.995, WOMEN = 0;
            int classic_space = 7, brazz_space = 7, women_space = 7;

            bool check = true;

            do
            {
                double cost = 0;
                Console.WriteLine("Hello customer, Do you want to register? (yes/no)");
                check = (Console.ReadLine() == "yes") ? true : false; if (check == false) break;

                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your gender (m/f)");
                char gender = char.Parse(Console.ReadLine());

                bool menu = true;
                while (menu == true)
                {


                    Console.WriteLine("Make your selection:" +
                        "\n1-classic boxing,17:00 monday and thursday, 50.993$" +
                        "\n2-brazzilian jiu-jitsu,16:45 tuesday and friday, 90.995$" +
                        "\n3-women sport group,15:30 monday and tuesday, free");

                    int selection = int.Parse(Console.ReadLine());

                    switch (selection)
                    {
                        case 1:
                            if (classic_space > 0)
                            {
                                classic_space -= 1;
                                cost += CLASSIC;
                            }
                            else
                                Console.WriteLine("No space");
                            break;
                        case 2:
                            if (brazz_space > 0)
                            {
                                brazz_space -= 1;
                                cost += BRAZZ;
                            }
                            else
                                Console.WriteLine("No space");
                            break;
                        case 3:
                            if (gender == 'm') Console.WriteLine("this group is only for women"); break;
                            if (women_space > 0)
                            {
                                women_space -= 1;
                                cost += WOMEN;
                            }
                            else
                                Console.WriteLine("No space");
                            break;
                    }
                    Console.WriteLine("do you want to add another one? (y/n)");
                    menu = (char.Parse(Console.ReadLine()) == 'y') ? true : false;
                }

                Console.WriteLine($"Total cost of all courses taken by you: {cost:f3}$");
                Console.ReadKey();
            } while (check == true);

            Console.WriteLine($"classic boxing has {classic_space} spaces left" +
                $"\nbrazzilian jiujitsu has {brazz_space} spaces left" +
                $"\nwomen sport has {women_space} spaces left");
        }
    }
}
