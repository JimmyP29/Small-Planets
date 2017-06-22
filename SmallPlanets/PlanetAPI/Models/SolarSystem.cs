using PlanetAPI.Enums;
using PlanetAPI.Helpers;
using System.Collections.Generic;

namespace PlanetAPI.Models
{
    public class SolarSystem
    {
        public List<Planet> Planets { get; set; }

        public SolarSystem()
        {
            CreateSolarSystem();
        }

        public void CreateSolarSystem()
        {
            PlanetBuilder builder = new PlanetBuilder();
            Planet mercury = builder.Create(PlanetEnum.Mercury);
            Planet venus = builder.Create(PlanetEnum.Venus);
            Planet earth = builder.Create(PlanetEnum.Earth);
            Planet mars = builder.Create(PlanetEnum.Mars);
            Planet jupiter = builder.Create(PlanetEnum.Jupiter);
            Planet saturn = builder.Create(PlanetEnum.Saturn);
            Planet uranus = builder.Create(PlanetEnum.Uranus);
            Planet neptune = builder.Create(PlanetEnum.Neptune);
            Planet pluto = builder.Create(PlanetEnum.Pluto);

            Planets = new List<Planet>
            {
                mercury,
                venus,
                earth,
                mars,
                jupiter,
                saturn,
                uranus,
                neptune,
                pluto
            };
        }
    }
}