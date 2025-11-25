namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char fam;
            do
            {
                Console.WriteLine("enter your family name first letter");
                fam = char.Parse(Console.ReadLine());

            } while (!(fam >= 'a' || fam <= 'z'));

            if (fam <= 'i') { Console.WriteLine("u are invited at sunday"); }
            else if (fam == 'k' || fam == 'l') { Console.WriteLine("you are invited at monday"); }
            else { Console.WriteLine("you are invited at tuesday"); }
        }
    }
}
