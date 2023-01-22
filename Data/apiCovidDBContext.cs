using apiCOVID.Models;
using Microsoft.EntityFrameworkCore;

namespace apiCOVID.Data
{
    public class apiCovidDBContext : DbContext
    {
        public apiCovidDBContext(DbContextOptions<apiCovidDBContext> options) : base(options)
        {

        }

        public DbSet<CovidModel> CovidDados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          base.OnModelCreating(modelBuilder);      
        }
    }
}
