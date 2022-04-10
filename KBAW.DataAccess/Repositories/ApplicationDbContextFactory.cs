using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DomainModels.Repositories
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            const string connectionString = "Server=IXVLAD;Database=LocalKnowledgeBaseDB;Trusted_Connection=True;";

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionString, sqlOptions => sqlOptions.MigrationsAssembly("KBAW.Migrations"));

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}