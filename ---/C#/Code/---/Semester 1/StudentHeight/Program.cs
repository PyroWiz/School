namespace StudentHeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student1 height in meters");
            double height1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter student2 height in meters");
            double height2 = double.Parse(Console.ReadLine());

            double diff = Math.Abs(height1 - height2);
            Console.WriteLine($"heigh diff is: {diff:f2}");
            double Short = Math.Min(height1, height2);
            Console.WriteLine($"shorter height is: {Short:f2}");
        }
    }
}
