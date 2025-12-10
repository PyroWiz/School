using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore
{
    internal class Peripherals : Products
    {
        protected string category;

        #region setget
        public void SetCategory(string category)
        {
            this.category = category;
        }

        public string GetCategory()
        {
            return this.category;
        }
        #endregion
        public Peripherals(string category, double price, string name) : base(price, name)
        {
            SetCategory(category);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nCategory: {GetCategory()}\n";
        }
    }
}
