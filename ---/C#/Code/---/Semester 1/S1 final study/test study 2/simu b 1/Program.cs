namespace simu_b_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";

            while (name != "stop")
            {
                Console.WriteLine("enter your name, enter 'stop' to end");
                name = Console.ReadLine();
                if (name == "stop") { break; }

                int prize = 0;
                bool won = false;

                for (int i = 0; i < 2; i++)
                {
                    int current_prize = 0;
                    Random rnd = new Random();
                    int grilled = rnd.Next(10, 1000);

                    if (grilled > 99 && grilled < 1000)
                    {
                        int temp = grilled, last = 0;
                        bool check = true;
                        while (temp > 0)
                        {
                            last = temp % 10;
                            temp /= 10;
                            if (!(temp > 0)) { break; }
                            if (last == temp % 10) { check = true; }
                            else { check = false; break; }
                        }

                        if (check == true) { current_prize += 100; won = true; }
                    }

                    if (grilled > 9 && grilled < 100)
                    {
                        int temp = grilled;
                        while (temp > 0)
                        {
                            if (temp % 10 == 5)
                            {
                                current_prize += 250;
                                won = true;
                                break;
                            }
                            temp /= 10;
                        }

                    }

                    if (grilled % 10 < 7)
                    {
                        current_prize += 500;
                        won = true;
                    }

                    if (won == false)
                    {
                        current_prize += 1;
                    }

                    if (current_prize > prize) { prize = current_prize; }
                }


                Console.WriteLine($"nice! {name} won {prize}$!\npress enter  to register another input");
                Console.ReadKey();
            }
        }
    }
}
