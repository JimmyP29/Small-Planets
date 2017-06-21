using PlanetAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace PlanetAPI.Models
{
    public class SolarSystem
    {
        public List<Planet> Planets { get; set; }

        public SolarSystem()
        {
            string mercury = "Mercury";
            string venus = "Venus";
            string earth = "Earth";
            string mars = "Mars";
            string jupiter = "Jupiter";
            string saturn = "Saturn";
            string uranus = "Uranus";
            string neptune = "Neptune";
            string pluto = "Pluto";
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = null;

            Bitmap mercuryImage = PlanetImage.GetPlanetImage(assembly, stream, mercury);
            Bitmap venusImage = PlanetImage.GetPlanetImage(assembly, stream, venus);
            Bitmap earthImage = PlanetImage.GetPlanetImage(assembly, stream, earth);
            Bitmap marsImage = PlanetImage.GetPlanetImage(assembly, stream, mars);
            Bitmap jupiterImage = PlanetImage.GetPlanetImage(assembly, stream, jupiter);
            Bitmap saturnImage = PlanetImage.GetPlanetImage(assembly, stream, saturn);
            Bitmap uranusImage = PlanetImage.GetPlanetImage(assembly, stream, uranus);
            Bitmap neptuneImage = PlanetImage.GetPlanetImage(assembly, stream, neptune);
            Bitmap plutoImage = PlanetImage.GetPlanetImage(assembly, stream, pluto);

            Planets = new List<Planet>()
            {
                new Planet()
                {
                    Name = mercury,
                    Diameter = PlanetInformation.GetPlanetDiameter(mercury),
                    DistanceFromSun = PlanetInformation.GetDistanceFromSun(mercury),
                    Mass = PlanetInformation.GetMass(mercury),
                    AdditionalInformation = PlanetInformation.GetAdditionalInformation(mercury),
                    Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(mercuryImage))
                },
                new Planet()
                {
                    Name = venus,
                    Diameter = PlanetInformation.GetPlanetDiameter(venus),
                    DistanceFromSun = PlanetInformation.GetDistanceFromSun(venus),
                    Mass = PlanetInformation.GetMass(venus),
                    AdditionalInformation = PlanetInformation.GetAdditionalInformation(venus),
                    Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(venusImage))
                },
                new Planet()
                {
                    Name = earth,
                    Diameter = PlanetInformation.GetPlanetDiameter(earth),
                    DistanceFromSun = PlanetInformation.GetDistanceFromSun(earth),
                    Mass = PlanetInformation.GetMass(earth),
                    AdditionalInformation = PlanetInformation.GetAdditionalInformation(earth),
                    Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(earthImage))
                },
                new Planet()
                {
                    Name = mars,
                    Diameter = PlanetInformation.GetPlanetDiameter(mars),
                    DistanceFromSun = PlanetInformation.GetDistanceFromSun(mars),
                    Mass = PlanetInformation.GetMass(mars),
                    AdditionalInformation = PlanetInformation.GetAdditionalInformation(mars),
                    Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(marsImage))
                },
                new Planet()
                {
                    Name = jupiter,
                    Diameter = PlanetInformation.GetPlanetDiameter(jupiter),
                    DistanceFromSun = PlanetInformation.GetDistanceFromSun(jupiter),
                    Mass = PlanetInformation.GetMass(jupiter),
                    AdditionalInformation = PlanetInformation.GetAdditionalInformation(jupiter),
                    Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(jupiterImage))
                },
                new Planet()
                {
                    Name = saturn,
                    Diameter = PlanetInformation.GetPlanetDiameter(saturn),
                    DistanceFromSun = PlanetInformation.GetDistanceFromSun(saturn),
                    Mass = PlanetInformation.GetMass(saturn),
                    AdditionalInformation = PlanetInformation.GetAdditionalInformation(saturn),
                    Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(saturnImage))
                },
                new Planet()
                { Name = uranus,
                    Diameter = PlanetInformation.GetPlanetDiameter(uranus),
                    DistanceFromSun = PlanetInformation.GetDistanceFromSun(uranus),
                    Mass = PlanetInformation.GetMass(uranus),
                    AdditionalInformation = PlanetInformation.GetAdditionalInformation(uranus),
                    Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(uranusImage))
                },
                new Planet()
                {
                    Name = neptune,
                    Diameter = PlanetInformation.GetPlanetDiameter(neptune),
                    DistanceFromSun = PlanetInformation.GetDistanceFromSun(neptune),
                    Mass = PlanetInformation.GetMass(neptune),
                    AdditionalInformation = PlanetInformation.GetAdditionalInformation(neptune),
                    Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(neptuneImage))
                },
                new Planet()
                {
                    Name = pluto,
                    Diameter = PlanetInformation.GetPlanetDiameter(pluto),
                    DistanceFromSun = PlanetInformation.GetDistanceFromSun(pluto),
                    Mass = PlanetInformation.GetMass(pluto),
                    AdditionalInformation = PlanetInformation.GetAdditionalInformation(pluto),
                    Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(plutoImage))
                }
            };
        }
    }
}