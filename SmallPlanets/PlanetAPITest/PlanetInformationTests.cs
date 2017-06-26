using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanetAPI.Enums;
using PlanetAPI.Helpers;
using System;

namespace PlanetAPITest
{
    [TestClass]
    public class PlanetInformationTests
    {
        #region Mercury
        [TestMethod]
        public void Mercury_GetDiameter_Returns_Data()
        {
            Enum type = PlanetEnum.Mercury;
            Assert.IsNotNull(PlanetInformation.GetDiameter(type));
        }

        [TestMethod]
        public void Mercury_GetDistanceFromSun_Returns_Data()
        {
            Enum type = PlanetEnum.Mercury;
            Assert.IsNotNull(PlanetInformation.GetDistanceFromSun(type));
        }

        [TestMethod]
        public void Mercury_GetMass_Returns_Data()
        {
            Enum type = PlanetEnum.Mercury;
            Assert.IsNotNull(PlanetInformation.GetMass(type));
        }

        [TestMethod]
        public void Mercury_GetAdditionalInformation_Returns_Data()
        {
            Enum type = PlanetEnum.Mercury;
            Assert.IsNotNull(PlanetInformation.GetAdditionalInformation(type));
        }
        #endregion

        #region Venus
        [TestMethod]
        public void Venus_GetDiameter_Returns_Data()
        {
            Enum type = PlanetEnum.Venus;
            Assert.IsNotNull(PlanetInformation.GetDiameter(type));
        }

        [TestMethod]
        public void Venus_GetDistanceFromSun_Returns_Data()
        {
            Enum type = PlanetEnum.Venus;
            Assert.IsNotNull(PlanetInformation.GetDistanceFromSun(type));
        }

        [TestMethod]
        public void Venus_GetMass_Returns_Data()
        {
            Enum type = PlanetEnum.Venus;
            Assert.IsNotNull(PlanetInformation.GetMass(type));
        }

        [TestMethod]
        public void Venus_GetAdditionalInformation_Returns_Data()
        {
            Enum type = PlanetEnum.Venus;
            Assert.IsNotNull(PlanetInformation.GetAdditionalInformation(type));
        }
        #endregion

        #region Earth
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
        #endregion

        #region Mars
        [TestMethod]
        public void Mars_GetDiameter_Returns_Data()
        {
            Enum type = PlanetEnum.Mars;
            Assert.IsNotNull(PlanetInformation.GetDiameter(type));
        }

        [TestMethod]
        public void Mars_GetDistanceFromSun_Returns_Data()
        {
            Enum type = PlanetEnum.Mars;
            Assert.IsNotNull(PlanetInformation.GetDistanceFromSun(type));
        }

        [TestMethod]
        public void Mars_GetMass_Returns_Data()
        {
            Enum type = PlanetEnum.Mars;
            Assert.IsNotNull(PlanetInformation.GetMass(type));
        }

        [TestMethod]
        public void Mars_GetAdditionalInformation_Returns_Data()
        {
            Enum type = PlanetEnum.Mars;
            Assert.IsNotNull(PlanetInformation.GetAdditionalInformation(type));
        }
        #endregion

        #region Jupiter
        [TestMethod]
        public void Jupiter_GetDiameter_Returns_Data()
        {
            Enum type = PlanetEnum.Jupiter;
            Assert.IsNotNull(PlanetInformation.GetDiameter(type));
        }

        [TestMethod]
        public void Jupiter_GetDistanceFromSun_Returns_Data()
        {
            Enum type = PlanetEnum.Jupiter;
            Assert.IsNotNull(PlanetInformation.GetDistanceFromSun(type));
        }

        [TestMethod]
        public void Jupiter_GetMass_Returns_Data()
        {
            Enum type = PlanetEnum.Jupiter;
            Assert.IsNotNull(PlanetInformation.GetMass(type));
        }

