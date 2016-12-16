using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmallPlanets.Controllers
{
    public class SolarSystemController : Controller
    {
        // GET: SolarSystem
        public ActionResult Index()
        {
            return View();
        }
    }
}