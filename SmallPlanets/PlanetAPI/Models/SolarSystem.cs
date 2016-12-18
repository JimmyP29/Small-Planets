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
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = null; //= assembly.GetManifestResourceStream("PlanetAPI.saturn.jpeg");
            Bitmap mercury = GetMercuryImage(assembly, stream);
            Bitmap venus = GetVenusImage(assembly, stream);
            Bitmap earth = GetEarthImage(assembly, stream);
            Bitmap mars = GetMarsImage(assembly, stream);
            Bitmap jupiter = GetJupiterImage(assembly, stream);
            Bitmap saturn = GetSaturnImage(assembly, stream);
            Bitmap uranus = GetUranusImage(assembly, stream);
            Bitmap neptune = GetNeptuneImage(assembly, stream);
            Bitmap pluto = GetPlutoImage(assembly, stream);
            //Image image6 = Image.FromFile("~/Images/saturn.jpeg");
            Planets = new List<Planet>()
            {
                new Planet() { Name = "Mercury", Diameter = "100.000", DistanceFromSun = "120.000", Mass = "130.000", Image = Convert.ToBase64String(ImageToByteArray(mercury)) },
                new Planet() { Name = "Venus", Diameter = "200.000", DistanceFromSun = "220.000", Mass = "230.000", Image = Convert.ToBase64String(ImageToByteArray(venus)) },
                new Planet() { Name = "Earth", Diameter = "300.000", DistanceFromSun = "320.000", Mass = "330.000", Image = Convert.ToBase64String(ImageToByteArray(earth)) },
                new Planet() { Name = "Mars", Diameter = "400.000", DistanceFromSun = "420.000", Mass = "430.000m", Image = Convert.ToBase64String(ImageToByteArray(mars)) },
                new Planet() { Name = "Jupiter", Diameter = "500.000", DistanceFromSun = "520.000", Mass = "530.000", Image = Convert.ToBase64String(ImageToByteArray(jupiter)) },
                new Planet() { Name = "Saturn", Diameter = "600.000", DistanceFromSun = "620.000", Mass = "630.000", Image = Convert.ToBase64String(ImageToByteArray(saturn)) },
                new Planet() { Name = "Uranus", Diameter = "700.000", DistanceFromSun = "720.000", Mass = "730.000", Image = Convert.ToBase64String(ImageToByteArray(uranus)) },
                new Planet() { Name = "Neptune", Diameter = "800.000", DistanceFromSun = "820.000", Mass = "830.000", Image = Convert.ToBase64String(ImageToByteArray(neptune)) },
                new Planet() { Name = "Pluto", Diameter = "900.000", DistanceFromSun = "920.000", Mass = "930.000", Image = Convert.ToBase64String(ImageToByteArray(pluto)) }
            };
        }

        #region Get Image methods
        private Bitmap GetMercuryImage(Assembly assembly, Stream stream)
        {
            stream = assembly.GetManifestResourceStream("PlanetAPI.mercury.jpeg");
            return new Bitmap(stream);
        }

        private Bitmap GetVenusImage(Assembly assembly, Stream stream)
        {
            stream = assembly.GetManifestResourceStream("PlanetAPI.venus.jpeg");
            return new Bitmap(stream);
        }

        private Bitmap GetEarthImage(Assembly assembly, Stream stream)
        {
            stream = assembly.GetManifestResourceStream("PlanetAPI.earth.jpeg");
            return new Bitmap(stream);
        }

        private Bitmap GetMarsImage(Assembly assembly, Stream stream)
        {
            stream = assembly.GetManifestResourceStream("PlanetAPI.mars.jpeg");
            return new Bitmap(stream);
        }

        private Bitmap GetJupiterImage(Assembly assembly, Stream stream)
        {
            stream = assembly.GetManifestResourceStream("PlanetAPI.jupiter.jpeg");
            return new Bitmap(stream);
        }

        private Bitmap GetSaturnImage(Assembly assembly, Stream stream)
        {
            stream = assembly.GetManifestResourceStream("PlanetAPI.saturn.jpeg");
            return new Bitmap(stream);
        }

        private Bitmap GetUranusImage(Assembly assembly, Stream stream)
        {
            stream = assembly.GetManifestResourceStream("PlanetAPI.uranus.jpeg");
            return new Bitmap(stream);
        }

        private Bitmap GetNeptuneImage(Assembly assembly, Stream stream)
        {
            stream = assembly.GetManifestResourceStream("PlanetAPI.neptune.jpeg");
            return new Bitmap(stream);
        }

        private Bitmap GetPlutoImage(Assembly assembly, Stream stream)
        {
            stream = assembly.GetManifestResourceStream("PlanetAPI.pluto.jpeg");
            return new Bitmap(stream);
        }
        #endregion


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