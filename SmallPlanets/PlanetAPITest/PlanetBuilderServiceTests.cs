using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanetAPI.Enums;
using PlanetAPI.Helpers;
using PlanetAPI.Models;
using PlanetAPI.Services;
using PlanetAPITest.Helpers;
using System;
using System.Drawing;

namespace PlanetAPITest
{
    [TestClass]
    public class PlanetBuilderServiceTests
    {
        #region Mercury
        [TestMethod]
        public void Mercury_GetImage_Returns_Bitmap()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Bitmap result = service.GetImage(PlanetEnum.Mercury);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Mercury_GetDiameter_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Mercury;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Diameter;
            string actualData = service.GetDiameter(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Mercury_GetDistanceFromSun_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Mercury;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).DistanceFromSun;
            string actualData = service.GetDistanceFromSun(PlanetEnum.Mercury);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Mercury_GetMass_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Mercury;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Mass;
            string actualData = service.GetMass(PlanetEnum.Mercury);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Mercury_GetAdditionalInformation_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Mercury;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).AdditionalInformation;
            string actualData = service.GetAdditionalInformation(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Mercury_Create_Returns_Correct_Data()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Mercury;

            Planet correctData = DummyData.GetTestData(type);
            correctData.Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(service.GetImage(type)));

            Planet actualData = service.Create(type);

