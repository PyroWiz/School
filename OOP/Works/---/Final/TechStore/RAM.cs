using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore
{
    internal class RAM : Hardware
    {
        int capacity; 
        int speed;    

        #region setget
        public void SetCapacity(int capacity)
        {
            this.capacity = capacity;
        }
        public int GetCapacity()
        {
            return this.capacity;
        }
        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }
        public int GetSpeed()
        {
            return this.speed;
        }
        #endregion

        public RAM(int capacity, int speed, string type, double price, string name) : base(type, price, name)
        {
            SetCapacity(capacity);
            SetSpeed(speed);
        }

        public override string ToString()
        {
            return $"{base.ToString()}Capacity: {GetCapacity()} GB\nSpeed: {GetSpeed()} MHz\n";
        }
    }
}