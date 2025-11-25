namespace hw1
{
    internal class Manager : Worker
    {
        double bonus;

        public override void PrintCheckListTasks()
        {
            Console.WriteLine("Manager tasks");
        }

        public Manager() : base()
        {
            this.bonus = 0.0;
        }


        public Manager(string name, int age, double bonus, double salary) : base(name, age, salary)
        {
            this.bonus = bonus;
        }

        #region Getters and Setters
        public void SetBonus(double bonus)
        {
            this.bonus = bonus;
        }

        public double GetBonus()
        {
            return bonus;
        }
        #endregion

        public override string ToString()
        {
            return base.ToString() + $", Bonus: {bonus}";
        }
    }
}
