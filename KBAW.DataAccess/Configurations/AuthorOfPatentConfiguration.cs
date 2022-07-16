using KBAW.DataAccess.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KBAW.DataAccess.Configurations;

public class AuthorOfPatentConfiguration : IEntityTypeConfiguration<AuthorOfPatent>
{
    public void Configure(EntityTypeBuilder<AuthorOfPatent> builder)
    {
        builder.HasOne(x => x.Patent)
            .WithMany(x => x.AuthorOfPatents)
            .HasForeignKey(x => x.PatentId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Author)
            .WithMany(x => x.AuthorOfPatents)
            .HasForeignKey(x => x.AuthorId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}