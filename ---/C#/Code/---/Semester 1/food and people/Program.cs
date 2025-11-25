namespace food_and_people
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = 1000;
            int capacity = 10000;

            Console.WriteLine("starting point:1000 people and 10000 capacity");
            while (people < capacity)
            {
                Console.WriteLine("after 10 years:");
                people *= 2;
                capacity += 4000;
                Console.WriteLine($"{people}people and {capacity}capacity");
            }

            Console.WriteLine("gg");
        }
    }
}
