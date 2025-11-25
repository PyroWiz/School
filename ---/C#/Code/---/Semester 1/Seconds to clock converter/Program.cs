namespace Seconds_to_clock_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter how many seconds you want to calculate");
            int seconds = int.Parse(Console.ReadLine());
            int hours, minutes;
            hours = seconds / 3600;
            seconds -= hours * 3600;
            minutes = seconds / 60;
            seconds -= minutes * 60;
            
            Console.WriteLine($"{hours}:{minutes}:{seconds}");

        }
    }
}
