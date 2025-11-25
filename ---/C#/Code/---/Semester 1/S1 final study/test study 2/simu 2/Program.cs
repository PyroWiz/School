namespace simu_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("enter number");
                int num = int.Parse(Console.ReadLine());
                loop = (num < 100) ? false : true;

                int reverse = 0,copy=num;

                while (num > 0)
                {
                    reverse *= 10;
                    reverse += num % 10;
                    num /= 10;
                }
                if (reverse == copy)
                {
                    Console.WriteLine("is polidrom");
                }
                else
                {
                    Console.WriteLine("not a polidrom");
                }
            }
        }
    }
}
