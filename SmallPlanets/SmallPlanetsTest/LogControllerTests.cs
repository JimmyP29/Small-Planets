using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmallPlanets.Controllers;
using SmallPlanets.Models.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SmallPlanetsTest
{
    [TestClass]
    public class LogControllerTests
    {

        [TestMethod]
        public void GetCaptainsLog_Returns_JsonResult()
        {
            LogController controller = new LogController();
            JsonResult result = GetCaptainsLog(controller);

            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void SaveVisit_Saves_Log_Object()
        {
            Log testLog = SetupDummyLog();
            LogController controller = new LogController();
            controller.SaveVisit(testLog);

            JsonResult result = GetCaptainsLog(controller);
            List<Log> data = (List<Log>)result.Data;
        
            Assert.IsNotNull(data.IndexOf(testLog));
        }

        [TestMethod]
        public void ClearLog_Clears_All_Log_Objects()
        {
            SaveVisit_Saves_Log_Object();
            LogController controller = new LogController();
            JsonResult json = GetCaptainsLog(controller) as JsonResult;
            List<Log> data = (List<Log>)json.Data;

            json = controller.ClearLog(data);

            Assert.IsNull(json.Data);
        }

        private JsonResult GetCaptainsLog(LogController controller)
        {
            return controller.GetCaptainsLog();
        }

        private Log SetupDummyLog()
        {
            return new Log
            {
                PlanetName = "Earth",
                PlanetImage = "TESTING",
                Visited = "2017-03-29 22:30:00"
            };
        }
    }

    public class Result
    {
        public bool success;
        public string error;
    }
}
