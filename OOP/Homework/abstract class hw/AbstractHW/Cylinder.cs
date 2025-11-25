namespace AbstractHW
{
    internal class Cylinder : Circle
    {
        double height;

        #region Getters and Setters
        public double GetHeight() { return height; }
        public void SetHeight(double value) { height = value; }

        public override string ToString()
        {
            return $"Cylinder: height={height} , radius={GetRadius()},name={GetName()}";
        }
        #endregion

        public Cylinder(double height, double radius, string name) : base(radius, name)
        {
            SetRadius(radius);
            SetHeight(height);
            SetName(name);
        }

        public override double GetArea()
        {
            return 2 * System.Math.PI * GetRadius() * GetRadius();
        }
    }
}
