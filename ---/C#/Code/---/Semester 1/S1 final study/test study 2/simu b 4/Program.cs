namespace simu_b_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // veggies - 1 , meat - 2, eggs - 3
            int one = 0, two = 0, three = 0;
            Random rnd = new Random();

            for (int i = 1; i <= 3; i++)
            {
                int veggies = 3, meat = 3, eggs = 3;
                while (veggies > 0 || meat > 0 || eggs > 0)
                {
                    int target = rnd.Next(1, 4);
                    int ammo = rnd.Next(1, 4);

                    switch (ammo)
                    {
                        case 1:
                            {
                                if (veggies == 0) break;
                                veggies--;
                                switch (target)
                                {
                                    case 1:
                                        one++;
                                        break;
                                    case 2:
                                        two++;
                                        break;
                                    case 3:
                                        three++;
                                        break;
                                }
                            }
                            break;
                        case 2:
                            if (meat == 0) break;
                            meat--;
                            switch (target)
                            {
                                case 1:
                                    one++;
                                    break;
                                case 2:
                                    two++;
                                    break;
                                case 3:
                                    three++;
                                    break;
                            }
                            break;
                        case 3:
                            int num = 0;
                            if (eggs == 0) break;
                            if (eggs > 1)
                            {

                                num = rnd.Next(1, 3);
                            }
                            else { num = 1; }
                            eggs -= num;
                            switch (target)
                            {
                                case 1:
                                    one += num;
                                    break;
                                case 2:
                                    two += num;
                                    break;
                                case 3:
                                    three += num;
                                    break;
                            }
                            break;
                    }

                }

            }

            Console.WriteLine(@$"chef one was hit by {one} pieces of food,\nchef 2 was hit by {two} pieces of food\nchef three was hit by
{three} pieces of food");
        }
    }
}
