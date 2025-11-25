namespace for8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 10 numbers");
            int biggest =0 , number = 0;

            for (int i = 0; i < 10; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number >biggest)
                    biggest = number;

            }
            Console.WriteLine(biggest);
        }
    }
}
