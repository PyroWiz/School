using System;

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
            /*
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].GetName() + " ");
                Console.WriteLine(arr[i].GetId());
            }
            */


            Person[] arr2 = new Person[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = (Person)arr[i].Clone();
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr.ToString());
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
