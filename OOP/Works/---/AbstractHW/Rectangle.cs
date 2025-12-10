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

        #endregion
        public Rectangle(double width, double height, string name)
        {
            SetWidth(width);
            SetHeight(height);
            SetName(name);
        }

        public override double GetArea() { return width * height; }

        public override string ToString()
        {
            return $"Rectangle: name={GetName()}, width={GetWidth():F2}, height={GetHeight():F2}, area={GetArea():F2}";
        }
    }
}

