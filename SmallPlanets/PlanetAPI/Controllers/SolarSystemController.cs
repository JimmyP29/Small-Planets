using PlanetAPI.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlanetAPI.Controllers
{
    public class SolarSystemController : ApiController
    {
        // GET api/<controller>
        public HttpResponseMessage Get()
        {
             SolarSystem response = new SolarSystem();
            return Request.CreateResponse(HttpStatusCode.OK, response, Configuration.Formatters.JsonFormatter);
        }
    }
}