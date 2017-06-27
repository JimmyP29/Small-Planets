using SmallPlanets.DAL;
using System.Linq;
using System.Web.Mvc;

namespace SmallPlanets.Controllers
{
    public class LogsController : Controller
    {
        private LogContext db = new LogContext();
        // GET: Logs
        public JsonResult Index()
        {
            return Json(db.LogEntries.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}