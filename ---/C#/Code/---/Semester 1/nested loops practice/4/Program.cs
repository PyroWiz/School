namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <=8; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    if (j>i) { Console.WriteLine($"{i}{j}"); }
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
