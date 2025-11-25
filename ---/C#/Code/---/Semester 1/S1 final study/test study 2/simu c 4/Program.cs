namespace simu_c_4
{

    /*
        1
       111
      11211
     1123211
    112343211
    */



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int core = int.Parse(Console.ReadLine());

            for (int i = core + 1; i > 0; i--)
            {
                bool first = true, last = true;
                for (int space = i - 1; i > 0; i--)
                {
                    Console.Write(" ");
                }

                if (first == true) { Console.Write("1"); first = false; }

                for (int left = 1; left < core; left++)
                {
                    Console.Write(left);
                }

                for (int right = core - 1; right > 0; right--)
                {
                    Console.Write(right);
                }

                if (last == true) { Console.Write("1"); last = false; }

                Console.WriteLine();
            }
        }
    }
}
