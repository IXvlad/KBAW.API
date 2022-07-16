using KBAW.DataAccess.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KBAW.DataAccess.Configurations;

public class AuthorOfArticleConfiguration : IEntityTypeConfiguration<AuthorOfArticle>
{
    public void Configure(EntityTypeBuilder<AuthorOfArticle> builder)
    {
        builder.HasOne(x => x.Article)
            .WithMany(x => x.AuthorOfArticles)
            .HasForeignKey(x => x.ArticleId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Author)
            .WithMany(x => x.AuthorOfArticles)
            .HasForeignKey(x => x.AuthorId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}