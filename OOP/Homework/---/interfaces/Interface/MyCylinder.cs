using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class MyCylinder : MyCircle, IVolumable
    {
        double height;

        public MyCylinder(double height, double radius, int x, int y) : base(radius, x, y)
        {
            SetHeight(height);
        }

        #region setget
        public void SetHeight(double height)
        {
            this.height = height;
        }

        public double GetHeight()
        {
            return height;
        }
        #endregion

        public double GetVolume()
        {
            return Math.PI * GetRadius() * GetRadius() * GetHeight();
        }
    }
}
