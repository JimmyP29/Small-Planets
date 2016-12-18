using SmallPlanets.Interfaces;
using SmallPlanets.Models;
using SmallPlanets.Models.ViewModels;
using SmallPlanets.Services;
using System.Web.Mvc;

namespace SmallPlanets.Controllers
{
    public class SolarSystemController : Controller
    {
        private readonly ISolarSystem _solarSystem;
        

        public SolarSystemController()
        {
            IAPIConsumer apiConsumer = new APIConsumerService();
            _solarSystem = new SolarSystemService(apiConsumer);
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
           // planetName = "Saturn";
            SolarSystem solarSystem = LoadSolarSystemData();
            Planet planet = solarSystem.GetPlanetFromSolarSystem(planetName);
            return Json(planet);
        }

        private SolarSystem LoadSolarSystemData()
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