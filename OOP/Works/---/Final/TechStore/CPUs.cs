using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore
{
    internal class CPUs : Hardware
    {
        int cores;
        double frequency; 

        #region setget
        public void SetCores(int cores)
        {
            this.cores = cores;
        }
        public int GetCores()
        {
            return this.cores;
        }
        public void SetFrequency(double frequency)
        {
            this.frequency = frequency;
        }
        public double GetFrequency()
        {
            return this.frequency;
        }
        #endregion

        public CPUs(int cores, double frequency, string type, double price, string name) : base(type, price, name)
        {
            SetCores(cores);
            SetFrequency(frequency);
        }

        public override string ToString()
        {
            return $"{base.ToString()}Cores: {GetCores()}\nFrequency: {GetFrequency()} GHz\n";
        }
    }
}