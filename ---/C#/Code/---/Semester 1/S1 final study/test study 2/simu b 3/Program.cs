namespace simu_b_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double FALAFEL = 15.66, CHIPS = 10.99;
            Random rnd = new Random();

            int falafel = rnd.Next(10, 50), falafel_c = 0;
            int half_falafel = rnd.Next(10, 50), half_falafel_c = 0;
            int chips = rnd.Next(10, 50), chips_c = 0;
            int small_chips = rnd.Next(10, 50), small_chips_c = 0;

            double budget = 250;
            int broke = 0;
            while (budget > 0 && broke < 4)
            {
                int menu = rnd.Next(1, 5);

                switch (menu)
                {
                    case 1:
                        if (falafel > 0)
                        {
                            if (budget - FALAFEL >= 0)
                            {
                                falafel_c++;
                                falafel--;
                                budget -= FALAFEL;
                            }
                            else
                            {
                                broke++;
                                menu = 2;
                                continue;
                            }
                        }
                        break;
                    case 2:
                        if (half_falafel > 0)
                        {
                            if (budget - FALAFEL / 2 >= 0)
                            {
                                half_falafel_c++;
                                half_falafel--;
                                budget -= FALAFEL / 2;
                            }
                            else
                            {
                                broke++;
                                menu = 3;
                                continue;
                            }
                        }
                        break;
                    case 3:
                        if (chips > 0)
                        {
                            if (budget - CHIPS >= 0)
                            {
                                chips_c++;
                                chips--;
                                budget -= CHIPS;
                            }
                            else
                            {
                                broke++;
                                menu = 4;
                                continue;
                            }
                        }
                        break;
                    case 4:
                        if (small_chips > 0)
                        {
                            if (budget - CHIPS / 2 >= 0)
                            {
                                small_chips_c++;
                                small_chips--;
                                budget -= CHIPS / 2;
                            }
                            else
                            {
                                broke++;
                            }
                        }
                        break;
                }
            }

            Console.WriteLine($@"yael bought: {falafel_c} falafels,{half_falafel_c} half falafels, {chips_c} chips,{small_chips_c} small chips,
remaining stock:
{falafel} falafels
{half_falafel} half falafels
{chips} chips
{small_chips} small chips
yael spent: {250-budget:f3}");
        }
    }
}
