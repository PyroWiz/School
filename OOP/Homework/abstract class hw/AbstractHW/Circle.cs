namespace AbstractHW
{
    internal class Circle : Shape
    {
        double radius;

        #region Getters and Setters
        public double GetRadius() { return radius; }
        public void SetRadius(double value) { radius = value; }

        public override string ToString()
        {
            return $"Circle: radius={radius},name={GetName()}";
        }
        #endregion

        public Circle(double radius, string name)
        {
            SetRadius(radius);
            SetName(name);
        }

        public override double GetArea() { return System.Math.PI * radius * radius; }
    }
}
