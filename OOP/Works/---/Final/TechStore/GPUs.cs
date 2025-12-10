using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore
{
    internal class GPUs : Hardware
    {
        string chipset;
        int vram; 

        #region setget
        public void SetChipset(string chipset)
        {
            this.chipset = chipset;
        }
        public string GetChipset()
        {
            return this.chipset;
        }
        public void SetVRAM(int vram)
        {
            this.vram = vram;
        }
        public int GetVRAM()
        {
            return this.vram;
        }
        #endregion

        public GPUs(string chipset, int vram, string type, double price, string name) : base(type, price, name)
        {
            SetChipset(chipset);
            SetVRAM(vram);
        }

        public override string ToString()
        {
            return $"{base.ToString()}Chipset: {GetChipset()}\nVRAM: {GetVRAM()} GB\n";
        }
    }
}