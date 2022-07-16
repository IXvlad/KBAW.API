using KBAW.DataAccess.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KBAW.DataAccess.Configurations;

public class AuthorOfBookConfiguration : IEntityTypeConfiguration<AuthorOfBook>
{
    public void Configure(EntityTypeBuilder<AuthorOfBook> builder)
    {
        builder.HasOne(x => x.Book)
            .WithMany(x => x.AuthorOfBooks)
            .HasForeignKey(x => x.BookId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Author)
            .WithMany(x => x.AuthorOfBooks)
            .HasForeignKey(x => x.AuthorId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}