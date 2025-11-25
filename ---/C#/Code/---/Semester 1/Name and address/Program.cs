using System.Transactions;

namespace Name_and_address
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string address;
            int yearofbirth;
            int age;

            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            Console.WriteLine("enter your address");
            address = Console.ReadLine();
            Console.WriteLine("enter your year of birth");
            yearofbirth=int.Parse(Console.ReadLine());
            age = 2024-yearofbirth;
            Console.WriteLine($"hello {name} from {address} !,\nyour age is: {age}\nin 5 years your age will be: {age+5}\nand in 7 years your age will be: {age+7}");        }
    }
}
