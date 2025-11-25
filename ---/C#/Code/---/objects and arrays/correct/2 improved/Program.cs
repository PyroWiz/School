using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_improved
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game one = new Game();
            one.SetName("DD2");
            one.SetScore(5);
            one.SetGenre("RPG");
            one.SetPlatform("all");
            one.SetYear(2024);

            Game two = new Game();
            two.SetName("P5");
            two.SetScore(4);
            two.SetGenre("turn base");
            two.SetPlatform("all");
            two.SetYear(2024);

            Game three = new Game();
            three.SetName("Overwatch");
            three.SetScore(2);
            three.SetGenre("fps");
            three.SetPlatform("all");
            three.SetYear(2024);

            Library lib = new Library();

            lib.AddGame(one);
            lib.AddGame(two);
            lib.AddGame(three);

            lib.SortGamesByRating();

            lib.DisplayGames();

        }
    }
}
