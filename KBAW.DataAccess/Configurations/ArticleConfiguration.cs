using KBAW.DataAccess.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KBAW.DataAccess.Configurations;

public class ArticleConfiguration : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.HasOne(x => x.Source)
            .WithMany(x => x.Articles)
            .HasForeignKey(x => x.SourceId)
            .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasOne(x => x.Ydk)
            .WithMany(x => x.Articles)
            .HasForeignKey(x => x.YdkId)
            .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasOne(x => x.RecommendedBook)
            .WithMany(x => x.Articles)
            .HasForeignKey(x => x.RecommendedBookId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}