namespace OrBookSeller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Commision = 15;
            int Sales_1, Sales_2;
            string Agent_1, Agent_2;
            double Base_Salary_1, Base_Salary_2, Tax_1, Tax_2, Total_1, Total_2;
            //agent 1
            Console.WriteLine("Please enter the first agent's name");
            Agent_1 = Console.ReadLine();
            Console.WriteLine("Please enter the agent's base salary");
            Base_Salary_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of books the agent sold");
            Sales_1 = int.Parse(Console.ReadLine());
            // agent 2
            Console.WriteLine("Please enter the second Agent's name");
            Agent_2 = Console.ReadLine();
            Console.WriteLine("Please enter the agnet's base salary");
            Base_Salary_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of books the agent sold");
            Sales_2 = int.Parse(Console.ReadLine());
            Tax_1 = (double)((Sales_1 * Commision) / 4);
            Tax_2 = (double)((Sales_2 * Commision) / 4);
            Total_1 = (double)(Base_Salary_1 + Sales_1 * Commision + Tax_1);
            Total_2 = (double)(Base_Salary_2 + Sales_2 * Commision + Tax_2);
            Console.WriteLine($"{Agent_1} Has a base salary of: {Base_Salary_1}\n and he made a total of {Sales_1} sales. \n his total salary including the sales is:{Total_1}");
            Console.WriteLine($"{Agent_2} Has a base salary of: {Base_Salary_2}\n and he made a total of {Sales_2} sales. \n his total salary including the sales is {Total_2}");

        }
    }
}
