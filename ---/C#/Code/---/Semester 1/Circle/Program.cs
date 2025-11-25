namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Circle diameter");
            double diameter = double.Parse(Console.ReadLine());
            double radius = diameter / 2;
            double area = (Math.PI)*(Math.Pow(radius, 2));
            Console.WriteLine($"area of circle : {area:f2}");

            Console.WriteLine("enter angle");
            double angle = double.Parse(Console.ReadLine());
            double rad = Math.PI * (angle / 180);
            Console.WriteLine($"sinus of the angle is: {Math.Sin(rad):f2}");

            
        }
    }
}
