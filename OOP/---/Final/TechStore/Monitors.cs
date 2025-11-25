using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore
{
    internal class Monitors : Peripherals
    {
        int hz; double size; int resolution;

        #region setget
        public void SetHz(int hz)
        {
            this.hz = hz;
        }
        public int GetHz()
        {
            return this.hz;
        }
        public void SetSize(double size)
        {
            this.size = size;
        }
        public double GetSize()
        {
            return this.size;
        }
        public void SetResolution(int resolution)
        {
            this.resolution = resolution;
        }
        public int GetResolution()
        {
            return this.resolution;
        }
        #endregion

        public Monitors(int hz, double size, int resolution, string category, double price, string name) : base(category, price, name)
        {
            SetHz(hz);
            SetSize(size);
            SetResolution(resolution);
        }

        public override string ToString()
        {
            return $"{base.ToString()}Refresh Rate: {GetHz()} Hz\nSize: {GetSize()}\"\nResolution: {GetResolution()}\n";
        }
    }
}
