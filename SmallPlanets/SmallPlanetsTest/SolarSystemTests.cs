using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SmallPlanets.Interfaces;
using SmallPlanets.Models;
using SmallPlanets.Services;

namespace SmallPlanetsTest
{
    [TestClass]
    public class SolarSystemTests
    {
        [TestMethod]
        public void Creates_SolarSystem()
        {
            //var mockSolarSystem = new Mock<ISolarSystem>(MockBehavior.Strict);
            var mockSolarSystem = new Mock<ISolarSystem>();
            IAPIConsumer apiConsumer = new APIConsumerService();
            ISolarSystem service = new SolarSystemService();
            SolarSystem solarSystem = new SolarSystem(service);
            //SolarSystem solarSystem = new SolarSystem(mockSolarSystem.Object);
            solarSystem.CreateSolarSystem(apiConsumer);

            Assert.AreEqual(9, solarSystem.Planets.Count);
        }
    }
}
