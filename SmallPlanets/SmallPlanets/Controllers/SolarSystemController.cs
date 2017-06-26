using SmallPlanets.Interfaces;
using SmallPlanets.Models;
using SmallPlanets.Models.ViewModels;
using System.Web.Mvc;

namespace SmallPlanets.Controllers
{
    public class SolarSystemController : Controller
    {
        private readonly IAPIConsumer _apiConsumer;
        private readonly ISolarSystem _solarSystem;
        

        public SolarSystemController(IAPIConsumer apiConsumer, ISolarSystem solarSystem)
        {
            //IAPIConsumer apiConsumer = new APIConsumerService();
            // _solarSystem = new SolarSystemService(apiConsumer);
            _apiConsumer = apiConsumer;
            _solarSystem = solarSystem;

        }

        // GET: SolarSystem
        public ActionResult Index()
        {
            Session["SolarSystem"] = LoadSolarSystemData();
            return View();
        }

        [HttpPost]
        public JsonResult LoadPlanet(string planetName)
        {
            SolarSystem solarSystem = LoadSolarSystemData();
            Planet planet = solarSystem.GetPlanetFromSolarSystem(planetName);
            return Json(planet);
        }

        public SolarSystem LoadSolarSystemData()
        {
            SolarSystem solarSystem;

            if (Session["SolarSystem"] == null)
            {
                solarSystem = new SolarSystem(_solarSystem);
                solarSystem.CreateSolarSystem();
            }
            else
            {
                solarSystem = (SolarSystem)Session["SolarSystem"];
            }
            return solarSystem;
        }
    }
}