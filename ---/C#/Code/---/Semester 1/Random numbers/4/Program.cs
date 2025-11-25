namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            int smallnum = Math.Min(num1, num2);
            int bignum = Math.Max(num1, num2);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(smallnum,bignum));
            }
        }
    }
}
