using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class IntegersVector
    {
        int position;
        int[] array = new int[0];


        public IntegersVector()
        {
            this.position = 0;
            this.array = new int[2];
        }

        public bool IsEmpty()
        {
            int check = 0;
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i] != 0) check++;
            }
            if (check == 0) return true;
            else return false;
        }

        public int Size()
        {
            return this.array.Length;
        }

        public int Get(int index)
        {
            return this.array[index];
        }
        private void EnlargeVector()
        {
            this.array = new int[this.array.Length * 2];
        }
        public void Add(int newInteger)
        {
            if (this.position == this.array.Length)
            {
                int[] newArray = new int[this.array.Length + 1];
                for (int i = 0; i < this.array.Length; i++)
                {
                    newArray[i] = this.array[i];
                }
                this.array = newArray;
            }

            this.array[this.position] = newInteger;
            this.position++;
        }


    }
}
