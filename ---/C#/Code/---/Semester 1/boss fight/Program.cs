namespace boss_fight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double HP;
            int PN;
            HP = 100;
            PN = 0;

            for ( ; PN < 3; )

            {
                HP = HP * 0.5;
                PN = PN + 1;

            }

            Console.WriteLine("boss hp after hitting him 3 times is: " + HP);
        }
    }
}
