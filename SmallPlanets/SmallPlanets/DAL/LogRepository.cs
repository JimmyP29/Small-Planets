using SmallPlanets.DAL.Interfaces;
using SmallPlanets.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallPlanets.DAL
{
    public class LogRepository : ILogRepository, IDisposable
    {
        private LogContext _context;
        private bool _disposed;

        public LogRepository(LogContext context)
        {
            _context = context;
            _disposed = false;
        }

        public void DeleteLog(int logId)
        {
            throw new NotImplementedException();
        }

        public Log GetLogByID(int logId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Log> GetLogs()
        {
            return _context.LogEntries.ToList();
        }

        public void InsertLog(Log log)
        {
            _context.LogEntries.Add(log);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateLog(Log log)
        {
            throw new NotImplementedException();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}