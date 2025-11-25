namespace Discount_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int items;
            double price=0, discount1=0, discount2=0;

            Console.WriteLine("enter number of items bought");
            items = int.Parse(Console.ReadLine());
            Console.WriteLine("enter price of all items");
            price = double.Parse(Console.ReadLine());

            if (price >= 300)
            {
                discount1 = price - (price / 300) * 50;
            }

            if (items >= 3)
            {
                discount2 = price-(price * 0.20);
            }

            if (items >= 3 || price >= 300)
            {
                if (discount1 > discount2)
                {
                    Console.WriteLine($"price after discount is {discount1:f3} ");
                }

                else
                {
                    Console.WriteLine($"price after discount is {discount2:f3}");
                }
            }

            else
            {
                Console.WriteLine($"price is {price}");
            }


        }
    }
}
