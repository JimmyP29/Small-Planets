using SmallPlanets.Models.Entities;
using System;
using System.Collections.Generic;

namespace SmallPlanets.DAL.Interfaces
{
    public interface ILogRepository : IDisposable
    {
        IEnumerable<Log> GetLogs();
        Log GetLogByID(int logId);
        void InsertLog(Log log);
        void DeleteLog(int logId);
        void UpdateLog(Log log);
        void Save();
    }
}
