using PlanetAPI.Interfaces;
using PlanetAPI.Models;
using PlanetAPI.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlanetAPI.Controllers
{
    public class SolarSystemController : ApiController
    {
        private readonly IPlanetBuilder _planetBuilder;

        public SolarSystemController()
        {
            _planetBuilder = new PlanetBuilderService();
        }

        // GET api/<controller>
        public HttpResponseMessage Get()
        {
            SolarSystem response = new SolarSystem(_planetBuilder);
            return Request.CreateResponse(HttpStatusCode.OK, response, Configuration.Formatters.JsonFormatter);
        }
    }
}