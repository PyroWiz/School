using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHW
{
    internal class Sphere : Circle, IVolumable
    {
        public Sphere(double radius, int x, int y, string name) : base(radius, x, y, name)
        {

        }
        public Sphere(double radius, Point<double> p, string name) : base(radius, p, name)
        {

        }

        public override double GetArea()
        {
            return 4 * Math.PI * GetRadius() * GetRadius();
        }

        public double GetVolume()
        {
            return (4 / 3) * Math.PI * GetRadius() * GetRadius() * GetRadius();
        }

        public override string ToString()
        {
            return $"Sphere: name={GetName()}, radius={GetRadius():F2}, area={GetArea():F2}, volume={GetVolume():F2}";
        }
    }
}
