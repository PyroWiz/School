namespace Logical_commands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 99;
            bool res = (a >= 7) && (a <= 40);
            Console.WriteLine(res);

            res = !(3>=a)&&(a<=15);
            Console.WriteLine(res);

            res = (a % 3 ==0) && (a % 5 == 0);
            Console.WriteLine(res);

            res = (a % 2 == 0) && (a % 3 == 0) && (a % 3 != 0);
            Console.WriteLine(res);

            bool dual = (a >= 10) && (a <= 99);
            int one = a % 10;
            a/=10;
            res = (a + one) > 10 && dual;
            Console.WriteLine(res);



        }
    }
}
