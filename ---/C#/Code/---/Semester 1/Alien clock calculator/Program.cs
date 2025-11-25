using System.Reflection;

namespace Alien_clock_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutes, hours, days;
            const int MINUTES_IN_DAY = 640, MINUTES_IN_TWO_HOURS = 40,
                MINUTES_IN_EVEN_HOUR = 30, MINUTES_IN_ODD_HOUR = 10;

            Console.WriteLine("Enter the minutes Momik saw: ");
            minutes = int.Parse(Console.ReadLine());

            days = minutes / MINUTES_IN_DAY;
            minutes -= days * MINUTES_IN_DAY;
            hours = (minutes / MINUTES_IN_TWO_HOURS) * 2;
            minutes -= (hours / 2 * MINUTES_IN_EVEN_HOUR + hours / 2 * MINUTES_IN_ODD_HOUR);

            if (minutes >= MINUTES_IN_EVEN_HOUR)
            {
                hours++;
                minutes -= MINUTES_IN_EVEN_HOUR;
            }

            if (minutes >= MINUTES_IN_ODD_HOUR)
            {
                hours++;
                minutes -= MINUTES_IN_ODD_HOUR;
            }

            Console.WriteLine($"{days} Days, {hours} Hours, {minutes} Minutes");
        }
    }
}
