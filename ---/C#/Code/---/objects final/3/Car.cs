using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3
{
    internal class Car
    {
        string manu, mode; double year; int hands; string[] owners;

        #region get
        public string GetManu() { return manu; }
        public string GetMode() { return mode; }
        public double GetYear() { return year; }
        public int GetHands() { return hands; }
        public string[] GetOweners() { return owners; }
        #endregion

        #region set
        public void SetManu(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!((value[i] <= 'z' && value[i] >= 'a') || (value[i] <= 'Z' && value[i] >= 'A')))
                {
                    Console.WriteLine("not a proper manufacturer name");
                    return;
                }
            }

            manu = value;
        }
        public void SetMode(string value)
        {
            mode = value;
        }
        public void SetYear(double value)
        {
            if (value < 1.1995 || value > 6.2024)
            {
                Console.WriteLine("false year");
                return;
            }
            year = value;
        } //aaaaaaa
        public void SetHands(int value)
        {
            hands = value;
            owners = new string[value];
            Fill();
        }
        public void Fill()
        {
            owners[0] = "Current Owner";
            for (int i = 1; i < owners.Length; i++)
            {
                Console.WriteLine("enter owner number " + (i+1) + " out of " + owners.Length);
                owners[i] = Console.ReadLine();
            }
        }
        #endregion
        public Car(string manu, string mode, double year, int hands)
        {
            SetManu(manu);
            SetMode(mode);
            SetYear(year);
            SetHands(hands);
        }

        public Car(Car v)
        {
            manu = v.manu;
            mode = v.mode;
            year = v.year;
            hands = v.hands;
            owners = v.owners;
        }

        public string ToString()
        {
            string re = $"manufacturer is: {manu}, model name: {mode}\nyear of production: {year}\nnumber of owners: {hands}\nowners names: " + string.Join(",", owners);
            return re;
        }
    }
}
