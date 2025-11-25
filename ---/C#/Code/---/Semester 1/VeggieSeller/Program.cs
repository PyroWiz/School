namespace VeggieSeller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seller = "moshik";
            string name;
            double kg;
            double price;
            double p1;
            double p2; 
            double p3;
            double cucumber;
            double divider;

            Console.WriteLine("please enter your name");
            name= Console.ReadLine();

            Console.WriteLine("how many kg of cucumbers do u wanna buy?");
            kg = double.Parse(Console.ReadLine());
            //calculations
            price = kg * 4;
            cucumber = kg * 10;/5
            divider = price / 3;
            p1 = p2 = p3 = divider;
            //results
            Console.WriteLine($"total price: '{price}' , \nyou will pay in 3 seperate transactions as follows: '{p1:f2}','{p2:f2}','{p3:f2}' \nthe number of purchased cucumbers: '{cucumber}'\nthanks for shopping!");


        }
    }
}
