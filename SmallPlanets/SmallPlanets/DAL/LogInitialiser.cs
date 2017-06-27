using SmallPlanets.Models.Entities;
using System;
using System.Collections.Generic;

namespace SmallPlanets.DAL
{
    public class LogInitialiser : System.Data.Entity. DropCreateDatabaseIfModelChanges<LogContext>
    {
        protected override void Seed(LogContext context)
        {
            // base.Seed(context);
            List<Log> entries = new List<Log>
            {
                new Log { PlanetName = "Earth", PlanetImage = "TESTING", Visited = DateTime.Now },
                new Log { PlanetName = "Mars", PlanetImage = "TESTING", Visited = DateTime.Now.AddDays(-1) },
                new Log { PlanetName = "Pluto", PlanetImage = "TESTING", Visited = DateTime.Now.AddDays(-7) }
            };

            entries.ForEach(e => context.LogEntries.Add(e));
            context.SaveChanges();
        }
    }
}