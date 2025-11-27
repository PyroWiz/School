using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class MyCircle
    {
        MyPoint center;
        double radius;

        public MyCircle(double radius, MyPoint center)
        {
            SetRadius(radius);
            this.center.SetX(center.GetX());
            this.center.SetY(center.GetY());
        }
        public MyCircle(double radius, int x, int y)
        {
            SetRadius(radius);
            this.center = new MyPoint(x, y);
            this.center = new MyPoint(x, y);
        }



        #region setget

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public MyPoint GetCenter()
        {
            return center;
        }


        #endregion
    }
}
