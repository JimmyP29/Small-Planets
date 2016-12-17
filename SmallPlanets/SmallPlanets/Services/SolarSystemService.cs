using SmallPlanets.Interfaces;
using SmallPlanets.Models;
using System.Collections.Generic;

namespace SmallPlanets.Services
{
    public class SolarSystemService : ISolarSystem
    {
        public List<Planet> LoadSolarSystem()
        {
            // Consume API
            List<Planet> solarSystem = new List<Planet>() {
                new Planet() { Name = "Mercury", Diameter = 100.000m, DistanceFromSun = 120.000m, Mass = 130.000m, Image = null },
                new Planet() { Name = "Venus", Diameter = 200.000m, DistanceFromSun = 220.000m, Mass = 230.000m, Image = null },
                new Planet() { Name = "Earth", Diameter = 300.000m, DistanceFromSun = 320.000m, Mass = 330.000m, Image = null },
                new Planet() { Name = "Mars", Diameter = 400.000m, DistanceFromSun = 420.000m, Mass = 430.000m, Image = null },
                new Planet() { Name = "Jupiter", Diameter = 500.000m, DistanceFromSun = 520.000m, Mass = 530.000m, Image = null },
                new Planet() { Name = "Saturn", Diameter = 600.000m, DistanceFromSun = 620.000m, Mass = 630.000m, Image = null },
                new Planet() { Name = "Uranus", Diameter = 700.000m, DistanceFromSun = 720.000m, Mass = 730.000m, Image = null },
                new Planet() { Name = "Neptune", Diameter = 800.000m, DistanceFromSun = 820.000m, Mass = 830.000m, Image = null },
                new Planet() { Name = "Pluto", Diameter = 900.000m, DistanceFromSun = 920.000m, Mass = 930.000m, Image = null }
            };



            return solarSystem;
        }
    }
}