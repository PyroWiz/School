using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    public class TestDestination
    {
        public static double Total(Destination d)
        {
            // Implemented in the image already
            return d.GetPrice() * d.GetNum();
        }

        public static void Main(string[] args)
        {
            Destination d1 = new Destination("Paris");
            d1.SetName("London");
            d1.SetNum(200);
            d1.SetPrice(300.0);
            Console.WriteLine(Total(d1));

            d1.SetNum(50);
            Destination d2 = new Destination(d1.GetName(), 100.0, d1.GetNum());
            Console.WriteLine(Total(d2));
        }

        public static string GetNotPopular(Destination[] dest)
        {
            // To implement for question ד
            return null;
        }

        public static string[] CheapDests(Destination[] dest, double maxPrice)
        {
            // To implement for question ה
            return null;
        }
    }
}
