using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TshirtChallenge.Domain.Entities;

namespace TshirtChallenge.Repository.Mappings
{
    public class TshirtImageMapConfig : IEntityTypeConfiguration<TshirtImage>
    {
        public void Configure(EntityTypeBuilder<TshirtImage> builder)
        {
            builder.ToTable("TshirtImages");

            builder.Property(x => x.Id)
               .UseIdentityColumn();

            builder.Property(x => x.ImagePath)
                .IsRequired();

            builder.HasOne(e => e.Type)
                .WithMany(e => e.TshirtImages)
                .HasForeignKey(e => e.TypeId)
                .IsRequired();
        }
    }
}
