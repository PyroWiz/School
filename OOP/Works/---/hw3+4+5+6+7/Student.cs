using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    internal class Student
    {
        string name; int id; double avg; public static int counter = 0;

        #region setget
        public string GetName() { return name; }
        public int GetId() { return id; }
        public double GetAvg() { return avg; }

        public void SetName(string name) { this.name = UpdateNameToUpperOrLowerCase(name); }
        public void SetAvg(double avg) { this.avg = avg; }
        public void SetId(int id)
        {
            if (id > 0)
            {
                if (DigitCheck(id) == true) this.id = id;
                else Console.WriteLine("invalid id");
            }
        }
        #endregion

        public string UpdateNameToUpperOrLowerCase(string name)
        {
            if (name[0] >= 'A' && name[0] <= 'Z') name = name.ToUpper();
            else name = name.ToLower();
            return name;
        }


        public Student(Student student)
        {
            this.name = student.name;
            this.id = student.id;
            this.avg = student.avg;
            counter++;
        }

        public Student(string name = "Empty", int id = 0, double avg = 0)
        {
            SetName(name);
            SetId(id);
            SetAvg(avg);
            counter++;
        }

        public bool IsValid()
        {
            if (this.id == 0) return false;
            int sum = 0;
            int num = this.id;
            for (int i = 9; i >= 1; i--)
            {
                int digit = num % 10;
                if (i % 2 != 0)
                {
                    sum += digit;
                }
                else
                {
                    if (digit * 2 > 9)
                    {
                        sum += ((digit * 2 % 10) + (digit * 2 / 10));
                    }
                    else
                    {
                        sum += digit * 2;
                    }
                }
                num /= 10;
            }
            if (sum % 10 == 0)
            {
                return true;
            }
            else return false;
        }
        public bool DigitCheck(int num)
        {
            int count = 0;
            while (num > 0)
            {
                num /= 10;
                count++;
            }

            if (count == 9) return true;
            else return false;
        }

        public override string ToString()
        {
            return $"name: {name}\nid: {id}\navg: {avg}";
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType()) return false;
            Student one = (Student)obj;
            if (one.GetName() == GetName() && one.GetId() == GetId() && one.GetAvg() == GetAvg()) return true;
            else return false;
        }
    }
}
