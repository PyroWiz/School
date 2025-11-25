using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static void Changes(Food[] arr, Food newFood)
        {
            foreach (Food food in arr)
            {
                if (food.CanChange(newFood)) Console.WriteLine(food.GetName());
            }
        }
        public static void Offers(Food[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0 + i + 1; j < arr.Length; j++)
                {
                    if (arr[i].GetPrice() + arr[j].GetPrice() < 100)
                    {
                        Console.WriteLine($"Deal: {arr[i].GetName()} + {arr[j].GetName()}");
                    }
                }
            }
        }
    }
}
