namespace recursion1
{
    internal class Ex1
    {
        public static void Exx1()
        {
            Console.WriteLine("enter number");
            int x = int.Parse(Console.ReadLine());
            Raca(x);
            int Raca(int x)
            {
                if (x < 1) { return 0; }
                Console.WriteLine(x);
                return Raca(x - 1);
            }
        }

        public static void Exx2()
        {
            Console.WriteLine("enter number");
            int x = int.Parse(Console.ReadLine());
            Raca(x, 0);
            int Raca(int x, int sum)
            {
                if (x < 1) { Console.WriteLine(sum); return 0; }
                Console.WriteLine(x);
                return Raca((x - 1), sum += x);
            }
        }

        public static void Exx3()
        {
            Console.WriteLine("enter whole even number");
            int x = int.Parse(Console.ReadLine());
            Raca(x, 0);
            int Raca(int x, int sum)
            {
                if (x < 1) { Console.WriteLine(sum); return 0; }

                if (x % 3 == 0) { sum += x; }
                return Raca((x - 1), sum);
            }
        }
        public static void Exx4()
        {
            Console.WriteLine("enter two numbers");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = x;

            Raca(x, y, z);

            int Raca(int x, int y, int z)
            {
                if (y <= 1) { Console.WriteLine(x); return 0; }
                return Raca(x += z, y - 1, z);
            }

        }

        public static void Exx5()
        {
            Console.WriteLine("enter two numbers");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(Raca(x, y));

            int Raca(int x, int y)
            {
                if (y <= 1)
                {
                    return x;
                }

                return x * Raca(x, y - 1);
            }
        }
    }
}
