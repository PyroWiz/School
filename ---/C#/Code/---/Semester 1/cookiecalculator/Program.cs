namespace cookiecalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cookie = 0;
            int allcookies = 0;
            int people = 0;
            do
            {
                Console.WriteLine("enter the number of cookies you brought");
                cookie = int.Parse(Console.ReadLine());
                if(cookie >= 0)
                {
                    people++;
                    allcookies += cookie;
                }
            } while (cookie >= 0);
            Console.WriteLine($"all cookies in party :{allcookies},number of people in party: {people}");
        }
    }
}
