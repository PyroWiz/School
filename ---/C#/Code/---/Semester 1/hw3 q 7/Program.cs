using System.Security;

namespace hw3_q_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Dish;
            double Nis;
            double Cal;
            bool Kosher;
            double Con;
            double Dollar;

            Console.WriteLine("please enter the name of the dish");
            Dish= Console.ReadLine();

            Console.WriteLine("enter price in shekels");
            Nis=double.Parse(Console.ReadLine());

            Console.WriteLine("enter amount of calories of the meal");
            Cal=double.Parse(Console.ReadLine());

            Console.WriteLine("is the meal kosher? enter true or false");
            Kosher=bool.Parse(Console.ReadLine());

            Console.WriteLine("enter conversion rate for nis to dollar");
            Con=double.Parse(Console.ReadLine());

            Dollar=Con*Nis;

            Console.WriteLine($"name of dish: {Dish}\nPrice in shekels: {Nis} shekels\nPrice in dollars: {Dollar}$\nCalories: {Cal}\nIs the meal kosher? -{Kosher}");


        }
    }
}
