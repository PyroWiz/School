namespace Distance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coordinates for the first point,seperated by a space");

            string[] first = Console.ReadLine().Split(' ');

            double first_x = double.Parse(first[0]);
            double first_y = double.Parse(first[1]);

            Console.WriteLine("Enter the coordinates for the second point,seperated by a space");

            string[] second = Console.ReadLine().Split(' ');

            double second_x = double.Parse(second[0]);
            double second_y = double.Parse(second[1]);

            Console.WriteLine($"Distance is: {Math.Sqrt(Math.Pow(first_x-second_x,2)+Math.Pow(first_y-second_y,2)):f2}");

        }
    }
}
