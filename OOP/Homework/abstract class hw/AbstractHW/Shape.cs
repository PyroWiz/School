namespace AbstractHW
{
    abstract class Shape
    {
        string name = "";

        #region Getters and Setters
        public string GetName() { return name; }
        public void SetName(string value) { name = value; }


        #endregion


        public abstract double GetArea();

        public override string ToString()
        {
            return $"Shape: name={GetName()}, area={GetArea():F2}";
        }
    }
}
