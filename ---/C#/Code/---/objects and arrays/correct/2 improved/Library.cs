using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_improved
{
    internal class Library
    {
        Game[] library = new Game[0]; int games = 0;

        public Library(int i = 0)
        {
            library = new Game[i];
            games = i;
        }
        public void AddGame(Game game)
        {
            games++;
            if (games >= library.Length)
            {
                Game[] arr = new Game[library.Length + 1];
                for (int i = 0; i < library.Length; i++)
                {
                    arr[i] = library[i];
                }
                arr[arr.Length - 1] = game;
                library = arr;
                return;
            }
            else
            {
                for (int i = 0; i < library.Length; i++)
                {
                    if (library[i].GetName() == "")
                    {
                        library[i] = game;
                        return;
                    }
                }
            }
        }
        public void RemoveGame(string name)
        {
            for (int i = 0; i < library.Length; i++)
            {
                if (name == library[i].GetName())
                {
                    library[i].Delete();
                    return;
                }
            }
        }
        public Game[] FindGamesByGenre(string value)
        {
            Game[] arr = new Game[library.Length];
            for (int i = 0, c = 0; i < library.Length; i++)
            {
                if (library[i].GetGenre() == value)
                {
                    arr[c] = library[i];
                    c++;
                }
            }
            return arr;
        }
        public Game[] FindGamesByPLatform(string value)
        {
            Game[] arr = new Game[library.Length];
            for (int i = 0, c = 0; i < library.Length; i++)
            {
                if (library[i].GetPlatform() == value)
                {
                    arr[c] = library[i];
                    c++;
                }
            }
            return arr;
        }

        public void SortGamesByRating()
        {
            for (int max = library.Length - 1; max > 0; max--)
            {
                for (int cursor = 0; cursor < max; cursor++)
                {
                    if (library[cursor].GetScore() > library[cursor + 1].GetScore())
                    {
                        Game temp = library[cursor];
                        library[cursor] = library[cursor + 1];
                        library[cursor + 1] = temp;
                    }
                }
            }
        }
        public void SortGamesByYear()
        {
            for (int max = library.Length - 1; max > 0; max--)
            {
                for (int cursor = 0; cursor < max; cursor++)
                {
                    if (library[cursor].GetYear() > library[cursor + 1].GetYear())
                    {
                        Game temp = library[cursor];
                        library[cursor] = library[cursor + 1];
                        library[cursor + 1] = temp;
                    }
                }
            }
        }

        public void DisplayGames()
        {
            for (int i = 0; i < library.Length; i++)
            {
                Console.WriteLine(library[i].GetName());
            }
        }

        public Game[] SearchGames(string query)
        {
            Game[] arr = new Game[library.Length];
            int c = 0;
            for (int i = 0; i < library.Length; i++)
            {
                string game = library[i].GetName();
                string genre = library[i].GetGenre();
                if (query.Contains(game) || query.Contains(genre))
                {
                    arr[c] = library[i];
                }
            }
            return arr;
        }

    }
}
