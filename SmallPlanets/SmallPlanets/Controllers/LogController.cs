using SmallPlanets.DAL;
using SmallPlanets.DAL.Interfaces;
using SmallPlanets.Models.Entities;
using System.Web.Mvc;

namespace SmallPlanets.Controllers
{
    public class LogController : Controller
    {
        // private LogContext db = new LogContext();
        //private ILogRepository _logRepository;
        private UnitOfWork _unitOfWork;

        public LogController(ILogRepository logRepository)
        {
            //_logRepository = logRepository;
            _unitOfWork = new UnitOfWork();
        }
        // GET: Logs
        public JsonResult Index()
        {
            //return Json(_logRepository.GetLogs(), JsonRequestBehavior.AllowGet);
            return Json(_unitOfWork.LogRepository.Get(), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetCaptainsLog()
        {
            //return Json(_logRepository.GetLogs(), JsonRequestBehavior.AllowGet);
            return Json(_unitOfWork.LogRepository.Get(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SaveVisit(Log log)
        {
            if (log != null)
            {
                _unitOfWork.LogRepository.Insert(log);
                _unitOfWork.Save();
            }

            return RedirectToAction("Index", "SolarSystem");
        }
    }
}