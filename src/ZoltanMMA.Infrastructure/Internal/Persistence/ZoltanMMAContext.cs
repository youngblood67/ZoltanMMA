using Microsoft.EntityFrameworkCore;
using ZoltanMMA.Infrastructure.Internal.Persistence.Models;

namespace ZoltanMMA.Infrastructure.Internal.Persistence
{
    public class ZoltanMMAContext : DbContext
    {
        public ZoltanMMAContext(DbContextOptions<ZoltanMMAContext> options) : base(options)
        {
            
        }

        public DbSet<FighterEf> Fighters => Set<FighterEf>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ZoltanMMAContext).Assembly);
        }
    }
}
