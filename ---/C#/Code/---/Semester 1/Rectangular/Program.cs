namespace Rectangular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width");
            int width = int.Parse(Console.ReadLine());

            double area = height * width;
            double slitlenght = Math.Sqrt(Math.Pow(height,2)+Math.Pow(width, 2));

            Console.WriteLine($"area: {area}\nslit: {slitlenght:f2}");
        }
    }
}
