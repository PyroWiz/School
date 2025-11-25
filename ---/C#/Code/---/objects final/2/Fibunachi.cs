using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Fibunachi
    {
        int[] arr = new int[0];

        public Fibunachi(int num)
        {
            this.arr = new int[num];
            this.arr[0] = 0;
            this.arr[1] = 1;
            for (int i = 2; i < num; i++)
            {
                this.arr[i] = this.arr[i - 1] + this.arr[i - 2];
            }
        }
        public Fibunachi()
        {
            this.arr = new int[2] { 0, 1 };
        }

        public string ToString()
        {
            string s = "";
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (i != 0) s += ",";
                s += $"{this.arr[i]}";
            }
            return s;
        }


        public int GetTermNumber(int pos)
        {
            if (pos >= 0 && pos < this.arr.Length)
            {
                return this.arr[pos];
            }
            else return -1;
        }
    }
}
