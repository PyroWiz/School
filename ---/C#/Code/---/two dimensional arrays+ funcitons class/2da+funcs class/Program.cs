using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2da_funcs_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int num = Duo(array);
            Console.WriteLine(num);
            FirstPrint(array);
            int numa = Summer(array,1);
            Console.WriteLine(numa);
            double avg = Averager(array,1);
            Console.WriteLine(avg);
        }

        public static int Duo(int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 0) count++;
                }
            }
            return count;
        }

        public static void FirstPrint(int[,] array)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.WriteLine(array[0, i]);
            }
        }

        public static int Summer(int[,] array, int row)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.WriteLine(array[row, i]);
                sum += array[row, i];
            }
            return sum;
        }

        public static double Averager(int[,] array, int to)
        {
            double avg = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(array[i, to]);
                avg += array[i, to];
            }
            avg /= array.GetLength(0);
            return avg;
        }
    }
}
