namespace rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to a rock papaer scissors simulator\nevery round type R for rock,P for paper and S for scissors,\n" +
                "game will end when a player wins 4 rounds");

            int wins1 = 0;
            int wins2 = 0;
            int rounds = 1;
            char input1,input2;

            do
            {
                Console.WriteLine($"ROUND-{rounds}-\nplayer 1 turn:");
                input1 = char.Parse(Console.ReadLine());
                Console.WriteLine("player 2 turn:");
                input2 = char.Parse(Console.ReadLine());

                if (input1 == input2)
                    Console.WriteLine("TIE");
                else if (input1 == 'R' && input2 == 'S')
                {
                    Console.WriteLine("\nPlayer 1 won this round");
                    wins1++;

                }
                else if (input1 == 'P' && input2 == 'R')
                {
                    Console.WriteLine("\nPlayer 1 won this round");
                    wins1++;
                }
                else if (input1 == 'S' && input2 == 'P')
                {
                    Console.WriteLine("\nPlayer 1 won this round");
                    wins1++;
                }
                //flip
                else if (input1 == 'S' && input2 == 'R')
                {
                    Console.WriteLine("\nPlayer 2 won this round");
                    wins2++;
                }
                else if (input1 == 'R' && input2 == 'P')
                {
                    Console.WriteLine("\nPlayer 2 won this round");
                    wins2++;
                }
                else if (input1 == 'P' && input2 == 'S')
                {
                    Console.WriteLine("\nPlayer 2 won this round");
                    wins2++;
                }
                else 
                    Console.WriteLine("\nincorrect inputs");

                rounds++;


            } while (wins1 <4 && wins2 <4);

            if (wins1 == 4)
            {
                Console.WriteLine("\nPLAYER 1 WON THE GAME");
            }

            if (wins2 == 4)
            {
                Console.WriteLine("\nPLAYER 2 WON THE GAME");
            }

            else
               Console.WriteLine("bug");


        }
    }
}
