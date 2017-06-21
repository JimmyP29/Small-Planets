using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SmallPlanets.Controllers;
using SmallPlanets.Interfaces;
using System.Web.Mvc;

namespace SmallPlanetsTest
{
    [TestClass]
    public class SolarSystemControllerTests
    {
        [TestMethod]
        public void Index_Loads_SolarSystem_Into_Session()
        {
            // Arrange
            var mockApiConsumer = new Mock<IAPIConsumer>(MockBehavior.Strict);
            var mockSolarSystem = new Mock<ISolarSystem>(MockBehavior.Strict);
            SolarSystemController controller = new SolarSystemController(mockApiConsumer.Object, mockSolarSystem.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
