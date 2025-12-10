namespace hw1
{
    internal class Student : Person
    {
        double avg;

        public override void PrintCheckListTasks()
        {
            Console.WriteLine("Student tasks");
        }
        public Student() : base()
        {
            this.avg = 0.0;
        }


        public Student(string name, int age, double avg) : base(name, age)
        {
            this.avg = avg;
        }

        #region Getters and Setters
        public void SetAvg(double avg)
        {
            this.avg = avg;
        }

        public double GetAvg()
        {
            return avg;
        }
        #endregion

        public override string ToString()
        {
            return base.ToString() + $", Average: {avg}";
        }
    }
}
