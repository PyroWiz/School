namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multi1 = 0;
            int multi2 = 0;
            int multi_sum = 0;
            int a=0,b=0,c=0,d=0;
            do
            {
                Console.WriteLine("enter two numbers");
                a=int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("enter another two numbers");
                c = int.Parse(Console.ReadLine());
                d = int.Parse(Console.ReadLine());

                multi1 = a * b;
                multi2 = c * d;
                multi_sum += multi1 + multi2;

            } while (multi1 != 0 && multi2 !=0);

            Console.Write("sum of all multis:");
            Console.WriteLine(multi_sum);
        }
    }
}
