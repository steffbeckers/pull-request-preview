using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PullRequestPreview.Data;
using Volo.Abp.DependencyInjection;

namespace PullRequestPreview.EntityFrameworkCore
{
    public class EntityFrameworkCorePullRequestPreviewDbSchemaMigrator
        : IPullRequestPreviewDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorePullRequestPreviewDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the PullRequestPreviewDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<PullRequestPreviewDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
