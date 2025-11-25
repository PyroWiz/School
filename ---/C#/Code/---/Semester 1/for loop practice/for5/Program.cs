namespace for5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10;i <60; i++)
            {
                if (i % 5 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
