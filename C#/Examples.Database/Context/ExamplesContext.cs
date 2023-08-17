using Examples.Core.Database.Entities;
using Examples.Database.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Examples.Database.Context
{
    public class ExamplesContext : DbContext
    {
        public ExamplesContext(DbContextOptions<ExamplesContext> options)
            : base(options) { }

        public DbSet<ExampleParentTableDB> ExamplesParentTable => Set<ExampleParentTableDB>();
        public DbSet<ExampleChildTableDB> ExamplesChildTable => Set<ExampleChildTableDB>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExampleParentTableConfiguration())
                        .ApplyConfiguration(new ExampleChildTableConfiguration());
        }
    }
}
