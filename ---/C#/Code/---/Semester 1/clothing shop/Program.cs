namespace clothing_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("would you like to do some shopping? y/n");
            char shop = char.Parse(Console.ReadLine());
            bool shirt = false;
            bool jeans = false;
            bool swimsuit = false;
            bool keep = true;

            if (shop == 'y')
            {
                int loop = 0;
                while (loop < 4 && keep==true )
                {
                    Console.WriteLine("Category menu: \nShirt - 1\nJeans - 2\nSwimsuit - 3\nExit shop-4");
                    int dec = int.Parse(Console.ReadLine());

                    switch (dec)
                    {
                        case 1:
                            shirt = true;
                            loop++;
                            break;
                    
                        case 2:
                            jeans = true;
                            loop++;
                            break;

                        case 3:
                            swimsuit = true;
                            loop++;
                            break;

                        case 4:
                            keep = false;
                            break;
                    }
                }
                if (jeans == true && shirt == true)
                {
                    Console.WriteLine($"price is {(40 * loop)*0.85}$ after discount");
                }
                else if (swimsuit == true)
                {
                    Console.WriteLine($"price is {(40 * loop)*0.90}$after discount");
                }
                else
                {
                    Console.WriteLine($"price is {40*loop}$");
                }
            }
            else Console.WriteLine("ok bye");
        }
    }
}
