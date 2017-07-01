using SmallPlanets.DAL;
using SmallPlanets.Models.Entities;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;

namespace SmallPlanets.Controllers
{
    public class LogController : Controller
    {
        private UnitOfWork _unitOfWork;

        public LogController()
        {
            _unitOfWork = new UnitOfWork();
        }

        [HttpGet]
        public JsonResult GetCaptainsLog()
        {
            return Json(_unitOfWork.LogRepository.Get(
                orderBy: q => q.OrderByDescending(l => l.Visited)), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void SaveVisit(Log log)
        {
            try
            {
                if (log != null)
                {
                    _unitOfWork.LogRepository.Insert(log);
                    _unitOfWork.Save();
                }

            }
            catch (DataException)
            {

                ModelState.AddModelError("", "Unable to save changes.");
            }

        }

        [HttpPost]
        public JsonResult ClearLog(List<Log> logEntries)
        {
            if (logEntries != null && logEntries.Count > 0)
            {
                foreach (Log entry in logEntries)
                {
                    _unitOfWork.LogRepository.Delete(entry.ID);
                    
                }
                _unitOfWork.Save();
            }
            return Json(null);
        }
    }
}