using PullRequestPreview.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace PullRequestPreview.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(PullRequestPreviewEntityFrameworkCoreModule),
        typeof(PullRequestPreviewApplicationContractsModule)
        )]
    public class PullRequestPreviewDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
