namespace fibunachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1,next=0;

            Console.WriteLine("enter number");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(0);
            while (next < input )
            {
                next = a + b;
                a = b;
                b = next;
                if (next <input)
                Console.WriteLine(next);
            }

        }
    }
}
