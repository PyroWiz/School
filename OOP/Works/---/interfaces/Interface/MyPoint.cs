
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class MyPoint
    {
        int x, y;

        public int GetX()
        {
            return x;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public int GetY()
        {
            return y;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public MyPoint(int x, int y)
        {
            SetX(x); SetY(y);
        }
    }
}
