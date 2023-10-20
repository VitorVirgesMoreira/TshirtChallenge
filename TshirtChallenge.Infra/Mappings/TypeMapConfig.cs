using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Type = TshirtChallenge.Domain.Entities.Type;

namespace TshirtChallenge.Infra.Mappings
{
    public class TypeMapConfig : IEntityTypeConfiguration<Type>
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {
            builder.ToTable("Types");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Color)
                .IsRequired();

            builder.Property(x => x.Fabric)
                .IsRequired();

            builder.HasMany(e => e.TshirtImages)
                .WithOne(e => e.Type)
                .HasForeignKey(e => e.TypeId)
                .IsRequired();

            builder.HasOne(e => e.Tshirt)
               .WithMany(e => e.Types)
               .HasForeignKey(e => e.TshirtId)
               .IsRequired();
        }
    }
}
