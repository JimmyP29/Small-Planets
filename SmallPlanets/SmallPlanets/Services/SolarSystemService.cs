using SmallPlanets.Interfaces;
using SmallPlanets.Models;
using SmallPlanets.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SmallPlanets.Services
{
    public class SolarSystemService : ISolarSystem
    {
        
       // private readonly IAPIConsumer _apiConsumer;

        //public SolarSystemService(IAPIConsumer apiConsumer)
        //{
        //    _apiConsumer = apiConsumer;
        //}
        public Planet GetPlanetByName(SolarSystem solarSystem, string name)
        {
            return solarSystem.Planets.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());
        }

        public List<Planet> LoadSolarSystem(IAPIConsumer apiConsumer)
        {
            //_apiConsumer = apiConsumer;
            SolarSystem solarSystem = apiConsumer.GetSolarSystem();
            return solarSystem.Planets;
        }
    }
}