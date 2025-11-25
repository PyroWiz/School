namespace hw3_question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;

            Console.WriteLine("enter 3 numbers and press enter after each to comfirm input");

            x=int.Parse(Console.ReadLine());
            y=int.Parse(Console.ReadLine());
            z=int.Parse(Console.ReadLine());

            Console.WriteLine($"'{z}'\n'{z}'\t'{y}'\n'{z}'\t'{y}'\t'{x}'");
        }
    }
}
