namespace _3
{
    internal class Program
    {
        static void Until(int x)
        {
            for (int i = 1;i <x;i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int x= int.Parse(Console.ReadLine());
            Until(x);
        }
    }
}
