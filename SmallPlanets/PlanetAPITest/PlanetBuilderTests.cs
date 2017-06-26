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
            Enum type = PlanetEnum.Earth;
            PlanetBuilderService service = new PlanetBuilderService();
            PlanetBuilder planetBuilder = new PlanetBuilder(service);
            Planet result = service.Create(type);

            Assert.IsNotNull(result);
        }
    }
}
