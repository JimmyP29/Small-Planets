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
        public void Index_Loads_SolarSystem_Into_Session()
        {
            ////// Arrange
            ////var mockApiConsumer = new Mock<IAPIConsumer>(MockBehavior.Strict);
            ////var mockSolarSystem = new Mock<ISolarSystem>(MockBehavior.Strict);
            ////SolarSystemController controller = new SolarSystemController(mockApiConsumer.Object, mockSolarSystem.Object);

            ////// Act
            ////ViewResult result = controller.Index() as ViewResult;

            ////// Assert
            ////Assert.IsNotNull(result);
            //// Arrange
            //var mockApiConsumer = new Mock<IAPIConsumer>(MockBehavior.Strict);
            //var mockSolarSystem = new Mock<ISolarSystem>(MockBehavior.Strict);
            //var mockControllerContext = new Mock<ControllerContext>();
            //var mockSession = new Mock<HttpSessionStateBase>();

            //IAPIConsumer apiConsumer = new APIConsumerService();
            //ISolarSystem service = new SolarSystemService(apiConsumer);

            //mockSession.SetupGet(s => s["SolarSystem"]).Returns(new SolarSystem(service));
            //mockControllerContext.Setup(p => p.HttpContext.Session).Returns(mockSession.Object);
            //SolarSystemController controller = new SolarSystemController(apiConsumer, service);
            //controller.ControllerContext = mockControllerContext.Object;
            //controller.Index();

            ////mockSession.SetupGet(s => s["SolarSystem"]).Returns(new SolarSystem(mockSolarSystem.Object));
            ////mockControllerContext.Setup(p => p.HttpContext.Session).Returns(mockSession.Object);
            ////SolarSystemController controller = new SolarSystemController(mockApiConsumer.Object, mockSolarSystem.Object);
            ////controller.ControllerContext = mockControllerContext.Object;

            //// Act
            //// ViewResult result = controller.Index() as ViewResult;

            //// Assert
            ////Assert.IsNotNull(controller.ControllerContext);
            ////  SolarSystem correct = new SolarSystem(mockSolarSystem.Object);
            //SolarSystem correct = new SolarSystem(service);
            ////correct.CreateSolarSystem();
            //SolarSystem actual = (SolarSystem)controller.Session["SolarSystem"];
            //Assert.AreEqual(correct.Planets.Count, actual.Planets.Count);
            Mock<IAPIConsumer> mockApiConsumer = new Mock<IAPIConsumer>();
            Mock<ISolarSystem> mockSolarSystem = new Mock<ISolarSystem>();

            SolarSystemController controller = new SolarSystemController(mockApiConsumer.Object, mockSolarSystem.Object);
            controller.ControllerContext = SetupSessionWithReturnValue(null).Object;
            controller.Index();

            SolarSystem correct = new SolarSystem(mockSolarSystem.Object);
            correct.CreateSolarSystem();

            SolarSystem actual = (SolarSystem)controller.Session["SolarSystem"];
            Assert.AreEqual(correct.Planets.Count, actual.Planets.Count);
        }

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
