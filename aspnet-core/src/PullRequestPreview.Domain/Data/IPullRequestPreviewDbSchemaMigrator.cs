using System.Threading.Tasks;

namespace PullRequestPreview.Data
{
    public interface IPullRequestPreviewDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
