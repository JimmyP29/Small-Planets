using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanetAPI.Enums;
using PlanetAPI.Helpers;
using PlanetAPI.Models;
using PlanetAPI.Services;
using System;
using System.Drawing;

namespace PlanetAPITest
{
    [TestClass]
    public class PlanetBuilderServiceTests
    {
        #region Earth
        [TestMethod]
        public void Earth_GetImage_Returns_Bitmap()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Bitmap result = service.GetImage(PlanetEnum.Earth);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Earth_GetDiameter_Returns_Correct_Data()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = GetTestDataForEarth().Diameter;
            string actualData = service.GetDiameter(PlanetEnum.Earth);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Earth_GetDistanceFromSun_Returns_Correct_Data()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = GetTestDataForEarth().DistanceFromSun;
            string actualData = service.GetDistanceFromSun(PlanetEnum.Earth);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Earth_GetMass_Returns_Correct_Data()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = GetTestDataForEarth().Mass;
            string actualData = service.GetMass(PlanetEnum.Earth);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Earth_GetAdditionalInformation_Returns_Correct_Data()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = GetTestDataForEarth().AdditionalInformation;
            string actualData = service.GetAdditionalInformation(PlanetEnum.Earth);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Earth_Create_Returns_Correct_Data()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Earth;
  
            Planet correctData = GetTestDataForEarth();
            correctData.Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(service.GetImage(type)));

            Planet actualData = service.Create(type);

            Assert.AreEqual(correctData.Name, actualData.Name);
            Assert.AreEqual(correctData.Diameter, actualData.Diameter);
            Assert.AreEqual(correctData.DistanceFromSun, actualData.DistanceFromSun);
            Assert.AreEqual(correctData.Mass, actualData.Mass);
            Assert.AreEqual(correctData.AdditionalInformation, actualData.AdditionalInformation);
            Assert.AreEqual(correctData.Image, actualData.Image);
        }

        private Planet GetTestDataForEarth()
        {
            return new Planet
            {
                Name = "Earth",
                Diameter = "12,742 km",
                DistanceFromSun = "149.6 million km",
                Mass = "5.972 × 10^24 kg",
                AdditionalInformation = "Earth is the third planet from the Sun, the densest planet in the Solar System, the largest of the Solar System's four terrestrial planets, and the only astronomical object known to harbor life."
            };
        }
        #endregion
    }
}
