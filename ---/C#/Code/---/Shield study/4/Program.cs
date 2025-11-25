using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Print();
        }
        public static int Random()
        {
            Thread.Sleep(1);
            Random rnd = new Random();
            return rnd.Next(5, 10);
        }
        public static string[,] CreateMatrix()
        {
            string[,] matrix = new string[Random(), Random()];
            return matrix;
        }

        public static string Input()
        {
            Console.WriteLine("enter something");
            return Console.ReadLine();
        }

        public static string[,] MatrixValue()
        {
            string[,] matrix = CreateMatrix();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Input();
                }
            }
            return matrix;
        }

        public static void Print()
        {
            string[,] matrix = MatrixValue();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
