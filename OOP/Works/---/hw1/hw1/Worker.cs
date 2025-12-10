namespace hw1
{
    internal class Worker : Person
    {
        double salary;

        public override void PrintCheckListTasks()
        {
            Console.WriteLine("Worker tasks");
        }
        public Worker() : base()
        {
            this.salary = 0.0;
        }


        public Worker(string name, int age, double salary) : base(name, age)
        {
            this.salary = salary;
        }

        #region Getters and Setters
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public double GetSalary()
        {
            return salary;
        }
        #endregion

        public override string ToString()
        {
            return base.ToString() + $", Salary: {salary}";
        }
    }
}
