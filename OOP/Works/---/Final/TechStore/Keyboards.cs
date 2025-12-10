using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore
{
    internal class Keyboards : Peripherals
    {
        string layout; bool wireless;

        #region setget
        public void SetLayout(string layout)
        {
            this.layout = layout;
        }
        public string GetLayout()
        {
            return this.layout;
        }
        public void SetWireless(bool wireless)
        {
            this.wireless = wireless;
        }
        public bool GetWireless()
        {
            return this.wireless;
        }
        #endregion

        public Keyboards(string layout, bool wireless, string category, double price, string name) : base(category, price, name)
        {
            SetLayout(layout);
            SetWireless(wireless);
        }

        public override string ToString()
        {
            return $"{base.ToString()}Layout: {GetLayout()}\nWireless: {GetWireless()}\n";
        }
    }
}
