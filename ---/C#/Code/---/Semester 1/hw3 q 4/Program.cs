namespace hw3_q_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;

            Console.WriteLine("enter 3 numbers and enter afterwards to confirm");

            x=int.Parse(Console.ReadLine());
            y=int.Parse(Console.ReadLine());
            z=int.Parse(Console.ReadLine());

            Console.WriteLine($"'{y}'\t'{z}'");
            Console.WriteLine($"'{y}'\t'{x}'");
        }
    }
}
