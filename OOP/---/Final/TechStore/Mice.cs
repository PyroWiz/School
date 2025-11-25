using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore
{
    internal class Mice : Peripherals
    {
        int polling; bool wireless;

        #region setget
        public void SetPolling(int polling)
        {
            this.polling = polling;
        }
        public int GetPolling()
        {
            return this.polling;
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

        public Mice(int polling, bool wireless, string category, double price, string name) : base(category, price, name)
        {
            SetPolling(polling);
            SetWireless(wireless);
        }

        public override string ToString()
        {
            return $"{base.ToString()}Polling Rate: {GetPolling()} Hz\nWireless: {GetWireless()}\n";
        }
    }
}
