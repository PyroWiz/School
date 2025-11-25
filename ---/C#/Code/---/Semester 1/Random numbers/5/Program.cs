namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, min = 0, max = 0,num=0;
            Random rnd = new Random();

            for (int i = 0;i <10;i++)
            {
                num = rnd.NextDouble()*(100-0)+0;
                if (i == 0) min = num;
                if (num < min) min = num;
                if (num > max) max = num;
                sum += num;
                Console.WriteLine($"{num:f3}");
            }
            Console.WriteLine($"smallest number: {min:f3}, biggest number : {max:f3}\nsum of all numbers: {sum/10:f}");

        }
    }
}
