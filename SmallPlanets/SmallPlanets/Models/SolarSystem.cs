using SmallPlanets.Interfaces;
using System.Collections.Generic;

namespace SmallPlanets.Models
{
    public class SolarSystem
    {
        private readonly ISolarSystem _solarSystemService;

        public List<Planet> Planets { get; set; }

        public SolarSystem(ISolarSystem solarSystemService)
        {
            _solarSystemService = solarSystemService;

            Planets = new List<Planet>();
        }

        public void CreateSolarSystem()
        {
            Planets = _solarSystemService.LoadSolarSystem();
        }
    }
}