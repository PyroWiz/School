namespace ConsoleApp1
{
    public class Exs
    {
        static public void Ex3()
        {
            Console.WriteLine(One(5, 1));
            int One(int n, int multi)
            {
                if (n == 0) { return multi; }
                if (n % 2 != 0) { multi *= n; }
                return One(n - 1, multi);
            }
        }
        static public void Ex4()
        {
            Console.WriteLine(Two(422, 0));

            int Two(int n, int digi)
            {
                if (n == 0) { return digi; }
                return Two(n / 10, digi += 1);
            }
        }
        static public void Ex8()
        {
            Console.WriteLine(Three(29, 29, 0));

            bool Three(int num, int dividers, int count)
            {
                if (dividers == 0) return true;
                if (count > 2) return false;

                if (num % dividers == 0)
                {
                    count++;
                }

                return Three(num, dividers - 1, count);
            }
        }
        static public void Ex9()
        {
            Console.WriteLine(Four(11, 2, true));

            bool Four(int num, int chain, bool status)
            {
                if (num < 1) return status;

                if ((num % 10) % 2 == 0)
                {
                    if (chain == 1) return (status = false);
                    chain = 0;
                }
                else
                {
                    if (chain == 0) return (status = false);
                    chain = 1;
                }

                return Four(num / 10, chain, status);
            }
        }
        static public void Ex10()
        {
            Console.WriteLine(Five(3, 0));

            int Five(int num, int sum)
            {
                if (num < 1) return sum;

                if (num % 2 == 0)
                {
                    sum += (int)(Math.Pow(num,2));
                }
                else
                    sum += num * 2;

                return Five(num -= 1, sum);

            }
        }
    }
}

