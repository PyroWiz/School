namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            while (n > 0)
            {
                Console.WriteLine(rnd.Next(26));
                n--;
            }
            
        }
    }
}
