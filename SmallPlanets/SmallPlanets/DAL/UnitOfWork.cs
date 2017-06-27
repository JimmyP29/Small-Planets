using SmallPlanets.Models.Entities;
using System;

namespace SmallPlanets.DAL
{
    public class UnitOfWork : IDisposable
    {
        private LogContext _context;
        private GenericRepository<Log> _logRepository;
        private bool _disposed;

        public UnitOfWork()
        {
            _context = new LogContext();
            _disposed = false;
        }

        public GenericRepository<Log> LogRepository
        {
            get
            {
                if (_logRepository == null)
                {
                    _logRepository = new GenericRepository<Log>(_context);
                }
                return _logRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
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