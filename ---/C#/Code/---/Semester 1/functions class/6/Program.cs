namespace _6
{
    internal class Program
    {
        static string User()
        {
            string temp = Console.ReadLine();
            return temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter username");
            string user = User();
            Console.WriteLine(user);
        }
    }
}
