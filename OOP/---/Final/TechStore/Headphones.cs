using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore
{
    internal class Headphones : Peripherals
    {
        bool wireless;

        #region setget
        public void SetWireless(bool wireless)
        {
            this.wireless = wireless;
        }
        public bool GetWireless()
        {
            return this.wireless;
        }
        #endregion

        public Headphones(bool wireless, string category, double price, string name) : base(category, price, name)
        {
            SetWireless(wireless);
        }

        public override string ToString()
        {
            return $"{base.ToString()}Wireless: {GetWireless()}\n";
        }
    }
}
