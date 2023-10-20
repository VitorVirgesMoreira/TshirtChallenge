using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TshirtChallenge.Domain.Entities;

namespace TshirtChallenge.Infra.Mappings
{
    public class TshirtImageMapConfig : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("TshirtImages");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Data)
                .IsRequired();

            builder.HasOne(e => e.Type)
                .WithMany(e => e.TshirtImages)
                .HasForeignKey(e => e.TypeId)
                .IsRequired();
        }
    }
}
