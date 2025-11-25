using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuManager();
        }
        static void MenuManager()
        {
            while (true)
            {
                Console.Clear();
                PrintMenu();
                char choice = char.Parse(Console.ReadLine()); if (choice == 'c') break;
                Switch(choice);
                Console.WriteLine("\nenter any key");
                Console.ReadKey();
            }
        }
        static void PrintMenu()
        {
            Console.WriteLine("\na) Does the number contain or divisible by seven?\nb) Seven Boom\nc) Exit");
        }
        static void Switch(char choice)
        {
            switch (choice)
            {
                case 'a':
                    Console.WriteLine("enter whole number");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine((ContainsSeven(x)) ? "YES" : "NO");
                    break;
                case 'b':
                    Console.WriteLine("Enter number for 7 boom");
                    int y = int.Parse(Console.ReadLine());
                    SevenBoom(y);
                    break;
            }
        }
        static bool ContainsSeven(int num)
        {
            while (num > 0)
            {
                if ((num % 10 == 7) || (num % 7 == 0))
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }
        static void SevenBoom(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (!ContainsSeven(i))
                    Console.Write(i);
                else
                    Console.Write("BOOM");
                Console.Write(' ');
            }
        }
    }
}
