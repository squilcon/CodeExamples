using Examples.Core.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examples.Database.Configurations
{
    internal class ExampleChildTableConfiguration : IEntityTypeConfiguration<ExampleChildTableDB>
    {
        public void Configure(EntityTypeBuilder<ExampleChildTableDB> builder)
        {
            builder.ToTable("ExampleChildTable");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                   .IsRequired()
                   .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                   .IsRequired();

            builder.HasOne(child => child.Parent)
                   .WithMany(parent => parent.Children)
                   .HasForeignKey(child => child.ParentID);
        }
    }
}
