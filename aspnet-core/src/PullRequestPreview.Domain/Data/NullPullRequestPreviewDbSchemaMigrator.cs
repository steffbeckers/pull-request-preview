using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PullRequestPreview.Data
{
    /* This is used if database provider does't define
     * IPullRequestPreviewDbSchemaMigrator implementation.
     */
    public class NullPullRequestPreviewDbSchemaMigrator : IPullRequestPreviewDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}