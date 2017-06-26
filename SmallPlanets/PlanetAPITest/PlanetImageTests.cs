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
        public void Mercury_ImageToByteArray_Returns_Byte_Array()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Mercury;
            Bitmap image = service.GetImage(type);

            byte[] result = PlanetImage.ImageToByteArray(image);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Venus_ImageToByteArray_Returns_Byte_Array()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Venus;
            Bitmap image = service.GetImage(type);

            byte[] result = PlanetImage.ImageToByteArray(image);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Earth_ImageToByteArray_Returns_Byte_Array()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Earth;
            Bitmap image = service.GetImage(type);

            byte[] result = PlanetImage.ImageToByteArray(image);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Mars_ImageToByteArray_Returns_Byte_Array()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Mars;
            Bitmap image = service.GetImage(type);

            byte[] result = PlanetImage.ImageToByteArray(image);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Jupiter_ImageToByteArray_Returns_Byte_Array()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Jupiter;
            Bitmap image = service.GetImage(type);

            byte[] result = PlanetImage.ImageToByteArray(image);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Saturn_ImageToByteArray_Returns_Byte_Array()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Saturn;
            Bitmap image = service.GetImage(type);

            byte[] result = PlanetImage.ImageToByteArray(image);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Uranus_ImageToByteArray_Returns_Byte_Array()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Uranus;
            Bitmap image = service.GetImage(type);

            byte[] result = PlanetImage.ImageToByteArray(image);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Neptune_ImageToByteArray_Returns_Byte_Array()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Neptune;
            Bitmap image = service.GetImage(type);

            byte[] result = PlanetImage.ImageToByteArray(image);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Pluto_ImageToByteArray_Returns_Byte_Array()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Pluto;
            Bitmap image = service.GetImage(type);

            byte[] result = PlanetImage.ImageToByteArray(image);

            Assert.IsNotNull(result);
        }
    }
}