        [TestMethod]
        public void Jupiter_GetAdditionalInformation_Returns_Data()
        {
            Enum type = PlanetEnum.Jupiter;
            Assert.IsNotNull(PlanetInformation.GetAdditionalInformation(type));
        }
        #endregion

        #region Saturn
        [TestMethod]
        public void Saturn_GetDiameter_Returns_Data()
        {
            Enum type = PlanetEnum.Saturn;
            Assert.IsNotNull(PlanetInformation.GetDiameter(type));
        }

        [TestMethod]
        public void Saturn_GetDistanceFromSun_Returns_Data()
        {
            Enum type = PlanetEnum.Saturn;
            Assert.IsNotNull(PlanetInformation.GetDistanceFromSun(type));
        }

        [TestMethod]
        public void Saturn_GetMass_Returns_Data()
        {
            Enum type = PlanetEnum.Saturn;
            Assert.IsNotNull(PlanetInformation.GetMass(type));
        }

        [TestMethod]
        public void Saturn_GetAdditionalInformation_Returns_Data()
        {
            Enum type = PlanetEnum.Saturn;
            Assert.IsNotNull(PlanetInformation.GetAdditionalInformation(type));
        }
        #endregion

        #region Uranus
        [TestMethod]
        public void Uranus_GetDiameter_Returns_Data()
        {
            Enum type = PlanetEnum.Uranus;
            Assert.IsNotNull(PlanetInformation.GetDiameter(type));
        }

        [TestMethod]
        public void Uranus_GetDistanceFromSun_Returns_Data()
        {
            Enum type = PlanetEnum.Uranus;
            Assert.IsNotNull(PlanetInformation.GetDistanceFromSun(type));
        }

        [TestMethod]
        public void Uranus_GetMass_Returns_Data()
        {
            Enum type = PlanetEnum.Uranus;
            Assert.IsNotNull(PlanetInformation.GetMass(type));
        }

        [TestMethod]
        public void Uranus_GetAdditionalInformation_Returns_Data()
        {
            Enum type = PlanetEnum.Uranus;
            Assert.IsNotNull(PlanetInformation.GetAdditionalInformation(type));
        }
        #endregion

        #region Neptune
        [TestMethod]
        public void Neptune_GetDiameter_Returns_Data()
        {
            Enum type = PlanetEnum.Neptune;
            Assert.IsNotNull(PlanetInformation.GetDiameter(type));
        }

        [TestMethod]
        public void Neptune_GetDistanceFromSun_Returns_Data()
        {
            Enum type = PlanetEnum.Neptune;
            Assert.IsNotNull(PlanetInformation.GetDistanceFromSun(type));
        }

        [TestMethod]
        public void Neptune_GetMass_Returns_Data()
        {
            Enum type = PlanetEnum.Neptune;
            Assert.IsNotNull(PlanetInformation.GetMass(type));
        }

        [TestMethod]
        public void Neptune_GetAdditionalInformation_Returns_Data()
        {
            Enum type = PlanetEnum.Neptune;
            Assert.IsNotNull(PlanetInformation.GetAdditionalInformation(type));
        }
        #endregion

        #region Pluto
        [TestMethod]
        public void Pluto_GetDiameter_Returns_Data()
        {
            Enum type = PlanetEnum.Pluto;
            Assert.IsNotNull(PlanetInformation.GetDiameter(type));
        }

        [TestMethod]
        public void Pluto_GetDistanceFromSun_Returns_Data()
        {
            Enum type = PlanetEnum.Pluto;
            Assert.IsNotNull(PlanetInformation.GetDistanceFromSun(type));
        }

        [TestMethod]
        public void Pluto_GetMass_Returns_Data()
        {
            Enum type = PlanetEnum.Pluto;
            Assert.IsNotNull(PlanetInformation.GetMass(type));
        }

        [TestMethod]
        public void Pluto_GetAdditionalInformation_Returns_Data()
        {
            Enum type = PlanetEnum.Pluto;
            Assert.IsNotNull(PlanetInformation.GetAdditionalInformation(type));
        }
        #endregion
    }
}
