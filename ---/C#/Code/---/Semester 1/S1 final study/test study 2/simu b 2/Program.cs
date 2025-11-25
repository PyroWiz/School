namespace simu_b_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            int temp = num, dig = 0, power = 0;
            while (temp > 0)
            {
                dig = temp % 10;
                temp /= 10;
                power += (int)Math.Pow(dig, 4);
            }
            if (power == num)
            {
                Console.WriteLine("narcissist number");
            }
            else
            {
                Console.WriteLine("not a narcissist number");
            }


        }
    }
}
