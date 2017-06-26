using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmallPlanets.Models;
using SmallPlanets.Services;

namespace SmallPlanetsTest
{
    [TestClass]
    public class APIConsumerTests
    {
        [TestMethod]
        public void Returns_SolarSystem_From_PlanetAPI()
        {
            APIConsumerService service = new APIConsumerService();
            SolarSystem solarSystem = service.GetSolarSystem();

            Assert.IsNotNull(solarSystem);
        }


    }
}
