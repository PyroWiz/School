namespace HannukaMoney
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the money dan got,needs to be higher than 20$");
            int dan = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the money ben got,needs to be higher than 20$");
            int ben = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the money chen got,needs to be higher than 20$");
            int chen = int.Parse(Console.ReadLine());

            int all = dan + ben + chen;
            all -= 50;
            all /= 1;

            Console.WriteLine($"they can buy {all} gums");

        }
    }
}
