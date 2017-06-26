using SmallPlanets.Models;
using SmallPlanets.Models.ViewModels;

using System.Collections.Generic;

namespace SmallPlanets.Interfaces
{
    public interface ISolarSystem
    {
        List<Planet> LoadSolarSystem(IAPIConsumer apiConsumer);
        Planet GetPlanetByName(SolarSystem solarSystem, string name);
    }
}
