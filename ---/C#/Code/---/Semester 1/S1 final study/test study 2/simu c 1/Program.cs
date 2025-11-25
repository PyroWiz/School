namespace simu_c_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int cars = rnd.Next(10, 100);
            double sum_year = 0, sum_price = 0;

            Console.WriteLine($"Number of cars to register: {cars}");
            for (int i = 1; i <= cars; i++)
            {
                Console.WriteLine($"Enter Price of car number {i}");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter manufacturing year of car no {i}");
                int year = int.Parse(Console.ReadLine());

                sum_price += price;
                sum_year += year;
            }
            sum_year /= cars;
            sum_price /= cars;

            sum_price = (sum_price > 99999 && sum_price < 1000000) ? sum_price + sum_price * 0.10 : sum_price + sum_price * 0.17;

            string message = (sum_year < 2010) ? "theres too many old cars" :
                (sum_year <= 2020 && sum_year >= 2010) ? "would be wise to buy more new cars for the company"
                : "the cars in the comnay are pretty new";

            Console.WriteLine($"average manufacturing year in the company: {sum_year}\naverage price of cars in the company: {sum_price}" +
                $" {message}");

        }
    }
}
