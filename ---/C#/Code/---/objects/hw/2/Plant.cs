using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Plant
    {
        string name; char size; string color; int water;

        public string GetName() { return name; }
        public char GetSize() { return size; }
        public string GetColor() { return color; }
        public int GetWater() { return water; }
        public void SetName(string name) { this.name = name; }
        public void SetSize(char size) { this.size = size; }
        public void SetColor(string color) { this.color = color; }
        public void SetWater(int water) { this.water = water; }



    }
}
