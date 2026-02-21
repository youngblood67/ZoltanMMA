using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZoltanMMA.Infrastructure.Internal.Persistence.Models;

namespace ZoltanMMA.Infrastructure.Internal.Persistence.Configurations
{
    public class FighterConfiguration : IEntityTypeConfiguration<FighterEf>
    {
        public void Configure(EntityTypeBuilder<FighterEf> builder)
        {
            builder.ToTable("Fighters");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(f => f.LastName)
              .IsRequired()
              .HasMaxLength(50);

            builder.Property(f => f.Nationality)
              .IsRequired()
              .HasMaxLength(50);
        }
    }
}
