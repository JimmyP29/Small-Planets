using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanetAPI.Enums;
using PlanetAPI.Services;
using System.Drawing;

namespace PlanetAPITest
{
    [TestClass]
    public class PlanetBuilderServiceTests
    {
        [TestMethod]
        public void GetImage_Returns_Bitmap_Earth()
        {
            PlanetBuilderService service = new PlanetBuilderService();
            Bitmap result = service.GetImage(PlanetEnum.Earth);

            Assert.IsNotNull(result);
        }
    }
}
