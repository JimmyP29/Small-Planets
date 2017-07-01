using SmallPlanets.Models.Entities;
using System.Data.Entity;

namespace SmallPlanets.DAL
{
    public class LogContext : DbContext
    {
        public LogContext() : base("LogContext")
        {
            var ensureDLLIsCopied =
               System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<Log> LogEntries { get; set; }
    }
}