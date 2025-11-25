namespace for10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter upper fracture and lower fracture");
            int upper = int.Parse(Console.ReadLine());
            int lower = int.Parse(Console.ReadLine());
            int divider = 0;
            int bigger = 0;

            if (upper > lower)
                bigger = upper;
            else
                bigger = lower;

            for (int i = 1;i <bigger;i++)
            {
                if (upper % i == 0 && lower % i == 0)
                    divider = i;
            }

            Console.WriteLine($"best divider is:"+divider);
            Console.WriteLine($"fracture after reduction using the found divider:"+upper/divider+"/"+lower/divider);


        }
    }
}
