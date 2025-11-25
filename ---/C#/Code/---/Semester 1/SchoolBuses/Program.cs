namespace SchoolBuses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            while (x == 0)
            {
                bool status = false;
                int check = 0;
                Console.WriteLine("Enter number of students");
                int students = int.Parse(Console.ReadLine());
                int buses = students / 40;

                if ((students%40)!=0)
                {
                    check = 1;
                    status = true;
                }
                
                Console.WriteLine($"number of full buses:{buses},not full bus:{status},total buses:{buses+check}");
                
                Console.WriteLine("reset?");
                x=int.Parse(Console.ReadLine());    
            }

        }
    }
}
