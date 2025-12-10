using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore
{
    internal class Products
    {
        protected double price; protected string name;

        public Products(double price, string name)
        {
            SetPrice(price);
            SetName(name);
        }
        public override string ToString()
        {
            return $"Name: {GetName()}\nPrice: {GetPrice()}$";
        }
        #region setget
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public double GetPrice()
        {
            return this.price;
        }
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
