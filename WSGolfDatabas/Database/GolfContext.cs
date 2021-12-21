using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSGolfDatabas.Models;

namespace WSGolfDatabas.Database
{
    public class GolfContext : DbContext
    {
        private const string DatabaseName = "GolfDatabas";
        public DbSet<CourseTable> Courses { get; set; }
        public DbSet<WeatherTable> Weathers { get; set; }
        public DbSet<ScoreTable> Scores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                $@"Server=(localdb)\mssqllocaldb;Database={DatabaseName};Trusted_Connection=True;");
        }
    }
}
