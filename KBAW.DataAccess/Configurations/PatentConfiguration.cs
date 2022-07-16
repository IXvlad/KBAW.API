using KBAW.DataAccess.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KBAW.DataAccess.Configurations;

public class PatentConfiguration : IEntityTypeConfiguration<Patent>
{
    public void Configure(EntityTypeBuilder<Patent> builder)
    {
        builder.HasOne(x => x.Source)
            .WithMany(x => x.Patents)
            .HasForeignKey(x => x.SourceId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Ydk)
            .WithMany(x => x.Patents)
            .HasForeignKey(x => x.YdkId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.RecommendedBook)
            .WithMany(x => x.Patents)
            .HasForeignKey(x => x.RecommendedBookId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Country)
            .WithMany(x => x.Patents)
            .HasForeignKey(x => x.CountryId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}