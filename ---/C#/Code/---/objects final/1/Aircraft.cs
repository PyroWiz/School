using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Aircraft
    {
        int distance, passengers, crew;
        static readonly Random rnd = new Random();

        #region builders
        public Aircraft(int distance, int passengers, int crew) //manual settings
        {
            SetDistance(distance);
            SetPassengers(passengers);
            SetCrew(crew);
        }
        public Aircraft() //default
        {
            this.distance = 0;
            this.passengers = 0;
            this.crew = 0;
        }
        public Aircraft(Aircraft air) //copy
        {
            SetDistance(air.GetDistance());
            SetPassengers(air.GetPassengers());
            SetCrew(air.GetCrew());
        }
        public Aircraft(int random) //set random values
        {
            this.distance = rnd.Next(1, 1000);
            this.passengers = rnd.Next(1, 200);
            this.crew = rnd.Next(1, 20);
        }
        #endregion
        #region get
        public int GetDistance()
        {
            return this.distance;
        }
        public int GetPassengers()
        {
            return this.passengers;
        }
        public int GetCrew()
        {
            return this.crew;
        }
        #endregion
        #region set
        public void SetDistance(int distance)
        {
            this.distance = distance;
        }
        public void SetPassengers(int passengers)
        {
            this.passengers = passengers;
        }
        public void SetCrew(int crew)
        {
            this.crew = crew;
        }
        #endregion
        public string ToString()
        {
            return "this airplane: \ntraveled " + this.distance + " meters\nhas " + this.passengers + " passengers\nand " + this.crew + " crew members\n";
        }

    }
}
