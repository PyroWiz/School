namespace simu5_q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter numbers,only whole positives " +
                ",4 digit number to stop");
            int num = 0, count = 0;

            while(num>=0 && num <=999)
            {
                num = int.Parse(Console.ReadLine());
                if (!(num >= 0 && num <= 999)) break;
                while(num>0)
                {
                    if (num % 10 == 6) break;
                    num /= 10;
                    if (num == 0) count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
