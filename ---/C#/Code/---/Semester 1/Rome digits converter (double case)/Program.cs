namespace Rome_digits_converter__double_case_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char romeDigit;
            int decimalNum=0;
            bool inputValid = true;

            Console.WriteLine("Please enter a rome digit: ");
            romeDigit = char.Parse(Console.ReadLine());
            switch (romeDigit)
            {
                case 'i':
                case 'I':
                    decimalNum = 1;
                    break;
                case 'v':
                case 'V':
                    decimalNum = 5;
                    break;
                case 'x':
                case 'X':
                    decimalNum = 10;
                    break;
                default:
                    inputValid = false;
                    break;
            }

            if (!inputValid)  // (inputValid == false)
                Console.WriteLine("Invalid input!");
            else
                Console.WriteLine($"Num is {decimalNum}");

        }
    }
}
