using System;

namespace SmallPlanets.Models.Entities
{
    public class Log
    {
        public int ID { get; set; }
        public string PlanetName { get; set; }
        public string PlanetImage { get; set; }
        public DateTime Visited { get; set; }
    }
}