using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanetAPI.Controllers;
using System.Net.Http;
using System.Web.Http;

namespace PlanetAPITest
{
    [TestClass]
    public class SolarSystemControllerTests
    {
        [TestMethod]
        public void Get_Returns_HttpResponseMessage()
        {
            SolarSystemController controller = SetupController();
            HttpResponseMessage result = controller.Get();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Get_Returns_Successful_Status_Code()
        {
            SolarSystemController controller = SetupController();
            HttpResponseMessage result = controller.Get();

            Assert.AreEqual(result.IsSuccessStatusCode, true);
        }

        private SolarSystemController SetupController()
        {
            SolarSystemController controller = new SolarSystemController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            return controller;
        }
    }
}
