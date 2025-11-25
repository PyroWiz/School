namespace average_calculator_using_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter grade");
            int grade=0;
            int count = 0;
            int sum = 0;
            do
            {
                grade = int.Parse(Console.ReadLine());
                if(grade >= 0)
                {
                    count++;
                    sum +=grade;
                }

            } while (grade >=0);
            Console.WriteLine(sum/count);
           
        }
    }
}
