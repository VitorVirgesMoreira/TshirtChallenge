using Microsoft.EntityFrameworkCore;
using TshirtChallenge.Infra.Mappings;

namespace TshirtChallenge.Infra.Context
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(MainContext).Assembly);

            modelBuilder.ApplyConfiguration(new TshirtMapConfig());
            modelBuilder.ApplyConfiguration(new TypeMapConfig());
            modelBuilder.ApplyConfiguration(new ImageMapConfig());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("SqlServerConnection");
            }
        }
    }
}
