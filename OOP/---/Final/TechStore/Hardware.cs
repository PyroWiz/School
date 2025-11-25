using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore
{
    internal class Hardware : Products
    {
        protected string type;

        #region setget
        public void SetType(string type)
        {
            this.type = type;
        }

        public string GetTypeName()
        {
            return this.type;
        }
        #endregion

        public Hardware(string type, double price, string name) : base(price, name)
        {
            SetType(type);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nType: {GetTypeName()}\n";
        }
    }
}
