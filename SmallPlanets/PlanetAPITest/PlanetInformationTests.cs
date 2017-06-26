using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanetAPI.Enums;
using PlanetAPI.Helpers;
using System;

namespace PlanetAPITest
{
    [TestClass]
    public class PlanetInformationTests
    {
        [TestMethod]
        public void Earth_GetDiameter_Returns_Data()
        {
            Enum type = PlanetEnum.Earth;
            Assert.IsNotNull(PlanetInformation.GetDiameter(type));
        }

        [TestMethod]
        public void Earth_GetDistanceFromSun_Returns_Data()
        {
            Enum type = PlanetEnum.Earth;
            Assert.IsNotNull(PlanetInformation.GetDistanceFromSun(type));
        }

        [TestMethod]
        public void Earth_GetMass_Returns_Data()
        {
            Enum type = PlanetEnum.Earth;
            Assert.IsNotNull(PlanetInformation.GetMass(type));
        }

        [TestMethod]
        public void Earth_GetAdditionalInformation_Returns_Data()
        {
            Enum type = PlanetEnum.Earth;
            Assert.IsNotNull(PlanetInformation.GetAdditionalInformation(type));
        }
    }
}
