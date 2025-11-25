using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Person
    {
        int id; string name; double height; double weight; string eyes; string hair;

        public int GetId() { return id; }
        public string GetName() { return name; }
        public double Height() { return height; }
        public double Weight() { return weight; }
        public string Eyes() { return eyes; }
        public string Hair() { return hair; }

        public void SetId(int id)
        {
            int c = 0,temp = id;
            while (id > 0)
            {
                id /= 10;
                c++;
            }
            if (c >= 7 && c <= 9) this.id = temp;
            else Console.WriteLine("wrong input");
        }
        public void SetName(string name)
        {
            if (name.Contains(' ')) this.name = name;
            else Console.WriteLine("wrong input");
        }
        public void SetHeight(double height)
        {
            if (height >= 0.50 && height <= 2.10) this.height = height;
            else Console.WriteLine("wrong input");
        }
        public void SetWeight(double weight)
        {
            if (weight >= 3 && weight <= 200) this.weight = weight;
            else Console.WriteLine("wrong input");
        }
        public void SetEyes(char eyes)
        {
            switch (eyes)
            {
                case 'B':
                    this.eyes = "blue"; break;
                case 'G':
                    this.eyes = "green"; break;
                case 'b':
                    this.eyes = "brown"; break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
        }
        public void SetHair(char hair)
        {
            switch (hair)
            {
                case 'B':
                    this.hair = "brown"; break;
                case 'b':
                    this.hair = "black"; break;
                case 'd':
                    this.hair = "blonde"; break;
                case 'r':
                    this.hair = "red"; break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
        }

    }
}
