using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 0 };
            Console.WriteLine(IsPerfect(arr));
        }
        public static bool IsPerfect(int[] arr)
        {
            bool[] boola = new bool[arr.Length];
            int pos = 0, prevpos = 0;
            bool con1 = false;
            bool con2 = false;
            for (int i = 0; i < arr.Length ; i++)
            {
                if (arr[pos] == 0)
                {
                    con2 = true;
                    break;
                }
                boola[pos] = true;
                prevpos = pos;
                pos = arr[pos];
                if (prevpos == pos) break;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (boola[i] == false) break;
                else con1 = true;
            }

            if (con1 && con2) return true;
            else return false;
        }
    }
}
