namespace positive_and_negatice_number_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0,total=0;
            bool flip = true,flip_old=true;
            int change = 0;

            Console.WriteLine("enter numbers, 999 to finish");

            do
            {
                input=int.Parse(Console.ReadLine());
                
                if (input !=999)
                {
                    total += input;

                    if (total >= 0)
                        flip = true;

                    if (total < 0)
                        flip = false;

                    if (flip != flip_old)
                        change++;

                    flip_old = flip;

                }

            } while (input != 999);

            Console.WriteLine($"total of all number:{total},number of flips:{change}");
        }
    }
}
