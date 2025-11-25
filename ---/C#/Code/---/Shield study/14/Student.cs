using System;

namespace _14
{
    internal class Student
    {
        int studentid; string name; Course[] enrolled, completed;

        public Student(int studentid, string name)
        {
            SetStudentId(studentid);
            SetName(name);
        }

        public double CalculateProg(int studentid)
        {
            return (double)(GetComplete().Length / GetEnrolled().Length);
        }



        #region setget
        public Course[] GetEnrolled()
        {
            return enrolled;
        }
        public Course[] GetComplete()
        {
            return completed;
        }
        // studentid
        public int GetStudentId()
        {
            return this.studentid;
        }

        public void SetStudentId(int studentid)
        {
            this.studentid = studentid;
        }

        // name
        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        #endregion
    }
}
