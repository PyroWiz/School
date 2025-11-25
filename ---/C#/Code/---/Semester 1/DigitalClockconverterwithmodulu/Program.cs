namespace DigitalClockconverterwithmodulu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter seconds");
            int seconds = int.Parse(Console.ReadLine());
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            seconds = seconds % 60;
            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}
