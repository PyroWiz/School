namespace checks_on_a_3_digit_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loop = 0;
            while (loop == 0)
            {
                Console.WriteLine("enter a positive whole 3 digit number");
                int x = int.Parse(Console.ReadLine());
                if (x > 99 && x < 1000)
                {

                    if (x % 2 == 0) Console.WriteLine("even number");
                    else Console.WriteLine("Uneven number");

                    if ((x % 10) >= 5) Console.WriteLine("single digits is bigger than 5, or is 5");
                    else Console.WriteLine("single digits is smaller than 5");

                    double multi;
                    int OGx = x;
                    if (x <= 250)
                    {
                        x = (int)(x * 1.25);
                        multi = 1.25;

                    }
                    else if (x <= 500)
                    {
                        x = (int)(x * 1.5);
                        multi = 1.5;
                    }
                    else
                    {
                        x = (int)(x * 1.75); //999 
                        multi = 1.75;
                    }

                    Console.WriteLine($"{OGx}*{multi}={x}");
                        
                }
                else Console.WriteLine("not a 3 digit number");
                Console.WriteLine("Reset?");
                loop=int.Parse(Console.ReadLine());
            }
        }
    }
}
