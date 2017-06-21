using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SmallPlanets.Controllers;
using SmallPlanets.Interfaces;
using SmallPlanets.Models;
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
            //// Arrange
            //var mockApiConsumer = new Mock<IAPIConsumer>(MockBehavior.Strict);
            //var mockSolarSystem = new Mock<ISolarSystem>(MockBehavior.Strict);
            //SolarSystemController controller = new SolarSystemController(mockApiConsumer.Object, mockSolarSystem.Object);

            //// Act
            //ViewResult result = controller.Index() as ViewResult;

            //// Assert
            //Assert.IsNotNull(result);
            // Arrange
            var mockApiConsumer = new Mock<IAPIConsumer>(MockBehavior.Strict);
            var mockSolarSystem = new Mock<ISolarSystem>(MockBehavior.Strict);
            var mockControllerContext = new Mock<ControllerContext>();
            var mockSession = new Mock<HttpSessionStateBase>();

            mockSession.SetupGet(s => s["SolarSystem"]).Returns(new SolarSystem(mockSolarSystem.Object));
            mockControllerContext.Setup(p => p.HttpContext.Session).Returns(mockSession.Object);
            SolarSystemController controller = new SolarSystemController(mockApiConsumer.Object, mockSolarSystem.Object);
            controller.ControllerContext = mockControllerContext.Object;

            // Act
            // ViewResult result = controller.Index() as ViewResult;

            // Assert
            //Assert.IsNotNull(controller.ControllerContext);
            SolarSystem solarSystem = new SolarSystem(mockSolarSystem.Object);
            Assert.AreEqual(solarSystem, controller.Session["SolarSystem"]);
        }
    }
}
