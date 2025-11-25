using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    public class Destination
    {
        private string name;
        private double price;
        private int num;

        public Destination(string name)
        {
            this.name = name;
        }

        public Destination(string name, double price, int num)
        {
            this.name = name;
            this.price = price;
            this.num = num;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public void SetNum(int num)
        {
            this.num = num;
        }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetNum()
        {
            return num;
        }
    }
}
