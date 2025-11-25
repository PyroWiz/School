using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Resturant
    {
        string name; double year; int tables; bool kosher; string[] food = new string[0]; double[] price = new double[0];

        #region get
        public string GetName() { return name; }
        public double GetYear() { return year; }
        public int GetTable() { return tables; }
        public string[] GetFood() { return food; }
        public double[] GetPrice() { return price; }
        public bool GetKosher() { return kosher; }
        #endregion
        #region set
        public void SetName(string value)
        {
            name = value;
        }
        public void SetYear(double value)
        {
            if (value > 13 || value < 1) { Console.WriteLine("invalid date"); return; }
            else year = value;
        }
        public void SetTables(int value)
        {
            if (value < 15) { Console.WriteLine("too little tables"); return; }
            else if (value > 25) { Console.WriteLine("too many tables"); return; }
            else tables = value;
        }
        public void SetFood(int value)
        {
            if (value < 10) { Console.WriteLine("too little foods"); return; }
            else if (value > 17) { Console.WriteLine("too many food"); return; }
            else food = new string[value];
            SetPrice(value);
        }
        public void SetPrice(int value)
        {
            price = new double[value];
            Fill();
        }
        public void SetKosher(bool value)
        {
            kosher = value;
        }
        #endregion

        public void Fill()
        {
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine("enter food no'" + (i + 1));
                food[i] = Console.ReadLine();
                Console.WriteLine("enter price no'" + (i + 1));
                price[i] = double.Parse(Console.ReadLine());
            }
        }

        public Resturant(string name = "Unknown", double year = 1.2024, int tables = 15, bool kosher = false, int fnp = 10)
        {
            SetName(name);
            SetYear(year);
            SetTables(tables);
            SetKosher(kosher);
            SetFood(fnp);
        }

        public string ToString()
        {
            string s = $"name: {GetName()}\nyear: {GetYear()}\ntables: {GetTable()}\nis it kosher: {GetKosher()}\nmeals available: ";
            for (int i = 0; i < food.Length; i++)
            {
                s += $"\n{food[i]}, price: {price[i]}";
            }
            return s;
        }
    }
}
