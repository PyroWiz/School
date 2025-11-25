using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameLibrary lib = new GameLibrary();
            Game one = new Game();
            Game two = new Game();

            one.SName("Persona 5");
            one.SGenre("RPG");
            one.SPlatform("PC");
            one.SYear(2015);
            one.SScore(4.5);

            two.SName("Dragons Dogma 2");
            two.SGenre("Action");
            two.SPlatform("PC");
            two.SYear(2023);
            two.SScore(5);

            lib.AddGame(one);
            lib.AddGame(two);

            lib.SortByScore();

            lib.DisplayGames();
        }
    }
}
