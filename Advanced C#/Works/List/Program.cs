using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Dictionary = new Dictionary<string, string>();

            Dictionary.Add("apple", "tapuah");
            Dictionary.Add("bannana", "banana");
            Dictionary.Add("Phone", "telepon");
            Dictionary.Add("Screen", "masah");
            Dictionary.Add("Computer", "mahshev");

            Console.WriteLine("enter word in english");
            string word = Console.ReadLine();

            if (Dictionary.TryGetValue(word, out string name))
            {
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("doesnt exist in this dictionary");
            }

            Dictionary<string, List<string>> BetterDictionary = new Dictionary<string, List<string>>();

            BetterDictionary.Add("apple", new List<string> { "tapah", "tapa" });

            Console.WriteLine("enter word in english");
            string aword = Console.ReadLine();

            if (BetterDictionary.TryGetValue(aword, out List<string> aname))
            {
                foreach (string i in aname)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("doesnt exist in this dictionary");
            }
        }
    }
}
