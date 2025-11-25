namespace ring_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rings = 0;
            int customers = 0;
            int total_rings = 0;

            do
            {
                Console.WriteLine("how many rings do you want to buy?");
                rings =int.Parse(Console.ReadLine());
                if(rings >= 0)
                {
                    customers++;
                    total_rings += rings;
                }
            } while (rings>=0);

            Console.WriteLine($"numbers of rings sold today:{total_rings},average of rings sells per customer:{(double)total_rings/customers:f3}:");
        }
    }
}
