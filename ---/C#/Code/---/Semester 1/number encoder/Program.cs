namespace number_encoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 4 digit number");
            int number = int.Parse(Console.ReadLine());
            int right = number % 10;
            number /= 10;
            right *= 1000;
            int encoded = number + right;
            Console.WriteLine(encoded);

        }
    }
}
