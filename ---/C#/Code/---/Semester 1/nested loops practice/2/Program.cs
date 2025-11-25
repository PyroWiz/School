namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for (int i = 10;i <= 98;i++) 
           {
                for (int j = 11; j <= 99; j++)
                {
                    if (i % 10 == j/10 && i/10 != j%10 && j%10 !=0 && j % i == 0)
                    {
                        Console.WriteLine($"{i}\n-\n{j}\n");
                        Console.WriteLine($"{i/i}\n-\n{j/i}\n");
                    }
                }
           }
        }
    }
}
