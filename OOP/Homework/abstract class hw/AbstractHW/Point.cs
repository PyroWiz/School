using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AbstractHW
{
    internal class Point<T> where T : INumber<T>
    {
        T x, y;

        public Point(T x, T y)
        {
            if (x is string || y is string)
            {
                Console.WriteLine("bad input");
                return;
            }

            SetX(x); SetY(y);
        }

        #region GettersAndSetters
        public T GetX()
        {
            return x;
        }

        public void SetX(T value)
        {
            x = value;
        }

        public T GetY()
        {
            return y;
        }

        public void SetY(T value)
        {
            y = value;
        }
        #endregion

        public override string ToString()
        {
            return $"Point(x={GetX()}, y={GetY()})";
        }

    }
}
