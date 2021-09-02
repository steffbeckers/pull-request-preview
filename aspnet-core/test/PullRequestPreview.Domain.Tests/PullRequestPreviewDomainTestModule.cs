using PullRequestPreview.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PullRequestPreview
{
    [DependsOn(
        typeof(PullRequestPreviewEntityFrameworkCoreTestModule)
        )]
    public class PullRequestPreviewDomainTestModule : AbpModule
    {

    }
}