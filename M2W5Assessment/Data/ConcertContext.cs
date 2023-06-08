using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2W5Assessment.Data
{
    public class ConcertContext : DbContext
    {
        public DbSet<Concert> Concerts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=samjoeben3;Database=concert").UseSnakeCaseNamingConvention();
    }
}
