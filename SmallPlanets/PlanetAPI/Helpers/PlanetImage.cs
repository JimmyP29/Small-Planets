using System;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace PlanetAPI.Helpers
{
    public class PlanetImage
    {
        public static Bitmap GetPlanetImage(Enum planetName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string path = $"PlanetAPI.Images.{planetName.ToString().ToLower()}.jpeg";
            Stream stream = assembly.GetManifestResourceStream(path);
            return new Bitmap(stream);
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}