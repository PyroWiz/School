namespace Letter_pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            char l = '!';
            while (check == true)
            {
                Console.WriteLine("enter a letter");
                l = char.Parse(Console.ReadLine());
                if ((l <= 'z' && l >= 'a') || (l <= 'Z' && l >= 'A')) check = false;
            }

            l += (l <= 'Z' && l >= 'A') ? (char)32 : (char)0;
            int core = l - 'a';

            for (int main = core + 1; main > 0; main--, core--)
            {
                int tempcore = core;
                for (; tempcore > 0; tempcore--)
                {
                    Console.Write(" ");
                }
                for (char a = 'a'; a < l - core; a++)
                {
                    Console.Write(a);
                }
                for (char b = (char)(l - core); b >= 'a'; b--)
                {
                    Console.Write(b);
                }
                Console.WriteLine();
            }
        }
    }
}
