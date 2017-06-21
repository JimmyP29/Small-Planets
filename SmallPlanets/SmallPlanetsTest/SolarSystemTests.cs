using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SmallPlanets.Interfaces;
using SmallPlanets.Models;

namespace SmallPlanetsTest
{
    [TestClass]
    public class SolarSystemTests
    {
        [TestMethod]
        public void Creates_SolarSystem()
        {
            var mockSolarSystem = new Mock<ISolarSystem>(MockBehavior.Strict);
            SolarSystem solarSystem = new SolarSystem(mockSolarSystem.Object);
            solarSystem.CreateSolarSystem();

            Assert.AreEqual(9, solarSystem.Planets.Count);
        }
    }
}
