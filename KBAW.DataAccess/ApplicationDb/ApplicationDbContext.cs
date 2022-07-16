using KBAW.DataAccess.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace KBAW.DataAccess.ApplicationDb;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        //
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
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}