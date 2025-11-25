namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for (int rows = 1; rows <=10; rows++)
            {
                for (int multis=1;multis<=10;multis++ )
                {
                    Console.Write($"{rows*multis}");
                    if ((rows * multis) <= 9) { Console.Write("  "); }
                    else if ((rows * multis) <=99 ) { Console.Write(" "); }
                }
                Console.WriteLine();
            }
        }
    }
}
