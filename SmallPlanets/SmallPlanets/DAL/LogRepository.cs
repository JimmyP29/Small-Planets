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

        public IEnumerable<Log> GetLogs()
        {
            return _context.LogEntries.ToList();
        }

        public Log GetLogByID(int logId)
        {
            return _context.LogEntries.Find(logId);
        }

        public void InsertLog(Log log)
        {
            _context.LogEntries.Add(log);
        }

        public void DeleteLog(int logId)
        {
            Log log = _context.LogEntries.Find(logId);
            _context.LogEntries.Remove(log);
        }

        public void UpdateLog(Log log)
        {
            _context.Entry(log).State = System.Data.Entity.EntityState.Modified; 
        }

        public void Save()
        {
            _context.SaveChanges();
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