using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_improved
{
    internal class Game
    {
        string name, genre, platform; int year; double score;

        // Name
        public string GetName() { return name; }
        public void SetName(string value) { name = value; }

        // Genre
        public string GetGenre() { return genre; }
        public void SetGenre(string value) { genre = value; }

        // Platform
        public string GetPlatform() { return platform; }
        public void SetPlatform(string value) { platform = value; }

        // Year
        public int GetYear() { return year; }
        public void SetYear(int value) { year = value; }

        // Score
        public double GetScore() { return score; }
        public void SetScore(double value) { score = value; }


        public void Delete()
        {
            name = "";
            genre = "";
            platform = "";
            year = 0;
            score = 0;
        }
    }
}
