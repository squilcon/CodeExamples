using Examples.Core.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examples.Database.Configurations
{
    internal class ExampleParentTableConfiguration : IEntityTypeConfiguration<ExampleParentTableDB>
    {
        public void Configure(EntityTypeBuilder<ExampleParentTableDB> builder)
        {
            builder.ToTable("ExampleParentTable");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                   .IsRequired()
                   .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                   .IsRequired();
        }
    }
}
