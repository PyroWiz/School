using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class MySphere : MyCircle, IVolumable
    {
        public double GetArea()
        {
            return 4 * Math.PI * GetRadius() * GetRadius();
        }

        public double GetVolume()
        {
            return (4 / 3) * Math.PI * GetRadius() * GetRadius() * GetRadius();
        }

        public MySphere(double radius, int x, int y) : base(radius, x, y)
        {

        }
    }
}
