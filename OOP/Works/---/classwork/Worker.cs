using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork
{
    internal class Worker
    {
        string id, name; int workinghours; double salary; static int counter;

        #region getters
        public string GetId()
        {
            return this.id;
        }
        public void SetId(string id)
        {
            this.id = id;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetHours()
        {
            return this.workinghours;
        }
        public void SetHours(int hours)
        {
            this.workinghours = hours;
        }
        public double GetSalary()
        {
            return this.salary;
        }
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        #endregion
        public Worker() { counter++; }

        public Worker(string id, string name, int workinghours, double salary)
        {
            SetId(id);
            SetName(name);
            SetHours(workinghours);
            SetSalary(salary);
            counter++;
        }

        public Worker(Worker worker)
        {
            this.id = worker.id;
            this.name = worker.name;
            this.workinghours = worker.workinghours;
            this.salary = worker.salary;
            counter++;
        }

        public double Calculate()
        {
            return GetHours() * GetSalary();
        }

        public void Print()
        {
            Console.WriteLine($"id: {this.GetId()}\nname: {this.GetName()}\nhours of work: {this.GetHours()}\nmoney per hour: {this.GetSalary()}");
        }

        public override string ToString()
        {
            return $"id: {this.GetId()}\nname: {this.GetName()}\nhours of work: {this.GetHours()}\nmoney per hour: {this.GetSalary()}";
        }

        public override bool Equals(object obj)
        {
            if (this.GetType() != obj.GetType()) return false;
            if (obj == this) return true;
            Worker na = (Worker)obj;
            if (na.GetId() != this.GetId()) return false;
            if (na.GetName() != this.GetName()) return false;
            if (na.GetHours() != this.GetHours()) return false;
            if (na.GetSalary() != this.GetSalary()) return false;

            return true;
        }

        static public int ReturnCounter()
        {
            return counter;
        }


    }
}
