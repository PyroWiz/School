namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number, positive only");
            int number = int.Parse(Console.ReadLine());
            int digits = number;
            int count = 1;
            while (digits > 0)
            {
                digits /= 10;
                if (digits > 0) count++;
            }

            int newnum = 0;
            
            for (int i = count; i >= 0; i--)
            {
                if (i%2!=0)
                {
                    if (i != count) newnum *=10;
                    newnum +=number % 10;
                }
                number/=10;
            }
            int finalnum = 0;
            while (newnum > 0)
            {
                finalnum = finalnum + (newnum % 10);
                if (newnum >10)finalnum *= 10;
                newnum /=10;
            }

           Console.WriteLine(finalnum);
        }
    }
}
