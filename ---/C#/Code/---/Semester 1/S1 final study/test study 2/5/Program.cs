using System.Text;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double XL = 72.9, L = 65.5, MOZ = 2.5, OLIVE = 3, ONION = 3.5, TUNA = 4,
            P_BOOM_L = 68, P_BOOM_XL = 70, P_ROCKET_L = 69.5, P_ROCKET_XL = 74.5, P_BORED_L = 67, P_BORED_XL = 74;

            double average = 0, lowest = 0, highest = 0;
            int boom_count = 0, rocket_count = 0, bored_count = 0, moz_count = 0, olive_count = 0, onion_count = 0, tuna_count = 0;
            int first = 0, avg_c = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("welcome to our pizzeria,do you want to start a order? (y/n)");
            Console.ResetColor();
            bool menu = ((char.Parse(Console.ReadLine()) == 'y') ? true : false);

            while (menu == true)
            {
                double pizza = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("would you like a custom order or choose from our premade pizzas?\n1-custom\n2-premade"); Console.ResetColor();
                int c_or_p = int.Parse(Console.ReadLine());
                if (c_or_p == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("choose size (L/XL)"); Console.ResetColor();
                    string size = Console.ReadLine();

                    switch (size)
                    {
                        case "L":
                            pizza += L;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Size: Large"); Console.ResetColor();
                            break;
                        case "XL":
                            pizza += XL;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Size: Extra Large"); Console.ResetColor();
                            break;

                    }

                    int top = 0, topcount = 0;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("please choose toppings (up to 3,enter 0 to finish/cancel)"); Console.ResetColor();
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("1-Mozzarella\n2-Olives\n3-Onions\n4-Tuna"); Console.ResetColor();
                        top = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("on the whole pizza or half?(w/h)"); Console.ResetColor();
                        char wh = char.Parse(Console.ReadLine());
                        switch (top)
                        {
                            case 1:
                                pizza += (wh == 'w') ? MOZ : MOZ / 2;
                                tuna_count++;
                                break;
                            case 2:
                                pizza += (wh == 'w') ? OLIVE : OLIVE / 2;
                                olive_count++;
                                break;
                            case 3:
                                pizza += (wh == 'w') ? ONION : ONION / 2;
                                onion_count++;
                                break;
                            case 4:
                                pizza *= (wh == 'w') ? TUNA : TUNA / 2;
                                tuna_count++;
                                break;


                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        topcount++;
                        Console.WriteLine("Added " +
                            ((top == 1) ? "Mozzarella" :
                            (top == 2) ? "Olives" :
                            (top == 3) ? "Onions" :
                            (top == 4) ? "Tuna" : "Nothing ")
                            + ((topcount < 3) ? (((wh == 'w') ? ("on the whole") : ("on half the")) + " pizza\nwant to add more toppings or no? (y/n)") :
                                                (((wh == 'w') ? ("on the whole") : ("on half the")) + " pizza\ncannot add anymore toppings"))); Console.ResetColor();
                        if (topcount < 3)
                        {
                            char check = char.Parse(Console.ReadLine());
                            if (check == 'n') top = 0;
                        }

                    } while (top != 0 && topcount < 3);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("choose one of our premade pizzas!\n1-Boom pizza\n2-Rocket pizza\n3-Boredoom pizza");
                    int preset = int.Parse(Console.ReadLine());
                    Console.WriteLine("Choose size: (L/XL)"); Console.ResetColor();
                    string size = Console.ReadLine();
                    switch (preset)
                    {
                        case 1:
                            pizza += (size == "L") ? P_BOOM_L : P_BOOM_XL;
                            onion_count++;
                            olive_count++;
                            break;
                        case 2:
                            pizza += (size == "L") ? P_ROCKET_L : P_ROCKET_XL;
                            moz_count++;
                            tuna_count++;
                            break;
                        case 3:
                            pizza += (size == "L") ? P_BORED_L : P_BORED_XL;
                            olive_count++;
                            break;

                    }
                }

                lowest = (lowest == 0) ? pizza : lowest++;
                highest = (pizza > highest) ? pizza : highest;
                average += pizza;
                avg_c++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("would you like to order another?(y/n)"); Console.ResetColor();
                menu = ((char.Parse(Console.ReadLine()) == 'y') ? true : false);
                Console.Clear();

            }
            if (average == 0)
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine(":("); Console.ResetColor();
                return;
            }
            int topnum = Math.Max(Math.Max(olive_count, moz_count), Math.Max(tuna_count, onion_count));

            StringBuilder toptop = new StringBuilder();
            int psik = 0;

            if (olive_count == topnum)
            {
                psik++;
                toptop.Append("olives");
            }
            if (tuna_count == topnum)
            {
                psik++;
                if (psik > 0) toptop.Append(", ");
                toptop.Append("tuna");

            }
            if (onion_count == topnum)
            {
                psik++;
                if (psik > 0) toptop.Append(", ");
                toptop.Append("onions");
            }
            if (moz_count == topnum)
            {
                psik++;
                if (psik > 0) toptop.Append(", ");
                toptop.Append("mozzarella");
            }
            string finalizedtop = toptop.ToString();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"thanks for your order/s!, heres the stats:\nmost pricy pizza: {highest:f3}$\ncheapest pizza: {lowest:f3}$\n" +
                $"most popular toppings: {finalizedtop}\naverage of all pizzas: {average / avg_c:f3}"); Console.ResetColor();

        }
    }
}
