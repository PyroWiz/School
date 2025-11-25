namespace AbstractHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] Shapes = new Shape[6];

            Shapes[0] = new Rectangle(3.0, 4.0, "Rect1");
            Shapes[1] = new Rectangle(5.0, 6.0, "Rect2");

            Shapes[2] = new Circle(2.0, "Circle1");
            Shapes[3] = new Circle(3.0, "Circle2");

            Shapes[4] = new Cylinder(10.0, 2.0, "Cyl1");
            Shapes[5] = new Cylinder(5.0, 1.5, "Cyl2");

            double biggest = 0;
            foreach (Shape shape in Shapes)
            {
                Console.WriteLine(shape.ToString());
                Console.WriteLine(shape.GetArea());

                if (shape.GetArea() > biggest)
                {
                    biggest = shape.GetArea();
                }

            }

            foreach (Shape shape in Shapes)
            {
                if (shape.GetArea() >= biggest)
                {
                    Console.WriteLine(shape.GetName());
                }
            }
        }
    }
}
