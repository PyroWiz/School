namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            Cant(num);
        }

        static void Cant(int num)
        {
            for (int i = 1; i <= num; i++) 
            Console.WriteLine(i);

        }
    }
}
