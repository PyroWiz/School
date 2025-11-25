using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Food
    {
        // Backing fields (stored in memory)
        private string name;
        private double price;
        private bool isMilk;
        private int rating;

        // Constructor
        public Food(string name, double price, bool isMilk, int rating)
        {
            this.name = name;
            this.price = price;
            this.isMilk = isMilk;
            this.rating = rating;
        }

        // Basic Get/Set methods
        public string GetName() { return name; }
        public void SetName(string value) { name = value; }

        public double GetPrice() { return price; }
        public void SetPrice(double value) { price = value; }

        public bool GetIsMilk() { return isMilk; }
        public void SetIsMilk(bool value) { isMilk = value; }

        public int GetRating() { return rating; }
        public void SetRating(int value) { rating = value; }

        // ToString override
        public override string ToString()
        {
            return $"{name} — {price:C2} | {(isMilk ? "Dairy" : "Non‑dairy")} | Rating: {rating}/10";
        }
        public bool CanChange(Food other)
        {
            if (this.price < other.price) return false;
            if (this.isMilk != other.isMilk) return false;
            if (this.rating != other.rating) return false;

            return true;
        }
    }
}
