namespace AbstractHW
{
    internal class Cylinder : Circle, IVolumable
    {
        double height;

        #region Getters and Setters
        public double GetHeight() { return height; }
        public void SetHeight(double value) { height = value; }


        #endregion

        public Cylinder(double height, double radius, Point<double> p, string name) : base(radius, p, name)
        {
            SetHeight(height);
        }
        public Cylinder(double height, double radius, int x, int y, string name) : base(radius, x, y, name)
        {
            SetHeight(height);
        }

        public override double GetArea()
        {
            return 2 * System.Math.PI * GetRadius() * GetRadius();
        }

        public override string ToString()
        {
            return $"Cylinder: name={GetName()}, radius={GetRadius():F2}, height={GetHeight():F2}, area={GetArea():F2}, volume={GetVolume():F2} , point={GetP().ToString()}";
        }

        public double GetVolume()
        {
            return Math.PI * GetRadius() * GetRadius() * GetHeight();
        }
    }
}
