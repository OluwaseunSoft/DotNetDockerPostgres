using Microsoft.EntityFrameworkCore;

namespace DotNetDockerPostgres.Data
{
    public class ConversionRateDBContext : DbContext
    {
        private readonly IConfiguration _config;

        public ConversionRateDBContext(IConfiguration configuration)
        {
            _config = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_config.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Unit> Units { get; set; }
    }
}
