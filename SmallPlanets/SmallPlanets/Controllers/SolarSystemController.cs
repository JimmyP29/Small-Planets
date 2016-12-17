using SmallPlanets.Interfaces;
using SmallPlanets.Models;
using SmallPlanets.Services;
using System.Web.Mvc;

namespace SmallPlanets.Controllers
{
    public class SolarSystemController : Controller
    {
        private readonly ISolarSystem _solarSystem;

        public SolarSystemController()
        {
            _solarSystem = new SolarSystemService();
        }

        // GET: SolarSystem
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public bool LoadSolarSystemData()

        {
            SolarSystem solarSystem = new SolarSystem(_solarSystem);
            solarSystem.CreateSolarSystem();
            return true;
        }
    }
}