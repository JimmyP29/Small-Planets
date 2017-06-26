using SmallPlanets.Interfaces;
using SmallPlanets.Models;
using SmallPlanets.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SmallPlanets.Services
{
    public class SolarSystemService : ISolarSystem
    {
        public Planet GetPlanetByName(SolarSystem solarSystem, string name)
        {
            return solarSystem.Planets.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());
        }

        public List<Planet> LoadSolarSystem(IAPIConsumer apiConsumer)
        {
            SolarSystem solarSystem = apiConsumer.GetSolarSystem();
            return solarSystem.Planets;
        }
    }
}