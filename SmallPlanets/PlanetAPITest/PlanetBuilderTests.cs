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
        public void Mercury_Create_Builds_Planet()
        {
            Enum type = PlanetEnum.Mercury;
            PlanetBuilderService service = new PlanetBuilderService();
            PlanetBuilder planetBuilder = new PlanetBuilder(service);
            Planet result = service.Create(type);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Venus_Create_Builds_Planet()
        {
            Enum type = PlanetEnum.Venus;
            PlanetBuilderService service = new PlanetBuilderService();
            PlanetBuilder planetBuilder = new PlanetBuilder(service);
            Planet result = service.Create(type);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Earth_Create_Builds_Planet()
        {
            Enum type = PlanetEnum.Earth;
            PlanetBuilderService service = new PlanetBuilderService();
            PlanetBuilder planetBuilder = new PlanetBuilder(service);
            Planet result = service.Create(type);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Mars_Create_Builds_Planet()
        {
            Enum type = PlanetEnum.Mars;
            PlanetBuilderService service = new PlanetBuilderService();
            PlanetBuilder planetBuilder = new PlanetBuilder(service);
            Planet result = service.Create(type);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Jupiter_Create_Builds_Planet()
        {
            Enum type = PlanetEnum.Jupiter;
            PlanetBuilderService service = new PlanetBuilderService();
            PlanetBuilder planetBuilder = new PlanetBuilder(service);
            Planet result = service.Create(type);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Saturn_Create_Builds_Planet()
        {
            Enum type = PlanetEnum.Saturn;
            PlanetBuilderService service = new PlanetBuilderService();
            PlanetBuilder planetBuilder = new PlanetBuilder(service);
            Planet result = service.Create(type);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Uranus_Create_Builds_Planet()
        {
            Enum type = PlanetEnum.Uranus;
            PlanetBuilderService service = new PlanetBuilderService();
            PlanetBuilder planetBuilder = new PlanetBuilder(service);
            Planet result = service.Create(type);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Neptune_Create_Builds_Planet()
        {
            Enum type = PlanetEnum.Neptune;
            PlanetBuilderService service = new PlanetBuilderService();
            PlanetBuilder planetBuilder = new PlanetBuilder(service);
            Planet result = service.Create(type);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Pluto_Create_Builds_Planet()
        {
            Enum type = PlanetEnum.Pluto;
            PlanetBuilderService service = new PlanetBuilderService();
            PlanetBuilder planetBuilder = new PlanetBuilder(service);
            Planet result = service.Create(type);

            Assert.IsNotNull(result);
        }
    }
}
