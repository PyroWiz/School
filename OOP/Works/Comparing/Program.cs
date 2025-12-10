using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person one = new Person(3, "a");
            Person two = new Person(1, "a");
            Person three = new Person(2, "c");

            Person[] arr = new Person[] { one, two, three };

           Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].GetName() + " ");
                Console.WriteLine(arr[i].GetId());
            }
        }

        public static void BubbleSort(Person[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        Person temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
