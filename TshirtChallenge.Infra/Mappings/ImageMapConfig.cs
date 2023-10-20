using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TshirtChallenge.Domain.Entities;

namespace TshirtChallenge.Infra.Mappings
{
    public class ImageMapConfig : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Images");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(i => i.Data)
                .HasColumnType("varbinary(max)")
                .IsRequired();

            builder.HasOne(e => e.Type)
                .WithMany(e => e.Images)
                .HasForeignKey(e => e.TypeId)
                .IsRequired();
        }
    }
}
