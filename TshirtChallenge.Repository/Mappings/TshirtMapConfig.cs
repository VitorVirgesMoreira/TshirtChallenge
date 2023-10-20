﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TshirtChallenge.Domain.Entities;

namespace TshirtChallenge.Repository.Mappings
{
    public class TshirtMapConfig : IEntityTypeConfiguration<Tshirt>
    {
        public void Configure(EntityTypeBuilder<Tshirt> builder)
        {
            builder.ToTable("Tshirts");

            builder.Property(x => x.Id)
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasMany(x => x.Types)
                .WithOne(x => x.Tshirt)
                .HasForeignKey(x => x.TshirtId)
                .IsRequired();
        }
    }
}
