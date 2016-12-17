using SmallPlanets.Models;
using System.Collections.Generic;

namespace SmallPlanets.Interfaces
{
    public interface ISolarSystem
    {
        List<Planet> LoadSolarSystem();
    }
}
