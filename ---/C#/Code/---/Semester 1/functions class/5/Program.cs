using System.Text;

namespace _5
{
    internal class Program
    {
        static string Ascii(char cha)
        {
            int temp = (int)cha;
            string tomp = $"{temp}";
            return tomp;
        }
        static void Loop(string final)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(final);
            }
        }
        static void Main(string[] args)
        {
            StringBuilder sequence = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter a char");
                char cha = char.Parse(Console.ReadLine());
                string num = Ascii(cha);
                sequence.Append(num);
            }

            string final = sequence.ToString();
            Loop(final);
        }
    }
}
