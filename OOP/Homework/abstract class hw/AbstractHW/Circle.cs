namespace AbstractHW
{
    internal class Circle : Shape
    {
        double radius;
        Point<double> p;

        #region Getters and Setters
        public double GetRadius() { return radius; }
        public void SetRadius(double value) { radius = value; }

        public Point<double> GetP() { return p; }

        #endregion

        public Circle(double radius, Point<double> p, string name)
        {
            SetRadius(radius);
            SetName(name);
            this.p = p;
        }
        public Circle(double radius, int x, int y, string name)
        {
            SetRadius(radius);
            SetName(name);
            p = new Point<double>(x, y);
        }

        public override double GetArea() { return System.Math.PI * radius * radius; }

        public override string ToString()
        {
            string center = p != null ? p.ToString() : "(null)";
            return $"Circle: name={GetName()}, radius={GetRadius():F2}, center={center}, area={GetArea():F2}";
        }
    }
}
