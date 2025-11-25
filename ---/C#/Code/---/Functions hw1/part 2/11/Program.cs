using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x == 1)
            {
                Random rnd = new Random();
                double num = rnd.NextDouble() * (1000 - 1) + 1;
                int whole = (int)(num);
                int dec = (int)(num % 1) * 1000;  //mistake 1 = no cast
                int tempw = whole, tempd = dec, Aw = 0, Ad = 0;
                while (tempw > 0)
                {
                    Aw += tempw % 10;
                    tempw /= 10;
                }
                while (tempd>0)
                {
                    Ad += tempd % 10;
                    tempd /= 10;
                }
                if (Aw<Ad)
                {
                    x = 0;
                    break;
                }
                int sum = 0;
                int perfect = 0;

                for (int i = 1; i <= whole; i++)
                    if (whole % i == 0) sum += i;

                if (sum == whole) Console.WriteLine("the whole part is a perfect number");
                sum = 0;
            }
        }
    }
}
