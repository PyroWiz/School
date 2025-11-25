using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class GameLibrary
    {
        Game[] games = new Game[0]; int num;

        public GameLibrary()
        {
            this.games = new Game[0];
            num = 0;
        }
        public GameLibrary(int num)
        {
            this.games = new Game[num];
            this.num = num;
        }


        public void AddGame(Game game)
        {
            if (num >= games.Length)
            {
                Game[] newGames = new Game[games.Length + 1];
                for (int i = 0; i < games.Length; i++)
                {
                    newGames[i] = games[i];
                }
                games = newGames;
            }

            games[num] = game;
            num++;
        }

        public void RemoveGame(string name)
        {
            for (int i = 0; i < games.Length; i++)
            {
                if (games[i].GName() == name) games[i].Remove();
            }
            num--;
        }

        public GameLibrary ByGenre(string genre)
        {
            GameLibrary bygenre = new GameLibrary();
            for (int i = 0; i < games.Length; i++)
            {
                if (games[i].GGenre() == genre) bygenre.AddGame(games[i]);
            }

            return bygenre;
        }

        public GameLibrary ByPlat(string plat)
        {
            GameLibrary byplat = new GameLibrary();
            for (int i = 0; i < games.Length; i++)
            {
                if (games[i].GPlat() == plat) byplat.AddGame(games[i]);
            }

            return byplat;
        }

        public void SortByScore()
        {
            Array.Sort(games,
                (a, b) => b.GScore().CompareTo(a.GScore())
            );
        }

        public Game WhosHighestGame(Game[] list)
        {
            Game[] copy = new Game[games.Length];
            Game highest = new Game();
            for (int i = 0; i < games.Length; i++)
            {
                if (highest.GScore() < games[i].GScore())
                {
                    highest = games[i];
                }
            }

            return highest;
        }
        public string WhosHighestName(Game[] list)
        {
            string name = "";
            Game[] copy = new Game[games.Length];
            Game highest = new Game();
            for (int i = 0; i < games.Length; i++)
            {
                if (highest.GScore() < games[i].GScore())
                {
                    name = games[i].GName();
                }
            }

            return name;
        }

        public void SortByYear()
        {
            Game[] copy = new Game[0];
            copy = games;
            for (int i = 0; i < games.Length; i++)
            {
                games[i] = WhosHighestYear(copy);
                RemoveGame(WhosHighestNameForYear(copy));
            }
        }

        public Game WhosHighestYear(Game[] list)
        {
            Game[] copy = new Game[games.Length];
            Game highest = new Game();
            for (int i = 0; i < games.Length; i++)
            {
                if (highest.GYear() < games[i].GYear())
                {
                    highest = games[i];
                }
            }

            return highest;
        }
        public string WhosHighestNameForYear(Game[] list)
        {
            string name = "";
            Game[] copy = new Game[games.Length];
            Game highest = new Game();
            for (int i = 0; i < games.Length; i++)
            {
                if (highest.GYear() < games[i].GYear())
                {
                    name = games[i].GName();
                }
            }

            return name;
        }

        public void DisplayGames()
        {
            for (int i = 0; i < games.Length; i++)
                games[i].Print();
        }

        public Game[] Search(string name)
        {
            int length = 0;
            Game[] array = new Game[0];
            for (int i = 0; i < games.Length; i++)
            {
                if (games[i].GName() == name || games[i].GGenre() == name)
                {
                    length++;
                }
            }
            for (int i = 0; i < games.Length; i++)
            {
                if (games[i].GName() == name || games[i].GGenre() == name)
                {
                    array[i] = games[i];
                }
            }
            return array;
        }

        public Game[] HighestInLib(int n)
        {
            Game[] array = new Game[n];

            SortByScore();

            for (int i = 0; i < n; i++)
            {
                array[i] = games[i];
            }
            return array;
        }
    }
}
