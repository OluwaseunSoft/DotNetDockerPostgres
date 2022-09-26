using Microsoft.EntityFrameworkCore;

namespace DotNetDockerPostgres.Data
{
    public class ConversionRateDBContext : DbContext
    {

        public ConversionRateDBContext(DbContextOptions<ConversionRateDBContext> opt) : base(opt)
        {

        }

        public DbSet<Unit> Units { get; set; }
    }
}
