using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,]
            {
                { 0,3,2 },
                { 10,2,1 },
                { 2,1,3 },
            };

            Console.WriteLine(Harmony(a));
        }

        public static bool Harmony(int[,] arr)
        {
            int le = arr.GetLength(0);
            for (int ro = 0, co = le - 1; ro < le; ro++, co--)
            {
                int sum = 0, count = 0;
                int num = arr[ro, co];
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                for (int i = 1; i <= sum; i++)
                {
                    if (sum % i == 0) count++;
                    if (count > 2) return false;
                }

                int[] row = new int[le];
                int[] col = new int[le];
                for (int i = 0; i < le; i++)
                {
                    row[i] = arr[ro, i];
                    col[i] = arr[i, co];
                }

                for (int i = 0; i < le; i++)
                {
                    for (int j = 0; j < le - i - 1; j++)
                    {
                        if (row[j] > row[j + 1])
                        {
                            int temp = row[j];
                            row[j] = row[j + 1];
                            row[j + 1] = temp;
                        }
                        if (col[j] > col[j + 1])
                        {
                            int temp = col[j];
                            col[j] = col[j + 1];
                            col[j + 1] = temp;
                        }
                    }
                } //sort

                if (!(row[le / 2] == sum && col[le / 2] == sum)) return false;
            }

            return true;
        }
    }
}
