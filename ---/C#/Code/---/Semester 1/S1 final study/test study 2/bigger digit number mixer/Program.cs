namespace bigger_digit_number_mixer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = 0, two = 0, newnum = 0, multi = 1;
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("Enter two positive whole numbers");
                one = int.Parse(Console.ReadLine());
                two = int.Parse(Console.ReadLine());
                if (one > 0 && two > 0) check = false;
            }

            while (one > 0 || two > 0)
            {
                int dig;
                dig = Math.Max(one % 10, two % 10) * multi;

                newnum += dig;
                multi *= 10;
                one /= 10;
                two /= 10;
            }

            Console.WriteLine(newnum);
        }
    }
}
