namespace Calculator_using_switch
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

            switch (op)
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                default:
                    opOK = false;
                    break;
            }
            if (opOK == true)
                Console.WriteLine($"The result is {res}");
            else
                Console.WriteLine("invalid operand");

        }
    }
}
