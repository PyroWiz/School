using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Game
    {
        string name; string genre; string platform; int year; double score;

        public string GName() { return this.name; }
        public string GGenre() { return this.genre; }
        public string GPlat() { return this.platform; }
        public int GYear() { return this.year; }
        public double GScore() { return this.score; }

        public void SName(string name)
        {
            this.name = name;
        }
        public void SGenre(string genre)
        {
            this.genre = genre;
        }
        public void SPlatform(string platform)
        {
            this.platform = platform;
        }
        public void SYear(int year)
        {
            this.year = year;
        }
        public void SScore(double score)
        {
            if (score >= 0 && score <= 5) this.score = score;
            else Console.WriteLine("invalid input");
        }

        public void Remove()
        {
            this.name = "";
            this.genre = "";
            this.platform = "";
            this.year = 0;
            this.score = 0;
        }

        public void Print()
        {
            Console.WriteLine("name: " + name + "genre: " +genre+"platform: "+platform+"year: "+year+"score: "+score+"\n");
        }


    }
}

