using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore
{
    internal class Games : Products
    {
        string genre; bool multi;

        #region setget
        public void SetGenre(string genre)
        {
            this.genre = genre;
        }
        public string GetGenre()
        {
            return this.genre;
        }
        public void SetMulti(bool multi)
        {
            this.multi = multi;
        }
        public bool GetMulti()
        {
            return this.multi;
        }
        #endregion
        public Games(string genre, bool multi, double price, string name) : base(price, name)
        {
            SetGenre(genre);
            SetMulti(multi);
            SetPrice(price);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nGenre: {GetGenre()}\nMultiplayer Support: {GetMulti()}\n";
        }
    }
}
