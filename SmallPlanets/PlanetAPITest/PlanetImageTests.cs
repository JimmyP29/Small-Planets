using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanetAPI.Enums;
using PlanetAPI.Helpers;
using PlanetAPI.Services;
using System;
using System.Drawing;

namespace PlanetAPITest
{
    [TestClass]
    public class PlanetImageTests
    {
        [TestMethod]
        public void Earth_ImageToByteArray_Returns_Byte_Array()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Earth;
            Bitmap image = service.GetImage(type);

            byte[] result = PlanetImage.ImageToByteArray(image);

            Assert.IsNotNull(result);
        }
    }
}
