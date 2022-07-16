using KBAW.DataAccess.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KBAW.DataAccess.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasOne(x => x.Source)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.SourceId)
            .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasOne(x => x.Ydk)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.YdkId)
            .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasOne(x => x.RecommendedBook)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.RecommendedBookId)
            .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasOne(x => x.Country)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.CountryId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}