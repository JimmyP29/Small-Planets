using System.Drawing;
using System.IO;
using System.Reflection;

namespace PlanetAPI.Helpers
{
    public class PlanetImage
    {
        public static Bitmap GetPlanetImage(Assembly assembly, Stream stream, string planetName)
        {
            string path = $"PlanetAPI.Images.{planetName.ToLower()}.jpeg";
            stream = assembly.GetManifestResourceStream(path);
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