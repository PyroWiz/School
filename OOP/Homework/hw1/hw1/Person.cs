namespace hw1
{
    internal class Person
    {
        string name;
        int age;

        public virtual void PrintCheckListTasks()
        {
            Console.WriteLine("Person tasks");
        }
        public Person()
        {
            this.name = "";
            this.age = 0;
        }


        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        #region Getters and Setters
        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }
        #endregion

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }
    }
}
