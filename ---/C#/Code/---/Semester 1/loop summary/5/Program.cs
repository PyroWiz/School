namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            long num1 = 0, num2 = 0, bignum = 0, smallnum = 0, inverted_bignum = 0, dig1 = 0, dig2 = 0;

            while (check == false)
            {
                dig1 = 0; dig2 = 0;
                Console.WriteLine("enter one long number and one short number");
                num1 = long.Parse(Console.ReadLine());
                num2 = long.Parse(Console.ReadLine());
                long dummy1 = num1, dummy2 = num2;

                while (dummy1 > 0)
                {
                    dummy1 /= 10;
                    dig1++;
                }
                while (dummy2 > 0)
                {
                    dummy2 /= 10;
                    dig2++;
                }

                if (dig1 == dig2)
                {
                    check = false;
                    Console.WriteLine("wrong input");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (dig1 != dig2) check = true;

            }

            {
                if (dig1 > dig2)
                {
                    bignum = num1;
                    smallnum = num2;
                }
                if (dig2 > dig1)
                {
                    bignum = num2;
                    smallnum = num1;
                }
            }


            while (bignum > 0)
            {

                if (bignum % 10 == 0 && bignum > 0)
                {
                    inverted_bignum *= 10;
                    bignum /= 10;
                }
                else
                {

                    inverted_bignum = inverted_bignum + (bignum % 10);
                    bignum /= 10;
                    if (bignum > 0) inverted_bignum *= 10;
                }
            }

            long inflated_bignum = 0;

            while (inverted_bignum > 0)
            {
                if (inverted_bignum % 10 == 0)
                {
                    inflated_bignum *= 10;
                }
                else
                {
                    inflated_bignum += inverted_bignum % 10;
                    inflated_bignum *= 10;
                }
                inverted_bignum /= 10;
                inflated_bignum *= 10;
               
            }
            while (inflated_bignum % 10 == 0)
            {
                inflated_bignum /= 10;
            }

            long inverted_smallnum = 0;

            while (smallnum > 0)
            {

                if (smallnum % 10 == 0 && smallnum > 0)
                {
                    inverted_smallnum *= 10;
                    smallnum /= 10;
                }
                else
                {

                    inverted_smallnum = inverted_smallnum + (smallnum % 10);
                    smallnum /= 10;
                    if (smallnum > 0) inverted_smallnum *= 10;
                }

            }

            long inflated_smallnum = 0;

            while (inverted_smallnum > 0)
            {
                if (inverted_smallnum % 10 == 0)
                {
                    inflated_smallnum *= 10;
                }
                else
                {
                    inflated_smallnum += inverted_smallnum % 10;
                    inflated_smallnum *= 10;
                }
                inverted_smallnum /= 10;
                inflated_smallnum *= 10;
               
            }

            while (inflated_smallnum % 10 == 0)
            {
                inflated_smallnum /= 10;
            }
            
            long counter_big = inflated_bignum, counter_small = inflated_smallnum;
            int digicountbig = 0, digicountsmall = 0;
            
            while (counter_big > 0)
            {
                counter_big/=10;
                digicountbig++;
            }
            while (counter_small > 0)
            {
                counter_small/=10;
                digicountsmall++;
            }
            while (digicountbig- digicountsmall>1)
            {
                inflated_smallnum *= 10;
                digicountsmall++;
            }

            long final = inflated_smallnum + inflated_bignum;

            Console.WriteLine($"{inflated_smallnum} + {inflated_bignum} = {final}");

            

        }
    }
}
