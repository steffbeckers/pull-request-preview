using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PullRequestPreview.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class PullRequestPreviewDbContextFactory : IDesignTimeDbContextFactory<PullRequestPreviewDbContext>
    {
        public PullRequestPreviewDbContext CreateDbContext(string[] args)
        {
            PullRequestPreviewEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<PullRequestPreviewDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new PullRequestPreviewDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../PullRequestPreview.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
