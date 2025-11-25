using System;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuManager();
        }
        static void MenuManager()
        {
            int menu = 1;
            while (menu != 5)
            {
                Console.Clear();
                PrintMenu();
                menu = int.Parse(Console.ReadLine()); if (menu == 5) break; if (menu > 5 || menu < 1) Console.WriteLine("Wrong selection try again");
                Switch(menu);
                Console.WriteLine("enter any key");
                Console.ReadKey();
            }
        }
        static void PrintMenu()
        {
            Console.WriteLine("Choose option:" +
                "\n1. Numbers Triangle" +
                "\n2. Reversed Number" +
                "\n3. Sum of digits" +
                "\n4. Compare Numbers" +
                "\n5. Exit");
        }
        static void Switch(int menu)
        {
            switch (menu)
            {
                case 1:
                    Console.WriteLine("enter size of triangle");
                    int range = int.Parse(Console.ReadLine());
                    NumbersTriangle(range);
                    break;
                case 2:
                    Console.WriteLine("enter a whole number");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine($"reversed number: {ReversedNumber(num)}");
                    break;
                case 3:
                    Console.WriteLine("enter whole number");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine($"sum of digits in number: {SumOfDigits(number)}");
                    break;
                case 4:
                    Console.WriteLine("enter two numbers");
                    int firstNum = int.Parse(Console.ReadLine());
                    int secondNum = int.Parse(Console.ReadLine());
                    Console.WriteLine((CompareNumbers(firstNum, secondNum)) ? "true" : "false");
                    break;
            }
        }
        static void NumbersTriangle(int range)
        {
            for (int rows = 1; rows <= range; rows++)
            {
                for (int space = range - rows; space > 0; space--)
                    Console.Write(" ");

                for (int left = 1; left <= range - (range - rows); left++)
                    Console.Write(left);

                for (int right = range - (range - rows) - 1; right > 0; right--)
                    Console.Write(right);

                Console.WriteLine();
            }
        }
        static int ReversedNumber(int num)
        {
            int reversed = 0;

            while (num > 0)
            {
                reversed *= 10;
                reversed += num % 10;
                num /= 10;
            }
            return reversed;
        }
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        static bool CompareNumbers(int firstNum, int secondNum)
        {
            if (SumOfDigits(firstNum) > SumOfDigits(secondNum)) return true;
            else return false;
        }

    }
}
