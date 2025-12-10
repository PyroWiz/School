namespace AbstractHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
            * //ex1

            Circle[] arr = new Circle[6];
            Point p = new Point(1, 1);
            arr[0] = new Circle(10, 1, 2, "circle 1");
            arr[1] = new Circle(10, p, "circle 2");

            arr[2] = new Cylinder(20, 1, 1, 1, "cylinder 1");
            arr[3] = new Cylinder(20, 1, p, "cylinder 2");

            arr[4] = new Sphere(1, 1, 2, "sphere1");
            arr[5] = new Sphere(1, p, "sphere2");


            Cylinder c = (Cylinder)arr[2];
            c.SetHeight(123);
            arr[2] = c;
            /* 
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }


            double highest = 0; int second = 0;
            for (int i = 0; second < 2; i++)
            {
                if (!(i < arr.Length)) { i = 0; second++; }
                if (arr[i] is IVolumable)
                {

                    double volume = 0;

                    volume = ((IVolumable)arr[i]).GetVolume();

                    if (volume > highest)
                        highest = volume;

                    if (second == 0)
                    {
                        Console.WriteLine(volume);
                    }


                    if (second == 1)
                    {
                        if (volume == highest)
                            Console.WriteLine(arr[i].ToString());
                    }

                }


            }
            */

            Point<double> p = new Point<double>(1.1, 1);
            Point<int> p2 = new Point<int>(1, 1);
            // Point<string> p3 = new Point<string>("ido", "or"); //blocks strings

            Console.WriteLine(p.GetX());
            Console.WriteLine(p2.GetX());
        }
    }
}