            Assert.AreEqual(correctData.Name, actualData.Name);
            Assert.AreEqual(correctData.Diameter, actualData.Diameter);
            Assert.AreEqual(correctData.DistanceFromSun, actualData.DistanceFromSun);
            Assert.AreEqual(correctData.Mass, actualData.Mass);
            Assert.AreEqual(correctData.AdditionalInformation, actualData.AdditionalInformation);
            Assert.AreEqual(correctData.Image, actualData.Image);
        }


        #endregion

        #region Venus
        [TestMethod]
        public void Venus_GetImage_Returns_Bitmap()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Bitmap result = service.GetImage(PlanetEnum.Venus);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Venus_GetDiameter_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Venus;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Diameter;
            string actualData = service.GetDiameter(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Venus_GetDistanceFromSun_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Venus;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).DistanceFromSun;
            string actualData = service.GetDistanceFromSun(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Venus_GetMass_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Venus;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Mass;
            string actualData = service.GetMass(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Venus_GetAdditionalInformation_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Venus;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).AdditionalInformation;
            string actualData = service.GetAdditionalInformation(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Venus_Create_Returns_Correct_Data()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Venus;

            Planet correctData = DummyData.GetTestData(type);
            correctData.Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(service.GetImage(type)));

            Planet actualData = service.Create(type);

            Assert.AreEqual(correctData.Name, actualData.Name);
            Assert.AreEqual(correctData.Diameter, actualData.Diameter);
            Assert.AreEqual(correctData.DistanceFromSun, actualData.DistanceFromSun);
            Assert.AreEqual(correctData.Mass, actualData.Mass);
            Assert.AreEqual(correctData.AdditionalInformation, actualData.AdditionalInformation);
            Assert.AreEqual(correctData.Image, actualData.Image);
        }
        #endregion

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
            Enum type = PlanetEnum.Earth;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Diameter;
            string actualData = service.GetDiameter(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Earth_GetDistanceFromSun_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Earth;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).DistanceFromSun;
            string actualData = service.GetDistanceFromSun(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Earth_GetMass_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Earth;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Mass;
            string actualData = service.GetMass(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Earth_GetAdditionalInformation_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Earth;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).AdditionalInformation;
            string actualData = service.GetAdditionalInformation(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Earth_Create_Returns_Correct_Data()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Earth;
  
            Planet correctData = DummyData.GetTestData(type);
            correctData.Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(service.GetImage(type)));

            Planet actualData = service.Create(type);

            Assert.AreEqual(correctData.Name, actualData.Name);
            Assert.AreEqual(correctData.Diameter, actualData.Diameter);
            Assert.AreEqual(correctData.DistanceFromSun, actualData.DistanceFromSun);
            Assert.AreEqual(correctData.Mass, actualData.Mass);
            Assert.AreEqual(correctData.AdditionalInformation, actualData.AdditionalInformation);
            Assert.AreEqual(correctData.Image, actualData.Image);
        }
        #endregion

        #region Mars
        [TestMethod]
        public void Mars_GetImage_Returns_Bitmap()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Bitmap result = service.GetImage(PlanetEnum.Mars);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Mars_GetDiameter_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Mars;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Diameter;
            string actualData = service.GetDiameter(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Mars_GetDistanceFromSun_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Mars;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).DistanceFromSun;
            string actualData = service.GetDistanceFromSun(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Mars_GetMass_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Mars;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Mass;
            string actualData = service.GetMass(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Mars_GetAdditionalInformation_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Mars;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).AdditionalInformation;
            string actualData = service.GetAdditionalInformation(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Mars_Create_Returns_Correct_Data()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Mars;

            Planet correctData = DummyData.GetTestData(type);
            correctData.Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(service.GetImage(type)));

            Planet actualData = service.Create(type);

            Assert.AreEqual(correctData.Name, actualData.Name);
            Assert.AreEqual(correctData.Diameter, actualData.Diameter);
            Assert.AreEqual(correctData.DistanceFromSun, actualData.DistanceFromSun);
            Assert.AreEqual(correctData.Mass, actualData.Mass);
            Assert.AreEqual(correctData.AdditionalInformation, actualData.AdditionalInformation);
            Assert.AreEqual(correctData.Image, actualData.Image);
        }
        #endregion

        #region Jupiter
        [TestMethod]
        public void Jupiter_GetImage_Returns_Bitmap()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Bitmap result = service.GetImage(PlanetEnum.Jupiter);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Jupiter_GetDiameter_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Jupiter;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Diameter;
            string actualData = service.GetDiameter(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Jupiter_GetDistanceFromSun_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Jupiter;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).DistanceFromSun;
            string actualData = service.GetDistanceFromSun(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Jupiter_GetMass_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Jupiter;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Mass;
            string actualData = service.GetMass(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Jupiter_GetAdditionalInformation_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Jupiter;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).AdditionalInformation;
            string actualData = service.GetAdditionalInformation(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Jupiter_Create_Returns_Correct_Data()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Jupiter;

            Planet correctData = DummyData.GetTestData(type);
            correctData.Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(service.GetImage(type)));

            Planet actualData = service.Create(type);

            Assert.AreEqual(correctData.Name, actualData.Name);
            Assert.AreEqual(correctData.Diameter, actualData.Diameter);
            Assert.AreEqual(correctData.DistanceFromSun, actualData.DistanceFromSun);
            Assert.AreEqual(correctData.Mass, actualData.Mass);
            Assert.AreEqual(correctData.AdditionalInformation, actualData.AdditionalInformation);
            Assert.AreEqual(correctData.Image, actualData.Image);
        }
        #endregion

        #region Saturn
        [TestMethod]
        public void Saturn_GetImage_Returns_Bitmap()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Bitmap result = service.GetImage(PlanetEnum.Saturn);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Saturn_GetDiameter_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Saturn;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Diameter;
            string actualData = service.GetDiameter(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Saturn_GetDistanceFromSun_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Saturn;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).DistanceFromSun;
            string actualData = service.GetDistanceFromSun(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Saturn_GetMass_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Saturn;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Mass;
            string actualData = service.GetMass(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Saturn_GetAdditionalInformation_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Saturn;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).AdditionalInformation;
            string actualData = service.GetAdditionalInformation(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Saturn_Create_Returns_Correct_Data()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Saturn;

            Planet correctData = DummyData.GetTestData(type);
            correctData.Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(service.GetImage(type)));

            Planet actualData = service.Create(type);

            Assert.AreEqual(correctData.Name, actualData.Name);
            Assert.AreEqual(correctData.Diameter, actualData.Diameter);
            Assert.AreEqual(correctData.DistanceFromSun, actualData.DistanceFromSun);
            Assert.AreEqual(correctData.Mass, actualData.Mass);
            Assert.AreEqual(correctData.AdditionalInformation, actualData.AdditionalInformation);
            Assert.AreEqual(correctData.Image, actualData.Image);
        }
        #endregion

        #region Uranus
        [TestMethod]
        public void Uranus_GetImage_Returns_Bitmap()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Bitmap result = service.GetImage(PlanetEnum.Uranus);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Uranus_GetDiameter_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Uranus;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Diameter;
            string actualData = service.GetDiameter(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Uranus_GetDistanceFromSun_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Uranus;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).DistanceFromSun;
            string actualData = service.GetDistanceFromSun(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Uranus_GetMass_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Uranus;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Mass;
            string actualData = service.GetMass(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Uranus_GetAdditionalInformation_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Uranus;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).AdditionalInformation;
            string actualData = service.GetAdditionalInformation(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Uranus_Create_Returns_Correct_Data()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Uranus;

            Planet correctData = DummyData.GetTestData(type);
            correctData.Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(service.GetImage(type)));

            Planet actualData = service.Create(type);

            Assert.AreEqual(correctData.Name, actualData.Name);
            Assert.AreEqual(correctData.Diameter, actualData.Diameter);
            Assert.AreEqual(correctData.DistanceFromSun, actualData.DistanceFromSun);
            Assert.AreEqual(correctData.Mass, actualData.Mass);
            Assert.AreEqual(correctData.AdditionalInformation, actualData.AdditionalInformation);
            Assert.AreEqual(correctData.Image, actualData.Image);
        }
        #endregion

        #region Neptune
        [TestMethod]
        public void Neptune_GetImage_Returns_Bitmap()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Bitmap result = service.GetImage(PlanetEnum.Neptune);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Neptune_GetDiameter_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Neptune;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Diameter;
            string actualData = service.GetDiameter(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Neptune_GetDistanceFromSun_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Neptune;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).DistanceFromSun;
            string actualData = service.GetDistanceFromSun(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Neptune_GetMass_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Neptune;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Mass;
            string actualData = service.GetMass(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Neptune_GetAdditionalInformation_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Neptune;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).AdditionalInformation;
            string actualData = service.GetAdditionalInformation(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Neptune_Create_Returns_Correct_Data()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Neptune;

            Planet correctData = DummyData.GetTestData(type);
            correctData.Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(service.GetImage(type)));

            Planet actualData = service.Create(type);

            Assert.AreEqual(correctData.Name, actualData.Name);
            Assert.AreEqual(correctData.Diameter, actualData.Diameter);
            Assert.AreEqual(correctData.DistanceFromSun, actualData.DistanceFromSun);
            Assert.AreEqual(correctData.Mass, actualData.Mass);
            Assert.AreEqual(correctData.AdditionalInformation, actualData.AdditionalInformation);
            Assert.AreEqual(correctData.Image, actualData.Image);
        }
        #endregion

        #region Pluto
        [TestMethod]
        public void Pluto_GetImage_Returns_Bitmap()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Bitmap result = service.GetImage(PlanetEnum.Pluto);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Pluto_GetDiameter_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Pluto;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Diameter;
            string actualData = service.GetDiameter(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Pluto_GetDistanceFromSun_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Pluto;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).DistanceFromSun;
            string actualData = service.GetDistanceFromSun(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Pluto_GetMass_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Pluto;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).Mass;
            string actualData = service.GetMass(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Pluto_GetAdditionalInformation_Returns_Correct_Data()
        {
            Enum type = PlanetEnum.Pluto;
            PlanetBuilderService service = new PlanetBuilderService();
            string correctData = DummyData.GetTestData(type).AdditionalInformation;
            string actualData = service.GetAdditionalInformation(type);

            Assert.AreEqual(correctData, actualData);
        }

        [TestMethod]
        public void Pluto_Create_Returns_Correct_Data()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Enum type = PlanetEnum.Pluto;

            Planet correctData = DummyData.GetTestData(type);
            correctData.Image = Convert.ToBase64String(PlanetImage.ImageToByteArray(service.GetImage(type)));

            Planet actualData = service.Create(type);

            Assert.AreEqual(correctData.Name, actualData.Name);
            Assert.AreEqual(correctData.Diameter, actualData.Diameter);
            Assert.AreEqual(correctData.DistanceFromSun, actualData.DistanceFromSun);
            Assert.AreEqual(correctData.Mass, actualData.Mass);
            Assert.AreEqual(correctData.AdditionalInformation, actualData.AdditionalInformation);
            Assert.AreEqual(correctData.Image, actualData.Image);
        }
        #endregion
    }
}
