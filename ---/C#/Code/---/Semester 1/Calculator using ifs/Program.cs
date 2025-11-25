namespace Calculator_using_ifs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            int num1, num2, res = 0;
            bool opOK = true;

            Console.WriteLine("Please enter a math expression: ");
            num1 = int.Parse(Console.ReadLine());
            op = char.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            if (op == '+') res = num1 + num2;
            else if (op == '-') res = num1 - num2;
            else if (op == '*') res = num1 * num2;
            else opOK = false;

            if (opOK == true)
                Console.WriteLine($"The result is {res}");
            else
                Console.WriteLine("invalid operand");

        }
    }
}
