using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanetAPI.Enums;
using PlanetAPI.Helpers;
using PlanetAPI.Models;
using PlanetAPI.Services;
using System;

namespace PlanetAPITest
{
    [TestClass]
    public class PlanetBuilderTests
    {
        [TestMethod]
        public void Earth_Create_Builds_Planet()
        {
           // Mock<IPlanetBuilder> mockPlanetBuilder = new Mock<IPlanetBuilder>();
            PlanetBuilderService service = new PlanetBuilderService();
            PlanetBuilder planetBuilder = new PlanetBuilder(service);
            Enum type = PlanetEnum.Earth;
            Planet result = planetBuilder.Create(type);
            //mockPlanetBuilder.Verify(mock => mock.Create(type), Times.Once);
            //planetBuilder.Create(type);

            Assert.IsNotNull(result);
        }
    }
}
