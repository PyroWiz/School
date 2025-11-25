namespace Clinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type;
            string name;
            int age;
            string reason;
            string ownername;
            string address;
            string tel;
            int time;
            


            Console.WriteLine("welcome to out pet clinic,\nplease enter the type of the pet that will be recieving treatment");
            type = Console.ReadLine();
            Console.WriteLine("please enter the name of your pet");
            name = Console.ReadLine();
            Console.WriteLine("enter your pets age in full years");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("whats the reason for your visit?");
            reason = Console.ReadLine();
            Console.WriteLine("enter your full name,address and telephone number in the next 3 lines please ");
            ownername = Console.ReadLine();
            address = Console.ReadLine();
            tel = Console.ReadLine();

            Console.WriteLine("how many hours of treatment are u interested in?, we charge 20$ per hour,and we only do full hours");
            time=int.Parse(Console.ReadLine());

            Console.WriteLine("Thank you for booking with us!,here are the details of your appoinment:");
            Console.WriteLine("\npet details:\n\ntype : " + type + "\nname: " + name + "\nage: " + age + "\nreason for visit:" + reason + "\n\n" +
                "client details: \nname: "+ownername+"\naddress: "+address+"\ntelephone number: "+tel+"\n\namount charged for "+time+" hours: " +
                20*time+"$\nthanks for your appoinment!");

            
            
        }
    }
}
