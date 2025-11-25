using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Person
    {
        static int howMany;
        string name; char gender; double age;
        Person partner;
        Person[] kids;

        public Person(string name = " ", char gender = ' ', double age = 0)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            partner = null;
            kids = null;
            howMany++;
        }

        public Person(string name) : this(name, ' ', 0)
        {

        }
        public Person(Person per)
        {
            this.name = per.name;
            this.gender = per.gender;
            this.age = per.age;
            partner = per.partner;
            kids = per.kids;
        }
        public override string ToString()
        {
            return $"name: {name}";
        }
    }
}
