namespace Felindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a positive whole 3 digit number");
            int x = int.Parse(Console.ReadLine());

            if ( 99 < x && x<1000 )
            {
                if (x%10 == x / 100)
                {
                    Console.WriteLine("its a felindrom");
                }
                else
                {
                    Console.WriteLine("its not a felindrom");
                }
            }

            else
            {
                Console.WriteLine("must be a 3 digit number");
            }

        }
    }
}
