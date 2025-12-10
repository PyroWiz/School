namespace AbstractHW
{
    internal class Rectangle : Shape
    {
        double width, height;

        #region Getters and Setters
        public double GetWidth() { return width; }
        public void SetWidth(double value) { width = value; }

        public double GetHeight() { return height; }
        public void SetHeight(double value) { height = value; }

        public override string ToString()
        {
            return $"Rectangle: width={width}, height={height} , name={GetName()}";
        }
        #endregion

        public Rectangle(double width, double height, string name)
        {
            SetWidth(width);
            SetHeight(height);
            SetName(name);
        }

        public override double GetArea() { return width * height; }
    }
}
