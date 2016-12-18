using System;
using System.Collections.Generic;
using System.IO;

namespace PlanetAPI.Models
{
    public class SolarSystem
    {
        public List<Planet> Planets { get; set; }

        public SolarSystem()
        {
            System.Drawing.Image image = System.Drawing.Image.FromFile("C:/Users/James/Documents/GitHub/Small-Planets/SmallPlanets/PlanetAPI/Images/saturn.jpeg");
            Planets = new List<Planet>()
            {
                new Planet() { Name = "Mercury", Diameter = "100.000", DistanceFromSun = "120.000", Mass = "130.000", Image = null },
                new Planet() { Name = "Venus", Diameter = "200.000", DistanceFromSun = "220.000", Mass = "230.000", Image = null },
                new Planet() { Name = "Earth", Diameter = "300.000", DistanceFromSun = "320.000", Mass = "330.000", Image = null },
                new Planet() { Name = "Mars", Diameter = "400.000", DistanceFromSun = "420.000", Mass = "430.000m", Image = null },
                new Planet() { Name = "Jupiter", Diameter = "500.000", DistanceFromSun = "520.000", Mass = "530.000", Image = null },
                new Planet() { Name = "Saturn", Diameter = "600.000", DistanceFromSun = "620.000", Mass = "630.000", Image = Convert.ToBase64String(ImageToByteArray(image)) },
                new Planet() { Name = "Uranus", Diameter = "700.000", DistanceFromSun = "720.000", Mass = "730.000", Image = null },
                new Planet() { Name = "Neptune", Diameter = "800.000", DistanceFromSun = "820.000", Mass = "830.000", Image = null },
                new Planet() { Name = "Pluto", Diameter = "900.000", DistanceFromSun = "920.000", Mass = "930.000", Image = null }
            };
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}