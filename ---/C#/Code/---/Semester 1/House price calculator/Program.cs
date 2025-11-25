namespace House_price_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool on = true;
            while (on = true)
            {
                bool duplex;
                int rooms;

                Console.WriteLine("is it duplex? enter true or false only");
                duplex = bool.Parse(Console.ReadLine());
                Console.WriteLine("whats the numberof rooms in the house?");
                rooms = int.Parse(Console.ReadLine());

                if (rooms == 3)
                {
                    Console.WriteLine("price is 120$");
                }
                if (rooms == 4)
                {
                    Console.WriteLine("price is 150$");
                }
                if (rooms == 5)
                {
                    if (duplex == true)
                    {
                        Console.WriteLine("price is 200$");
                    }
                    else
                    {
                        Console.WriteLine("price is 180");
                    }
                }
                else
                {
                    Console.WriteLine("there are no houses with that number of rooms in this street");
                }

                Console.WriteLine("continue?");
                on=bool.Parse(Console.ReadLine());
            }
        }
    }
}
