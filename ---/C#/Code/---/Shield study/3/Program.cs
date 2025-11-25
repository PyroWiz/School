using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] a = new char[,]
            {
                {'a','$','1',},
                {'B','@','0'},
                {'7','d','2'},
                {'u','*','i'}
            };
            Sod(a);
        }

        static void Sod(char[,] matrix)
        {
            int big = 0, small = 0, nums = 0, special = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    char point = matrix[i, j];

                    if ('a' <= point && 'z' >= point) small++;
                    else if ('A' <= point && 'Z' >= point) big++;
                    else if ('1' <= point && '9' >= point) nums++;
                    else special++;
                }
            }
            Console.WriteLine($"capital: {big}\nsmall: {small}\nnums: {nums}\nspecial: {special}");
        }
    }
}
