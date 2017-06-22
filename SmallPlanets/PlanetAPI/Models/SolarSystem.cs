using PlanetAPI.Enums;
using PlanetAPI.Interfaces;
using System.Collections.Generic;

namespace PlanetAPI.Models
{
    public class SolarSystem
    {
        private readonly IPlanetBuilder _planetBuilder;
        public List<Planet> Planets { get; set; }

        public SolarSystem(IPlanetBuilder planetBuilder)
        {
            _planetBuilder = planetBuilder;
            CreateSolarSystem();
        }

        public void CreateSolarSystem()
        {
            Planet mercury = _planetBuilder.Create(PlanetEnum.Mercury);
            Planet venus = _planetBuilder.Create(PlanetEnum.Venus);
            Planet earth = _planetBuilder.Create(PlanetEnum.Earth);
            Planet mars = _planetBuilder.Create(PlanetEnum.Mars);
            Planet jupiter = _planetBuilder.Create(PlanetEnum.Jupiter);
            Planet saturn = _planetBuilder.Create(PlanetEnum.Saturn);
            Planet uranus = _planetBuilder.Create(PlanetEnum.Uranus);
            Planet neptune = _planetBuilder.Create(PlanetEnum.Neptune);
            Planet pluto = _planetBuilder.Create(PlanetEnum.Pluto);

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