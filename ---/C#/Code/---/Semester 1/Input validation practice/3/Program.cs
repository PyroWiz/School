namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            char op;

            do
            {
                Console.WriteLine("enter two positive numbers and an op, must be minus or plus");
                num1 = int.Parse(Console.ReadLine());
                op = char.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
            } while (!(num1 >= 0 && num2 >= 0 && op == '+' || op == '-'));

            switch (op)
            {
                case '+':
                    Console.WriteLine(num1+num2);
                    break;
                case '-':
                    Console.WriteLine(num1-num2);
                    break;
            }
        }
    }
}
