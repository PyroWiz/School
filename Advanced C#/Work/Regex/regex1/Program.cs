using System.Text.RegularExpressions;

namespace regex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("enter email");
                string input = Console.ReadLine();
                bool exists = Regex.IsMatch(input, @"^([a-zA-Z\d\.\-_]+)@([a-z]{2,15})((\.([a-z]+))|(\.([a-z][A-Z]+)\.([a-z]+)))$");
                Console.WriteLine(exists);
                if (exists) { break; }
            }
        }
    }
}
