using SmallPlanets.Interfaces;
using SmallPlanets.Models.ViewModels;
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

        public Planet GetPlanetFromSolarSystem(string planetName)
        {
            return _solarSystemService.GetPlanetByName(this, planetName);
        }
    }
}