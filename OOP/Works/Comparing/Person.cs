using System;

namespace Comparing
{
    internal class Person : IComparable<Person>, ICloneable
    {
        int id; string name;

        #region gettasetta
        public Person(int id, string name)
        {
            SetId(id);
            SetName(name);
        }
        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetName()
        {
            return this.name;
        }
        #endregion


        public int CompareTo(Person other)
        {
            if (name.CompareTo(other.name) == 0)
            {
                return id.CompareTo(other.id);
            }
            else
            {
                return name.CompareTo(other.name);
            }

        }

        public Object Clone()
        {
            return new Person(this.id, this.name);
        }

        public override string ToString()
        {
            return $"id: {this.id}, name: {this.name}";
        }

    }
}
