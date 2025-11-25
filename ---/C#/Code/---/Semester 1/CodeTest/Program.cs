namespace Code_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            while (x>0)

            {
                Console.WriteLine(x%y);
                x = x - y;
            }

        }
    }
}
