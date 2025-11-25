namespace homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string city;
            int num1;
            int num2;
            int plus;
            int minus;
            int multi;

            Console.WriteLine("Please enter ur full name");
            name = (Console.ReadLine());
            Console.WriteLine("Please enter ur city of residence");
            city = (Console.ReadLine());

            Console.WriteLine("Mr/Miss " + name + " lives in " + city);
            Console.WriteLine("enter two whole numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            plus = num1 + num2;
            minus = num1 - num2;
            multi = num1 * num2;

            Console.WriteLine($"plus='{plus}'\nminus='{minus}'\nmulti='{multi}'");
        }
    }
}
