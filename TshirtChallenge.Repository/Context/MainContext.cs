using Microsoft.EntityFrameworkCore;
using TshirtChallenge.Repository.Mappings;

namespace TshirtChallenge.Repository.Context
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainContext).Assembly);

            modelBuilder.ApplyConfiguration(new TshirtMapConfig());
            modelBuilder.ApplyConfiguration(new TypeMapConfig());
        }
    }
}
