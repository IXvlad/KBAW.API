using DomainModels.DomainsModel;
using Microsoft.EntityFrameworkCore;

namespace DomainModels.Repositories
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
            //
        }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Patent> Patents { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<AuthorOfArticle> AuthorOfArticles { get; set; }

        public DbSet<AuthorOfBook> AuthorOfBooks { get; set; }

        public DbSet<AuthorOfPatent> AuthorOfPatents { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Ydk> YdKs { get; set; }

        public DbSet<RecommendedBook> RecommendedBooks { get; set; }

        public DbSet<Source> Sources { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Source>()
                .Property(x => x.Name)
                .IsRequired();

            modelBuilder.Entity<Source>()
                .Property(x => x.Image)
                .IsRequired();

            modelBuilder.Entity<Article>()
                .HasOne(x => x.Source)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.SourceId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Book>()
                .HasOne(x => x.Source)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.SourceId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Patent>()
                .HasOne(x => x.Source)
                .WithMany(x => x.Patents)
                .HasForeignKey(x => x.SourceId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Article>()
                .HasOne(x => x.Ydk)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.YdkId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Book>()
                .HasOne(x => x.Ydk)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.YdkId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Patent>()
                .HasOne(x => x.Ydk)
                .WithMany(x => x.Patents)
                .HasForeignKey(x => x.YdkId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Article>()
                .HasOne(x => x.RecommendedBook)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.RecommendedBookId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Book>()
                .HasOne(x => x.RecommendedBook)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.RecommendedBookId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Patent>()
                .HasOne(x => x.RecommendedBook)
                .WithMany(x => x.Patents)
                .HasForeignKey(x => x.RecommendedBookId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AuthorOfArticle>()
                .HasOne(x => x.Article)
                .WithMany(x => x.AuthorOfArticles)
                .HasForeignKey(x => x.ArticleId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AuthorOfArticle>()
                .HasOne(x => x.Author)
                .WithMany(x => x.AuthorOfArticles)
                .HasForeignKey(x => x.AuthorId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AuthorOfBook>()
                .HasOne(x => x.Book)
                .WithMany(x => x.AuthorOfBooks)
                .HasForeignKey(x => x.BookId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AuthorOfBook>()
                .HasOne(x => x.Author)
                .WithMany(x => x.AuthorOfBooks)
                .HasForeignKey(x => x.AuthorId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AuthorOfPatent>()
                .HasOne(x => x.Patent)
                .WithMany(x => x.AuthorOfPatents)
                .HasForeignKey(x => x.PatentId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<AuthorOfPatent>()
                .HasOne(x => x.Author)
                .WithMany(x => x.AuthorOfPatents)
                .HasForeignKey(x => x.AuthorId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Book>()
                .HasOne(x => x.Country)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Patent>()
                .HasOne(x => x.Country)
                .WithMany(x => x.Patents)
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}