namespace hw1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region hw1
            /*
            Person p1 = new Person("John Doe", 25);
            Student s1 = new Student("Alice Brown", 20, 85.5);
            Worker w1 = new Worker("Mike Johnson", 35, 45000.0);
            Manager m1 = new Manager("Chris Taylor", 40, 10000.0);

            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(s1.ToString());
            //Console.WriteLine(w1.ToString());
            //Console.WriteLine(m1.ToString());

            Student s2 = new Student("Alice Brown", 20, 119);
            Student s3 = new Student("Brown", 20, 120);
            Student s4 = new Student("Benny\n", 20, 120);
            Student[] arr = new Student[] { s2, s3, s4 };
            /
            double highest = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].GetAvg() > highest)
                {
                    highest = arr[i].GetAvg();

                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].GetAvg() == highest)
                {
                    Console.WriteLine(arr[i].GetName());
                }
            }
            
            Manager m2 = new Manager("Sarah Wilson", 42, 12000.0);
            Manager m3 = new Manager("David Chen", 38, 11000.0);
            Manager m4 = new Manager("Emily Parker", 45, 13500.0);

            
            Manager[] arr2 = new Manager[] { m2, m3, m4 };

            string hmname = ""; double highestmoney = 0;

            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i].GetBonus() > highestmoney)
                {
                    hmname = arr2[i].GetName();
                    highestmoney = arr2[i].GetBonus();
                }
            }

            Console.WriteLine("\n" + hmname);
            */
            #endregion

            #region hw2

            Person[] personarr = new Person[6];

            personarr[0] = new Student("Liam Smith", 19, 88.2);
            personarr[1] = new Student("Olivia Davis", 22, 92.5);
            personarr[2] = new Worker("Noah Lee", 30, 38000.0);
            personarr[3] = new Worker("Emma Garcia", 28, 42000.0);
            personarr[4] = new Manager("Ava Martinez", 45, 5000.0, 90000.0);
            personarr[5] = new Manager("William Brown", 50, 7000.0, 110000.0);

            foreach (Person a in personarr)
            {
                Console.WriteLine(a.ToString());
            }
            foreach (Person a in personarr)
            {
                a.PrintCheckListTasks();
            }

            double highest = 0; int cycle = 0;

            for (int a = 0; a < 2; a++)
            {
                for (int i = 0; i < personarr.Length; i++)
                {
                    if (a == 0)
                    {
                        if (personarr[i].GetType() == typeof(Manager))
                        {
                            double current = ((Manager)personarr[i]).GetBonus() + ((Worker)personarr[i]).GetSalary();

                            if (current > highest)
                            {
                                highest = current;
                            }
                        }
                    }
                    if (a == 1)
                    {
                        if (personarr[i].GetType() == typeof(Manager))
                        {
                            double current = ((Manager)personarr[i]).GetBonus() + ((Worker)personarr[i]).GetSalary();
                            if (current == highest)
                            {
                                Console.WriteLine(personarr[i].GetName());
                            }
                        }
                    }

                }
            }

            #endregion
        }
    }
}
