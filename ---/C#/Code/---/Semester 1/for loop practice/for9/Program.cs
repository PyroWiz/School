namespace for9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 10 numbers");
            int number = 1;
            int biggest = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number < biggest)
                    biggest = number;

            }
            Console.WriteLine(biggest);
        }
    }
}
