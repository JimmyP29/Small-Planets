using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SmallPlanets.Controllers;
using SmallPlanets.Interfaces;
using SmallPlanets.Models;
using SmallPlanets.Models.ViewModels;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace SmallPlanetsTest
{
    [TestClass]
    public class SolarSystemControllerTests
    {
        [TestMethod]
        public void LoadPlanet_Returns_Valid_JSON()
        {
            string planetName = "Earth";
            Mock<IAPIConsumer> mockApiConsumer = new Mock<IAPIConsumer>();
            Mock<ISolarSystem> mockSolarSystem = new Mock<ISolarSystem>();

            SolarSystemController controller = new SolarSystemController(mockApiConsumer.Object, mockSolarSystem.Object);
            controller.ControllerContext = SetupSessionWithReturnValue(SetUpDummyData(mockSolarSystem.Object)).Object;
            controller.Index();
            JsonResult result = controller.LoadPlanet(planetName);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LoadSolarSystemData_Returns_SolarSystem_When_Null_In_Session()
        {
            Mock<IAPIConsumer> mockApiConsumer = new Mock<IAPIConsumer>();
            Mock<ISolarSystem> mockSolarSystem = new Mock<ISolarSystem>();

            SolarSystemController controller = new SolarSystemController(mockApiConsumer.Object, mockSolarSystem.Object);
            controller.ControllerContext = SetupSessionWithReturnValue(null).Object;
            SolarSystem result = controller.LoadSolarSystemData();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LoadSolarSystemData_Returns_SolarSystem_When_SolarSystem_In_Session()
        {
            Mock<IAPIConsumer> mockApiConsumer = new Mock<IAPIConsumer>();
            Mock<ISolarSystem> mockSolarSystem = new Mock<ISolarSystem>();

            SolarSystemController controller = new SolarSystemController(mockApiConsumer.Object, mockSolarSystem.Object);
            controller.ControllerContext = SetupSessionWithReturnValue(SetUpDummyData(mockSolarSystem.Object)).Object;
            SolarSystem result = controller.LoadSolarSystemData();

            Assert.IsNotNull(result);
        }

        private SolarSystem SetUpDummyData(ISolarSystem solarSystemDependency)
        {
            return new SolarSystem(solarSystemDependency)
            {
                Planets = new List<Planet>()
                {
                    new Planet(),
                    new Planet(),
                    new Planet(),
                    new Planet(),
                    new Planet(),
                    new Planet(),
                    new Planet(),
                    new Planet(),
                    new Planet()
                }
            };
        }

        private Mock<ControllerContext> SetupSessionWithReturnValue(SolarSystem returnValue)
        {
            var mockControllerContext = new Mock<ControllerContext>();
            var mockSession = new Mock<HttpSessionStateBase>();
            mockSession.SetupGet(s => s["SolarSystem"]).Returns(returnValue);
            mockControllerContext.Setup(p => p.HttpContext.Session).Returns(mockSession.Object);

            return mockControllerContext;
        }
    }
}
